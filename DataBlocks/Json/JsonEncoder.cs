using System;
using System.Collections.Generic;
using System.Linq;

using Newtonsoft.Json.Linq;

using DataBlocks.Core;
using DataBlocks.Prelude;
using LanguageExt;

namespace DataBlocks.Json
{

    public static class JsonEncoder
    {

        public static Encoder<JToken, T> Create<T>(Func<T, JToken> encode) => new Encoder<JToken, T>(encode);

        public static readonly Encoder<JToken, bool> Bool = Create<bool>(v => new JValue(v));
        public static readonly Encoder<JToken, decimal> Decimal = Create<decimal>(v => new JValue(v));
        public static readonly Encoder<JToken, Guid> Guid = Create<Guid>(v => new JValue(v));
        public static readonly Encoder<JToken, int> Int = Create<int>(v => new JValue(v));
        public static readonly Encoder<JToken, string> String = Create<string>(v => JValue.CreateString(v));

        public static Encoder<JToken, Option<T>> Nullable<T>(Encoder<JToken, T> valueEncoder) =>
            Create<Option<T>>(v => v.Match(valueEncoder.Encode, () => JValue.CreateNull()));

        public static Encoder<JToken, IEnumerable<T>> Array<T>(Encoder<JToken, T> elementEncoder) =>
            Create<IEnumerable<T>>(v => new JArray(v.Select(elementEncoder.Encode)));

        public static Encoder<JToken, T> Lose<T>(Func<T, Void> f) => Encoder.Lose<JToken, T>(f);

        public static Encoder<JToken, T> Conquer<T>() => Encoder.Conquer<MonoidJToken, JToken, T>();

        public static Encoder<JToken, TProp> Property<TProp>(string fieldName, Encoder<JToken, TProp> fieldEncoder) =>
            fieldEncoder.Map(json => new JObject { [fieldName] = json } as JToken);

    }

}