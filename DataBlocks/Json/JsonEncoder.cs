using System;
using System.Collections.Generic;
using System.Linq;

using Newtonsoft.Json.Linq;

using DataBlocks.Core;
using LanguageExt;

namespace DataBlocks.Json
{

    /// <summary>
    /// Utilities for encoding JSON
    /// </summary>
    public static class JsonEncoder
    {

        /// <summary>
        /// Create a new JSON encoder from a function.
        /// </summary>
        public static Encoder<JToken, T> Create<T>(Func<T, JToken> encode) => new Encoder<JToken, T>(encode);


        /// <summary>
        /// Encodes a boolean value to JSON
        /// </summary>
        public static readonly Encoder<JToken, bool> Bool = Create<bool>(v => new JValue(v));


        /// <summary>
        /// Encodes a decimal value to JSON
        /// </summary>
        public static readonly Encoder<JToken, decimal> Decimal = Create<decimal>(v => new JValue(v));


        /// <summary>
        /// Encodes a double value to JSON
        /// </summary>
        public static readonly Encoder<JToken, double> Double = Create<double>(v => new JValue(v));


        /// <summary>
        /// Encodes a float value to JSON
        /// </summary>
        public static readonly Encoder<JToken, float> Float = Create<float>(v => new JValue(v));


        /// <summary>
        /// Encodes a GUID value to JSON
        /// </summary>
        public static readonly Encoder<JToken, Guid> Guid = Create<Guid>(v => new JValue(v));


        /// <summary>
        /// Encodes an integer value to JSON
        /// </summary>
        public static readonly Encoder<JToken, int> Int = Create<int>(v => new JValue(v));


        /// <summary>
        /// Encodes a string value to JSON
        /// </summary>
        public static readonly Encoder<JToken, string> String = Create<string>(v => JValue.CreateString(v));


        /// <summary>
        /// Create an encoder that represents optional values with null.
        /// </summary>
        public static Encoder<JToken, Option<T>> Nullable<T>(Encoder<JToken, T> valueEncoder) =>
            Create<Option<T>>(v => v.Match(valueEncoder.Invoke, () => JValue.CreateNull()));


        /// <summary>
        /// Create an encoder that runs the given encoder over an enumerable
        /// to write a JSON array.
        /// </summary>
        public static Encoder<JToken, IEnumerable<T>> Array<T>(Encoder<JToken, T> elementEncoder) =>
            Create<IEnumerable<T>>(v => new JArray(v.Select(elementEncoder.Invoke)));


        /// <summary>
        /// Overload of Encoder.Lose to reduce type parameters
        /// </summary>
        public static Encoder<JToken, T> Lose<T>(Func<T, Void> f) => Encoder.Lose<JToken, T>(f);


        /// <summary>
        /// Overload of Encoder.Conquer to reduce type parameters and provide
        /// JSON-specific implementation of the empty parameter.
        /// </summary>
        public static Encoder<JToken, T> Conquer<T>() => Encoder.Conquer<JToken, T>(JsonUtil.Empty);


        /// <summary>
        /// writes the output of the given encoder to a JSON object with a property
        /// with name fieldName.
        /// </summary>
        public static Encoder<JToken, TProp> Property<TProp>(string fieldName, Encoder<JToken, TProp> fieldEncoder) =>
            fieldEncoder.Map(json => new JObject { [fieldName] = json } as JToken);

    }

}