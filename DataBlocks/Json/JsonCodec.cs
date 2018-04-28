using DataBlocks.Core;
using DataBlocks.Json;
using DataBlocks.Prelude;

using JetBrains.Annotations;

using LanguageExt;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using System;
using System.Collections.Generic;
using System.Linq;

namespace DataBlocks.Json
{

    public static class JsonCodec
    {

        public static Either<DecoderErrors, T> DecodeString<T>(
            this Codec<JToken, T> codec,
            [NotNull] string json)
        {
            if (json == null) throw new ArgumentNullException(nameof(json));

            try
            {
                var jToken = JToken.Parse(json);
                return codec.Decode(jToken);
            }
            catch (JsonException e)
            {
                return DecoderErrors.Single("", $"Syntax error: {e.Message}");
            }
        }

        public static string EncodeString<T>(
            this Codec<JToken, T> codec,
            [NotNull] T value)
        {
            if (value == null) throw new ArgumentNullException(nameof(value));

            return codec.EncodeString(value, Formatting.Indented);
        }

        public static string EncodeString<T>(
            this Codec<JToken, T> codec,
            [NotNull] T value,
            Formatting formatting,
            [NotNull] params JsonConverter[] converters)
        {
            if (value == null) throw new ArgumentNullException(nameof(value));
            if (converters == null) throw new ArgumentNullException(nameof(converters));

            return codec.Encode(value).ToString(formatting, converters);
        }

        public static Codec<JToken, T> Create<T>(Decoder<JToken, T> decoder, Encoder<JToken, T> encoder) => new Codec<JToken, T>(decoder, encoder);

        private static Codec<MonoidJToken, JToken, TDec, TEnc> CreateFree<TEnc, TDec>(Decoder<JToken, TDec> decoder, Encoder<JToken, TEnc> encoder) =>
            new Codec<MonoidJToken, JToken, TDec, TEnc>(decoder, encoder);

        public static Codec<JToken, T> Lift<T>(Func<JToken, T> decode, Func<T, JToken> encode) => Codec.Lift(decode, encode);

        public static readonly Codec<JToken, bool> Bool = Create(JsonDecoder.Bool, JsonEncoder.Bool);
        public static readonly Codec<JToken, decimal> Decimal = Create(JsonDecoder.Decimal, JsonEncoder.Decimal);
        public static readonly Codec<JToken, Guid> Guid = Create(JsonDecoder.Guid, JsonEncoder.Guid);
        public static readonly Codec<JToken, int> Int = Create(JsonDecoder.Int, JsonEncoder.Int);
        public static readonly Codec<JToken, string> String = Create(JsonDecoder.String, JsonEncoder.String);

        public static Codec<JToken, Option<T>> Nullable<T>(Codec<JToken, T> valueCodec) => Create(JsonDecoder.Nullable(valueCodec.Decoder), JsonEncoder.Nullable(valueCodec.Encoder));

        public static Codec<JToken, IEnumerable<T>> Array<T>(Codec<JToken, T> elementCodec) => Create(JsonDecoder.Array(elementCodec.Decoder), JsonEncoder.Array(elementCodec.Encoder));

        public static Codec<MonoidJToken, JToken, Unit, T> Object<T>() => Codec.BeginConstruction<MonoidJToken, JToken, T>();

        public static Codec<MonoidJToken, JToken, TProp, T> Required<T, TProp>(
                this Codec<MonoidJToken, JToken, Unit, T> codec,
                string fieldName,
                Func<T, TProp> getter,
                Codec<JToken, TProp> fieldCodec) =>
            CreateFree(
                codec.Decoder.Required(fieldName, fieldCodec.Decoder),
                Encoder.Divide<MonoidJToken, JToken, T, T, TProp>(
                    x => Pair.Create(x, getter(x)),
                    codec.Encoder,
                    JsonEncoder.Property(fieldName, fieldCodec.Encoder))
            );

        public static Codec<MonoidJToken, JToken, Pair<TPrev, TProp>, T> Required<T, TPrev, TProp>(
                this Codec<MonoidJToken, JToken, TPrev, T> codec,
                string fieldName,
                Func<T, TProp> getter,
                Codec<JToken, TProp> fieldCodec) =>
            CreateFree(
                codec.Decoder.Required(fieldName, fieldCodec.Decoder),
                Encoder.Divide<MonoidJToken, JToken, T, T, TProp>(
                    x => Pair.Create(x, getter(x)),
                    codec.Encoder,
                    JsonEncoder.Property(fieldName, fieldCodec.Encoder))
            );

        public static Codec<MonoidJToken, JToken, Option<TProp>, T> Optional<T, TProp>(
                this Codec<MonoidJToken, JToken, Unit, T> codec,
                string fieldName,
                Func<T, Option<TProp>> getter,
                Codec<JToken, TProp> fieldCodec) =>
            CreateFree(
                codec.Decoder.Optional(fieldName, fieldCodec.Decoder),
                Encoder.Divide<MonoidJToken, JToken, T, T, Option<TProp>>(
                    x => Pair.Create(x, getter(x)),
                    codec.Encoder,
                    JsonEncoder.Property(fieldName, JsonEncoder.Nullable(fieldCodec.Encoder)))
            );

        public static Codec<MonoidJToken, JToken, Pair<TPrev, Option<TProp>>, T> Optional<T, TPrev, TProp>(
                this Codec<MonoidJToken, JToken, TPrev, T> codec,
                string fieldName,
                Func<T, Option<TProp>> getter,
                Codec<JToken, TProp> fieldCodec) =>
            CreateFree(
                codec.Decoder.Optional(fieldName, fieldCodec.Decoder),
                Encoder.Divide<MonoidJToken, JToken, T, T, Option<TProp>>(
                    x => Pair.Create(x, getter(x)),
                    codec.Encoder,
                    JsonEncoder.Property(fieldName, JsonEncoder.Nullable(fieldCodec.Encoder)))
            );

        public static Codec<JToken, T> Switch<T>() => Codec.Switch<JToken, T>();

    }

}