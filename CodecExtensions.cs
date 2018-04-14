using System;

namespace DataBlocks
{

  public static class CodecExtensions
  {

    public static Codec<TRaw2, TError, TRich2> Invmap2<TError, TRaw1, TRaw2, TRich1, TRich2>(
        this Codec<TRaw1, TError, TRich1> codec,
        Func<TRaw1, TRaw2> f,
        Func<TRaw2, TRaw1> g,
        Func<TRich1, TRich2> h,
        Func<TRich2, TRich1> i)
      where TError : struct, IMonoid<TError>
      where TRaw1 : struct, IMonoid<TRaw1>
      where TRaw2 : struct, IMonoid<TRaw2>
    {
      return new Codec<TRaw2, TError, TRich2>(
        codec.Decoder.Dimap(g, h),
        codec.Encoder.Dimap(i, f)
      );
    }

    public static Codec<TRaw2, TError, TRich> InvmapRaw<TError, TRaw1, TRaw2, TRich>(
        this Codec<TRaw1, TError, TRich> codec,
        Func<TRaw1, TRaw2> f,
        Func<TRaw2, TRaw1> g)
      where TError : struct, IMonoid<TError>
      where TRaw1 : struct, IMonoid<TRaw1>
      where TRaw2 : struct, IMonoid<TRaw2>
    {
      return new Codec<TRaw2, TError, TRich>(
        codec.Decoder.Contramap(g),
        codec.Encoder.Map(f)
      );
    }

    public static Codec<TRaw, TError, TRich2> InvmapRich<TError, TRaw, TRich1, TRich2>(
        this Codec<TRaw, TError, TRich1> codec,
        Func<TRich1, TRich2> f,
        Func<TRich2, TRich1> g)
      where TError : struct, IMonoid<TError>
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Codec<TRaw, TError, TRich2>(
        codec.Decoder.Map(f),
        codec.Encoder.Contramap(g)
      );
    }

    public static Codec<TRaw2, TError, TRich2> Epimap2<TError, TRaw1, TRaw2, TRich1, TRich2>(
        this Codec<TRaw1, TError, TRich1> codec,
        Func<TRaw1, TRaw2> f,
        Func<TRaw2, Result<TError, TRaw1>> g,
        Func<TRich1, Result<TError, TRich2>> h,
        Func<TRich2, TRich1> i)
      where TError : struct, IMonoid<TError>
      where TRaw1 : struct, IMonoid<TRaw1>
      where TRaw2 : struct, IMonoid<TRaw2>
    {
      return new Codec<TRaw2, TError, TRich2>(
        new Decoder<TRaw2, TError, TRich2>(g.KleisliRight(codec.Decoder.Run).KleisliRight(h)),
        codec.Encoder.Dimap(i, f)
      );
    }

    public static Codec<TRaw2, TError, TRich> EpimapRaw<TError, TRaw1, TRaw2, TRich>(
        this Codec<TRaw1, TError, TRich> codec,
        Func<TRaw1, TRaw2> f,
        Func<TRaw2, Result<TError, TRaw1>> g)
      where TError : struct, IMonoid<TError>
      where TRaw1 : struct, IMonoid<TRaw1>
      where TRaw2 : struct, IMonoid<TRaw2>
    {
      return new Codec<TRaw2, TError, TRich>(
        new Decoder<TRaw2, TError, TRich>(g.KleisliRight(codec.Decoder.Run)),
        codec.Encoder.Map(f)
      );
    }

    public static Codec<TRaw, TError, TRich2> EpimapRich<TError, TRaw, TRich1, TRich2>(
        this Codec<TRaw, TError, TRich1> codec,
        Func<TRich1, Result<TError, TRich2>> f,
        Func<TRich2, TRich1> g)
      where TError : struct, IMonoid<TError>
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Codec<TRaw, TError, TRich2>(
        new Decoder<TRaw, TError, TRich2>(codec.Decoder.Run.KleisliRight(f)),
        codec.Encoder.Contramap(g)
      );
    }

    public static Codec<TRaw, TError, TRich> Compose<TError, TRaw, TIntermediate, TRich>(
        this Codec<TRaw, TError, TIntermediate> codec1,
        Codec<TIntermediate, TError, TRich> codec2)
      where TError : struct, IMonoid<TError>
      where TIntermediate : struct, IMonoid<TIntermediate>
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Codec<TRaw, TError, TRich>(
        codec1.Decoder.Compose(codec2.Decoder),
        codec2.Encoder.ComposeRight(codec1.Encoder)
      );
    }

    public static Codec<TRaw, TError, TWhole, TNext> Part<TError, TWhole, TRaw, TNext, TPart>(
        this Codec<TRaw, TError, TWhole, Func<TPart, TNext>> codec,
        Func<TWhole, TPart> getter,
        Codec<TRaw, TError, TPart> partCodec)
      where TRaw : struct, IMonoid<TRaw>
      where TError : struct, IMonoid<TError>
    {
      return new Codec<TRaw, TError, TWhole, TNext>(
        codec.Decoder.Apply(partCodec.Decoder),
        codec.Encoder.Part(getter, partCodec.Encoder)
      );
    }

    public static Codec<TRaw, TError, TRich> Case<TRaw, TError, TRich, TCase>(
        this Codec<TRaw, TError, TRich> codec,
        Func<TRich, Maybe<TCase>> getter,
        Func<TCase, TRich> wrap,
        Codec<TRaw, TError, TCase> caseCodec)
      where TRaw : struct, IMonoid<TRaw>
      where TError : struct, IMonoid<TError>
    {
      return new Codec<TRaw, TError, TRich>(
        Decoder.Choose(caseCodec.Decoder.Map(wrap), codec.Decoder),
        codec.Encoder.Case(getter, caseCodec.Encoder)
      );
    }

  }

}