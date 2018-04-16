using System;
using System.Collections.Generic;
using System.Linq;

using Newtonsoft.Json.Linq;

using DataBlocks.Core;
using DataBlocks.Prelude;

namespace DataBlocks.Json
{
    
  public static class JsonEncoder
  {

    public static Encoder<T, JsonWrapper> Create<T>(Func<T, JsonWrapper> encode) => new Encoder<T, JsonWrapper>(encode);

    public static readonly Encoder<bool, JsonWrapper> Bool = Create<bool>(v => new JValue(v));
    public static readonly Encoder<decimal, JsonWrapper> Decimal = Create<decimal>(v => new JValue(v));
    public static readonly Encoder<Guid, JsonWrapper> Guid = Create<Guid>(v => new JValue(v));
    public static readonly Encoder<int, JsonWrapper> Int = Create<int>(v => new JValue(v));
    public static readonly Encoder<string, JsonWrapper> String = Create<string>(v => JValue.CreateString(v));

    public static Encoder<Maybe<T>, JsonWrapper> Nullable<T>(Encoder<T, JsonWrapper> valueEncoder) =>
      Create<Maybe<T>>(v => v.Match(valueEncoder.Run, () => JValue.CreateNull()));

    public static Encoder<IEnumerable<T>, JsonWrapper> Array<T>(Encoder<T, JsonWrapper> elementEncoder) =>
      Create<IEnumerable<T>>(v => new JArray(v.Select(x => elementEncoder.Run(x).Value)));

    public static Encoder<T, JsonWrapper> Switch<T>() => Encoder<T, JsonWrapper>.Zero;

    public static Encoder<TObject, JsonWrapper> Object<TObject>() => Encoder.Build<TObject, JsonWrapper>();

    public static Encoder<TProp, JsonWrapper> Property<TProp>(string fieldName, Encoder<TProp, JsonWrapper> fieldEncoder) =>
      fieldEncoder.Map<TProp, JsonWrapper, JsonWrapper>(json => new JObject{ [fieldName] = json });

    public static Encoder<TObject, JsonWrapper> Property<TObject, TProp>(
        this Encoder<TObject, JsonWrapper> objectEncoder,
        string fieldName, Func<TObject, TProp> getter,
        Encoder<TProp, JsonWrapper> fieldEncoder) =>
      objectEncoder.Part(getter, Property(fieldName, fieldEncoder));

  }

}