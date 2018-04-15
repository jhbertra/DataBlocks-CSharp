using System;
using System.Collections.Generic;
using System.Linq;

using Newtonsoft.Json.Linq;

using DataBlocks.Core;
using DataBlocks.Prelude;

namespace DataBlocks.Json
{
    
  public static class JsonDecoder
  {

    public static Decoder<JsonWrapper, T> Create<T>(Func<string, JsonWrapper, Result<DecoderError, T>> decode) =>
      new Decoder<JsonWrapper, T>("", decode);

    public static Decoder<JsonWrapper, T> Return<T>(Result<ValueString, T> result) =>
      Create((id, _) => result.MapError(msg => DecoderError.Single(id, msg)));

    public static Decoder<JsonWrapper, T> Succeed<T>(T x) =>
      Return<T>(Result<ValueString, T>.Ok(x));

    public static Decoder<JsonWrapper, T> Fail<T>(ValueString e) =>
      Return<T>(Result<ValueString, T>.Error(e));

    public static readonly Decoder<JsonWrapper, bool> Bool = Create(
      (id, json) =>
        json.Value is JValue v && v.Type == JTokenType.Boolean
          ? Result<DecoderError, bool>.Ok((bool)v.Value)
          : Result<DecoderError, bool>.Error(DecoderError.Single(id, "Expected a boolean value."))
    );

    public static readonly Decoder<JsonWrapper, decimal> Decimal = Create(
      (id, json) =>
        json.Value is JValue v && v.Type == JTokenType.Float
          ? Result<DecoderError, decimal>.Ok((decimal)v.Value)
          : Result<DecoderError, decimal>.Error(DecoderError.Single(id, "Expected a decimal value."))
    );

    public static readonly Decoder<JsonWrapper, Guid> Guid = Create(
      (id, json) =>
        json.Value is JValue v && v.Type == JTokenType.Guid
          ? Result<DecoderError, Guid>.Ok((Guid)v.Value)
          : Result<DecoderError, Guid>.Error(DecoderError.Single(id, "Expected a GUID value."))
    );

    public static readonly Decoder<JsonWrapper, int> Int = Create(
      (id, json) =>
        json.Value is JValue v && v.Type == JTokenType.Integer
          ? Result<DecoderError, int>.Ok((int)v.Value)
          : Result<DecoderError, int>.Error(DecoderError.Single(id, "Expected an integer value."))
    );

    public static readonly Decoder<JsonWrapper, string> String = Create(
      (id, json) =>
        json.Value is JValue v && v.Type == JTokenType.String
          ? Result<DecoderError, string>.Ok((string)v.Value)
          : Result<DecoderError, string>.Error(DecoderError.Single(id, "Expected as string value."))
    );

    public static Decoder<JsonWrapper, Maybe<T>> Nullable<T>(this Decoder<JsonWrapper, T> valueDecoder) => 
      Create(
        (id, json) =>
          json.Value == null
            ? valueDecoder.Run(id, json).Map(Maybe<T>.Some)
            : Result<DecoderError, Maybe<T>>.Ok(Maybe<T>.None)
      );

    public static Decoder<JsonWrapper, IEnumerable<T>> Array<T>(Decoder<JsonWrapper, T> elementDecoder) => 
      Create(
        (id, json) =>
        json.Value is JArray arr
          ? arr
            .Values()
            .Select((element, i) => elementDecoder.Run($"{id}[{i}]", element))
            .Sequence()
          : Result<DecoderError, IEnumerable<T>>.Error(DecoderError.Single(id, "Expected an array."))
      );

    public static Decoder<JsonWrapper, Unit> Object<T>() => Succeed(Unit.Default);

    private static Decoder<JsonWrapper, T> Required<T>(string fieldName, Decoder<JsonWrapper, T> fieldDecoder) =>
      Create(
        (id, json) =>
        json.Value is JObject obj
          ? obj.ContainsKey(fieldName)
            ? fieldDecoder.Run($"{id}.{fieldName}", obj.Property(fieldName).Value)
            : Result<DecoderError, T>.Error(DecoderError.Single($"{id}.{fieldName}", "Value is required."))
          : Result<DecoderError, T>.Error(DecoderError.Single(id, "Expected an object."))
      );

    private static Decoder<JsonWrapper, Maybe<T>> Optional<T>(string fieldName, Decoder<JsonWrapper, T> decoder) =>
      Create(
        (id, json) =>
        json.Value is JObject obj
          ? obj.ContainsKey(fieldName)
            ? Nullable(decoder).Run($"{id}.{fieldName}", obj.Property(fieldName).Value)
            : Result<DecoderError, Maybe<T>>.Ok(Maybe<T>.None)
          : Result<DecoderError, Maybe<T>>.Error(DecoderError.Single(id, "Expected an object."))
      );

    public static Decoder<JsonWrapper, T> Required<T>(
        this Decoder<JsonWrapper, Unit> decoder,
        string fieldName,
        Decoder<JsonWrapper, T> fieldDecoder) =>
      Required(fieldName, fieldDecoder);

    public static Decoder<JsonWrapper, (T1, T2)> Required<T1, T2>(
        this Decoder<JsonWrapper, T1> decoder,
        string fieldName,
        Decoder<JsonWrapper, T2> fieldDecoder) =>
      decoder.Plus(Required(fieldName, fieldDecoder));

    public static Decoder<JsonWrapper, Maybe<T>> Optional<T>(
        this Decoder<JsonWrapper, Unit> decoder,
        string fieldName,
        Decoder<JsonWrapper, T> fieldDecoder) =>
      Optional(fieldName, fieldDecoder);

    public static Decoder<JsonWrapper, (T1, Maybe<T2>)> Optional<T1, T2>(
        this Decoder<JsonWrapper, T1> decoder,
        string fieldName,
        Decoder<JsonWrapper, T2> fieldDecoder) =>
      decoder.Plus(Optional(fieldName, fieldDecoder));

  }

}