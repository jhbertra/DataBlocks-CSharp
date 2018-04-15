using Newtonsoft.Json.Linq;

using System.Collections.Generic;
using System.Linq;
using System;

using DataBlocks.Core;
using DataBlocks.Json;
using DataBlocks.Prelude;

namespace DataBlocks.Json
{

  public static class JsonCodec
  {

    public static Codec<JsonWrapper, T> Create<T>(Decoder<JsonWrapper, T> decoder, Encoder<T, JsonWrapper> encoder) =>
      new Codec<JsonWrapper, T>(decoder, encoder);

    private static Codec<JsonWrapper, TEnc, TDec> CreateFree<TEnc, TDec>(Decoder<JsonWrapper, TDec> decoder, Encoder<TEnc, JsonWrapper> encoder) =>
      new Codec<JsonWrapper, TEnc, TDec>(decoder, encoder);

    public static Codec<JsonWrapper, T> Lift<T>(Func<JsonWrapper, T> decode, Func<T, JsonWrapper> encode) =>
      Codec.Lift(decode, encode);

    public static readonly Codec<JsonWrapper, bool> Bool = Create(JsonDecoder.Bool, JsonEncoder.Bool);
    public static readonly Codec<JsonWrapper, decimal> Decimal = Create(JsonDecoder.Decimal, JsonEncoder.Decimal);
    public static readonly Codec<JsonWrapper, Guid> Guid = Create(JsonDecoder.Guid, JsonEncoder.Guid);
    public static readonly Codec<JsonWrapper, int> Int = Create(JsonDecoder.Int, JsonEncoder.Int);
    public static readonly Codec<JsonWrapper, string> String = Create(JsonDecoder.String, JsonEncoder.String);
    
    public static Codec<JsonWrapper, Maybe<T>> Nullable<T>(this Codec<JsonWrapper, T> valueCodec) => 
      Create(valueCodec.Decoder.Nullable(), valueCodec.Encoder.Nullable());

    public static Codec<JsonWrapper, IEnumerable<T>> Array<T>(Codec<JsonWrapper, T> elementCodec) => 
      Create(JsonDecoder.Array(elementCodec.Decoder), JsonEncoder.Array(elementCodec.Encoder));

    public static Codec<JsonWrapper, T, Unit> Object<T>() => Codec.BeginConstruction<JsonWrapper, T>();

    public static Codec<JsonWrapper, TObject, TProp> Required<TObject, TProp>(
        this Codec<JsonWrapper, TObject, Unit> codec,
        string fieldName,
        Func<TObject, TProp> getter,
        Codec<JsonWrapper, TProp> fieldCodec) =>
      CreateFree(
        codec.Decoder.Required(fieldName, fieldCodec.Decoder),
        codec.Encoder.Property(fieldName, getter, fieldCodec.Encoder)
      );

    public static Codec<JsonWrapper, TObject, (TPrev, TProp)> Required<TObject, TPrev, TProp>(
        this Codec<JsonWrapper, TObject, TPrev> codec,
        string fieldName,
        Func<TObject, TProp> getter,
        Codec<JsonWrapper, TProp> fieldCodec) =>
      CreateFree(
        codec.Decoder.Required(fieldName, fieldCodec.Decoder),
        codec.Encoder.Property(fieldName, getter, fieldCodec.Encoder)
      );

    public static Codec<JsonWrapper, TObject, Maybe<TProp>> Optional<TObject, TProp>(
        this Codec<JsonWrapper, TObject, Unit> codec,
        string fieldName,
        Func<TObject, Maybe<TProp>> getter,
        Codec<JsonWrapper, TProp> fieldCodec) =>
      CreateFree(
        codec.Decoder.Optional(fieldName, fieldCodec.Decoder),
        codec.Encoder.Property(fieldName, getter, fieldCodec.Encoder.Nullable())
      );

    public static Codec<JsonWrapper, TObject, (TPrev, Maybe<TProp>)> Optional<TObject, TPrev, TProp>(
        this Codec<JsonWrapper, TObject, TPrev> codec,
        string fieldName,
        Func<TObject, Maybe<TProp>> getter,
        Codec<JsonWrapper, TProp> fieldCodec) =>
      CreateFree(
        codec.Decoder.Optional(fieldName, fieldCodec.Decoder),
        codec.Encoder.Property(fieldName, getter, fieldCodec.Encoder.Nullable())
      );

    public static Codec<JsonWrapper, T> Switch<T>() => Codec.Switch<JsonWrapper, T>();

  }

}