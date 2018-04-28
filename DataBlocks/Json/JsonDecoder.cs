using System;
using System.Collections.Generic;
using System.Linq;

using Newtonsoft.Json.Linq;

using DataBlocks.Core;
using DataBlocks.Prelude;
using LanguageExt;
using System.Collections.Immutable;

namespace DataBlocks.Json
{

    public static class JsonDecoder
    {

        public static Decoder<JToken, T> Create<T>(Func<string, JToken, Either<DecoderErrors, T>> decode) => new Decoder<JToken, T>(decode, "$");
        public static Decoder<JToken, T> Return<T>(Either<DecoderErrors, T> result) => Create((id, _) => result);

        private static Decoder<JToken, T> Value<T>(string description, Func<JValue, bool> valuePredicate, Func<object, T> convert) =>
            Create(
                (id, json) =>
                    json is JValue v && valuePredicate(v)
                      ? (Either<DecoderErrors, T>)convert(v.Value)
                      : DecoderErrors.Single(id, $"Expected {description} value"));

        public static readonly Decoder<JToken, bool> Bool =
            Value("a boolean", v => v.Type == JTokenType.Boolean, Convert.ToBoolean);

        public static readonly Decoder<JToken, decimal> Decimal =
            Value("a decimal", v => v.Type == JTokenType.Float || v.Type == JTokenType.Integer, Convert.ToDecimal);

        public static readonly Decoder<JToken, double> Double =
            Value("a double", v => v.Type == JTokenType.Float || v.Type == JTokenType.Integer, Convert.ToDouble);

        public static readonly Decoder<JToken, float> Float =
            Value("a float", v => v.Type == JTokenType.Float || v.Type == JTokenType.Integer, Convert.ToSingle);

        public static readonly Decoder<JToken, Guid> Guid =
            Value(
                "a GUID",
                v => v.Type == JTokenType.Guid || v.Type == JTokenType.String && System.Guid.TryParse((string)v.Value, out var guid),
                x => x as Guid? ?? System.Guid.Parse((string)x));

        public static readonly Decoder<JToken, int> Int =
            Value("an integer", v => v.Type == JTokenType.Integer, Convert.ToInt32);

        public static readonly Decoder<JToken, string> String =
            Value("a string", v => v.Type == JTokenType.String, x => (string)x);

        public static Decoder<JToken, Option<T>> Nullable<T>(Decoder<JToken, T> valueDecoder) =>
            Create((id, json) =>
                json.Type == JTokenType.Null
                    ? Option<T>.None
                    : valueDecoder.Run(id, json).Map(Option<T>.Some));

        public static Decoder<JToken, IEnumerable<T>> Array<T>(Decoder<JToken, T> elementDecoder) =>
            Create((id, json) =>
            {
                if (json is JArray arr)
                {
                    var results = arr.Values()
                        .Select((element, i) => elementDecoder.Run($"{id}[{i}]", element))
                        .Aggregate(
                            new
                            {
                                Results = ImmutableList.Create<T>(),
                                Errors = DecoderErrors.Zero
                            },
                            (state, r) =>
                                r.Match(
                                    v => new { Results = state.Results.Add(v), state.Errors },
                                    e => new { state.Results, Errors = state.Errors.Append(e) })
                        );

                    return results.Errors.Errors.Any()
                        ? (Either<DecoderErrors, IEnumerable<T>>)results.Errors
                        : results.Results;
                }
                else
                {
                    return DecoderErrors.Single(id, "Expected an array");
                }
            });

        public static Decoder<JToken, Unit> Object<T>() => Return<Unit>(Unit.Default);

        private static Decoder<JToken, T> Required<T>(string fieldName, Decoder<JToken, T> fieldDecoder) =>
            Create(
                (id, json) =>
                {
                    var fieldPath = id == string.Empty ? fieldName : $"{id}.{fieldName}";
                    return json is JObject obj
                        ? obj.ContainsKey(fieldName)
                            ? fieldDecoder.Run(fieldPath, obj.Property(fieldName).Value)
                            : DecoderErrors.Single(fieldPath, "Value is required")
                        : DecoderErrors.Single(id, "Expected an object");
                }
            );

        private static Decoder<JToken, Option<T>> Optional<T>(string fieldName, Decoder<JToken, T> decoder) =>
            Create(
                (id, json) =>
                {
                    var fieldPath = id == string.Empty ? fieldName : $"{id}.{fieldName}";
                    return json is JObject obj
                        ? obj.ContainsKey(fieldName)
                            ? Nullable(decoder).Run(fieldPath, obj.Property(fieldName).Value)
                            : Option<T>.None
                        : DecoderErrors.Single(id, "Expected an object");
                }
            );

        public static Decoder<JToken, T> Required<T>(
            this Decoder<JToken, Unit> decoder,
            string fieldName,
            Decoder<JToken, T> fieldDecoder) =>
          Required(fieldName, fieldDecoder);

        public static Decoder<JToken, Pair<T1, T2>> Required<T1, T2>(
            this Decoder<JToken, T1> decoder,
            string fieldName,
            Decoder<JToken, T2> fieldDecoder) =>
          decoder.Combine(Required(fieldName, fieldDecoder));

        public static Decoder<JToken, Option<T>> Optional<T>(
            this Decoder<JToken, Unit> decoder,
            string fieldName,
            Decoder<JToken, T> fieldDecoder) =>
          Optional(fieldName, fieldDecoder);

        public static Decoder<JToken, Pair<T1, Option<T2>>> Optional<T1, T2>(
            this Decoder<JToken, T1> decoder,
            string fieldName,
            Decoder<JToken, T2> fieldDecoder) =>
          decoder.Combine(Optional(fieldName, fieldDecoder));

    }

}