using DataBlocks.Core;
using DataBlocks.Json;

using JetBrains.Annotations;

using LanguageExt;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using System;
using System.Collections.Generic;
using System.Linq;

namespace DataBlocks.Json
{

    /// <summary>
    /// Utilities for creating JSON codecs.
    /// </summary>
    public static class JsonCodec
    {


        /// <summary>
        /// Decode a JSON string.
        /// </summary>
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


        /// <summary>
        /// Encode the data to a JSON string.
        /// </summary>
        public static string EncodeString<T>(
            this Codec<JToken, T> codec,
            [NotNull] T value)
        {
            if (value == null) throw new ArgumentNullException(nameof(value));

            return codec.EncodeString(value, Formatting.Indented);
        }


        /// <summary>
        /// Encode the data to a JSON string using the given formatting
        /// and JsonConverters.
        /// </summary>
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


        /// <summary>
        /// Create a JSON codec from a decoder and an encoder.
        /// </summary>
        public static Codec<JToken, T> Create<T>(Decoder<JToken, T> decoder, Encoder<JToken, T> encoder) => new Codec<JToken, T>(decoder, encoder);

        private static Codec<JToken, TDec, TEnc> CreateFree<TEnc, TDec>(Decoder<JToken, TDec> decoder, Encoder<JToken, TEnc> encoder) =>
            new Codec<JToken, TDec, TEnc>(decoder, encoder, JsonUtil.Empty, JsonUtil.Append);


        /// <summary>
        /// Create a JSON codec from a pair of inverse functions.
        /// </summary>
        public static Codec<JToken, T> Lift<T>(Func<JToken, T> decode, Func<T, JToken> encode) => Codec.Lift(decode, encode);


        /// <summary>
        /// Codec for boolean values.
        /// </summary>
        public static readonly Codec<JToken, bool> Bool = Create(JsonDecoder.Bool, JsonEncoder.Bool);


        /// <summary>
        /// Codec for decimal values.
        /// </summary>
        public static readonly Codec<JToken, decimal> Decimal = Create(JsonDecoder.Decimal, JsonEncoder.Decimal);


        /// <summary>
        /// Codec for double values.
        /// </summary>
        public static readonly Codec<JToken, double> Double = Create(JsonDecoder.Double, JsonEncoder.Double);


        /// <summary>
        /// Codec for float values.
        /// </summary>
        public static readonly Codec<JToken, float> Float = Create(JsonDecoder.Float, JsonEncoder.Float);


        /// <summary>
        /// Codec for GUID values.
        /// </summary>
        public static readonly Codec<JToken, Guid> Guid = Create(JsonDecoder.Guid, JsonEncoder.Guid);


        /// <summary>
        /// Codec for int values.
        /// </summary>
        public static readonly Codec<JToken, int> Int = Create(JsonDecoder.Int, JsonEncoder.Int);


        /// <summary>
        /// Codec for string values.
        /// </summary>
        public static readonly Codec<JToken, string> String = Create(JsonDecoder.String, JsonEncoder.String);


        /// <summary>
        /// Codec for optional values.
        /// </summary>
        public static Codec<JToken, Option<T>> Nullable<T>(Codec<JToken, T> valueCodec) => Create(JsonDecoder.Nullable(valueCodec.Decoder), JsonEncoder.Nullable(valueCodec.Encoder));


        /// <summary>
        /// Codec for arrays.
        /// </summary>
        public static Codec<JToken, IEnumerable<T>> Array<T>(Codec<JToken, T> elementCodec) => Create(JsonDecoder.Array(elementCodec.Decoder), JsonEncoder.Array(elementCodec.Encoder));


        /// <summary>
        /// Start constructing a codec to handle objects.
        /// </summary>
        public static Codec<JToken, Unit, T> Object<T>() => Codec.BeginConstruction<JToken, T>(JsonUtil.Empty, JsonUtil.Append);


        /// <summary>
        /// Describes a required object field.
        /// </summary>
        public static Codec<JToken, TProp, T> Required<T, TProp>(
                this Codec<JToken, Unit, T> codec,
                string fieldName,
                Func<T, TProp> getter,
                Codec<JToken, TProp> fieldCodec) =>
            CreateFree(
                codec.Decoder.Required(fieldName, fieldCodec.Decoder),
                Encoder.Divide<JToken, T, T, TProp>(
                    JsonUtil.Append,
                    x => Pair.Create(x, getter(x)),
                    codec.Encoder,
                    JsonEncoder.Property(fieldName, fieldCodec.Encoder))
            );


        /// <summary>
        /// Describes a required object field.
        /// </summary>
        public static Codec<JToken, Pair<TPrev, TProp>, T> Required<T, TPrev, TProp>(
                this Codec<JToken, TPrev, T> codec,
                string fieldName,
                Func<T, TProp> getter,
                Codec<JToken, TProp> fieldCodec) =>
            CreateFree(
                codec.Decoder.Required(fieldName, fieldCodec.Decoder),
                Encoder.Divide<JToken, T, T, TProp>(
                    JsonUtil.Append,
                    x => Pair.Create(x, getter(x)),
                    codec.Encoder,
                    JsonEncoder.Property(fieldName, fieldCodec.Encoder))
            );


        /// <summary>
        /// Describes an optional object field.
        /// </summary>
        public static Codec<JToken, Option<TProp>, T> Optional<T, TProp>(
                this Codec<JToken, Unit, T> codec,
                string fieldName,
                Func<T, Option<TProp>> getter,
                Codec<JToken, TProp> fieldCodec) =>
            CreateFree(
                codec.Decoder.Optional(fieldName, fieldCodec.Decoder),
                Encoder.Divide<JToken, T, T, Option<TProp>>(
                    JsonUtil.Append,
                    x => Pair.Create(x, getter(x)),
                    codec.Encoder,
                    JsonEncoder.Property(fieldName, JsonEncoder.Nullable(fieldCodec.Encoder)))
            );


        /// <summary>
        /// Describes an optional object field.
        /// </summary>
        public static Codec<JToken, Pair<TPrev, Option<TProp>>, T> Optional<T, TPrev, TProp>(
                this Codec<JToken, TPrev, T> codec,
                string fieldName,
                Func<T, Option<TProp>> getter,
                Codec<JToken, TProp> fieldCodec) =>
            CreateFree(
                codec.Decoder.Optional(fieldName, fieldCodec.Decoder),
                Encoder.Divide<JToken, T, T, Option<TProp>>(
                    JsonUtil.Append,
                    x => Pair.Create(x, getter(x)),
                    codec.Encoder,
                    JsonEncoder.Property(fieldName, JsonEncoder.Nullable(fieldCodec.Encoder)))
            );


        /// <summary>
        /// Start a sequence of alternate representations.
        /// </summary>
        public static Codec<JToken, T> Switch<T>() => Codec.Switch<JToken, T>();

    }

}