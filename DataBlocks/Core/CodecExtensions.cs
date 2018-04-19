using System;

using DataBlocks.Prelude;

namespace DataBlocks.Core
{

  public static partial class CodecExtensions
  {

    public static Codec<TRaw2, TRich2> Invmap2<TRaw1, TRaw2, TRich1, TRich2>(
        this Codec<TRaw1, TRich1> codec,
        Func<TRaw1, TRaw2> f,
        Func<TRaw2, TRaw1> g,
        Func<TRich1, TRich2> h,
        Func<TRich2, TRich1> i)
      where TRaw1 : struct, IMonoid<TRaw1>
      where TRaw2 : struct, IMonoid<TRaw2>
    {
      return new Codec<TRaw2, TRich2>(
        codec.Decoder.Dimap(g, h),
        codec.Encoder.Dimap(i, f)
      );
    }

    public static Codec<TRaw2, TRich> InvmapRaw<TRaw1, TRaw2, TRich>(
        this Codec<TRaw1, TRich> codec,
        Func<TRaw1, TRaw2> f,
        Func<TRaw2, TRaw1> g)
      where TRaw1 : struct, IMonoid<TRaw1>
      where TRaw2 : struct, IMonoid<TRaw2>
    {
      return new Codec<TRaw2, TRich>(
        codec.Decoder.Contramap(g),
        codec.Encoder.Map(f)
      );
    }

    public static Codec<TRaw, TRich2> InvmapRich<TRaw, TRich1, TRich2>(
        this Codec<TRaw, TRich1> codec,
        Func<TRich1, TRich2> f,
        Func<TRich2, TRich1> g)
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Codec<TRaw, TRich2>(
        codec.Decoder.Map(f),
        codec.Encoder.Contramap(g)
      );
    }

    public static Codec<TRaw2, TRich2> Epimap2<TRaw1, TRaw2, TRich1, TRich2>(
        this Codec<TRaw1, TRich1> codec,
        Func<TRaw1, TRaw2> f,
        Func<TRaw2, Result<DecoderError, TRaw1>> g,
        Func<TRich1, Result<DecoderError, TRich2>> h,
        Func<TRich2, TRich1> i)
      where TRaw1 : struct, IMonoid<TRaw1>
      where TRaw2 : struct, IMonoid<TRaw2>
    {
      return new Codec<TRaw2, TRich2>(
        new Decoder<TRaw2, TRich2>("", (id, x) => g(x).Bind(y => codec.Decoder.Run(id, y)).Bind(h)),
        codec.Encoder.Dimap(i, f)
      );
    }

    public static Codec<TRaw2, TRich> EpimapRaw<TRaw1, TRaw2, TRich>(
        this Codec<TRaw1, TRich> codec,
        Func<TRaw1, TRaw2> f,
        Func<TRaw2, Result<DecoderError, TRaw1>> g)
      where TRaw1 : struct, IMonoid<TRaw1>
      where TRaw2 : struct, IMonoid<TRaw2>
    {
      return new Codec<TRaw2, TRich>(
        new Decoder<TRaw2, TRich>("", (id, x) => g(x).Bind(y => codec.Decoder.Run(id, y))),
        codec.Encoder.Map(f)
      );
    }

    public static Codec<TRaw, TRich2> EpimapRich<TRaw, TRich1, TRich2>(
        this Codec<TRaw, TRich1> codec,
        Func<TRich1, Result<DecoderError, TRich2>> f,
        Func<TRich2, TRich1> g)
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Codec<TRaw, TRich2>(
        new Decoder<TRaw, TRich2>("", (id, x) => codec.Decoder.Run(id, x).Bind(f)),
        codec.Encoder.Contramap(g)
      );
    }

    public static Codec<TRaw, TRich2> EpimapRichStringError<TRaw, TRich1, TRich2>(
        this Codec<TRaw, TRich1> codec,
        Func<TRich1, Result<ValueString, TRich2>> f,
        Func<TRich2, TRich1> g)
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Codec<TRaw, TRich2>(
        new Decoder<TRaw, TRich2>("", (id, x) => codec.Decoder.Run(id, x).Bind(y => f(y).MapError(msg => DecoderError.Single(id, msg)))),
        codec.Encoder.Contramap(g)
      );
    }

    public static Codec<TRaw, TRich> Compose<TRaw, TIntermediate, TRich>(
        this Codec<TRaw, TIntermediate> codec1,
        Codec<TIntermediate, TRich> codec2)
      where TIntermediate : struct, IMonoid<TIntermediate>
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Codec<TRaw, TRich>(
        codec1.Decoder.Compose(codec2.Decoder),
        codec2.Encoder.ComposeRight(codec1.Encoder)
      );
    }

    public static Codec<TRaw, TWhole, TPart> Part<TWhole, TRaw, TPart>(
        this Codec<TRaw, TWhole, Unit> codec,
        Func<TWhole, TPart> getter,
        Codec<TRaw, TPart> partCodec)
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Codec<TRaw, TWhole, TPart>(
        partCodec.Decoder,
        codec.Encoder.Part(getter, partCodec.Encoder)
      );
    }

    public static Codec<TRaw, TWhole, Duple<TPrevious, TPart>> Part<TWhole, TRaw, TPrevious, TPart>(
        this Codec<TRaw, TWhole, TPrevious> codec,
        Func<TWhole, TPart> getter,
        Codec<TRaw, TPart> partCodec)
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Codec<TRaw, TWhole, Duple<TPrevious, TPart>>(
        codec.Decoder.Plus(partCodec.Decoder),
        codec.Encoder.Part(getter, partCodec.Encoder)
      );
    }

    public static Codec<TRaw, TRich> Case<TRaw, TRich, TCase>(
        this Codec<TRaw, TRich> codec,
        Func<TRich, Maybe<TCase>> getter,
        Func<TCase, TRich> wrap,
        Codec<TRaw, TCase> caseCodec)
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Codec<TRaw, TRich>(
        codec.Decoder.Or(caseCodec.Decoder.Map(wrap)),
        codec.Encoder.Case(getter, caseCodec.Encoder)
      );
    }

    public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1>(
      this Codec<TRaw, TRich, T1> codec,
      Func<T1, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Codec<TRaw, TRich>(
        codec.Decoder.Map(t => f(t)),
        codec.Encoder
      );
    }

    public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2>(
      this Codec<TRaw, TRich, Duple<T1, T2>> codec,
      Func<T1, T2, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Codec<TRaw, TRich>(
        codec.Decoder.Map(t => f(t._1, t._2)),
        codec.Encoder
      );
    }

  }

}