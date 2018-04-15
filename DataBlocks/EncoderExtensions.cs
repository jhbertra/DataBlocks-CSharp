using System;

namespace DataBlocks
{

  public static class EncoderExtensions
  {

    public static Encoder<T1, T3> ComposeRight<T1, T2, T3>(this Encoder<T1, T2> g, Encoder<T2, T3> f)
      where T2 : struct, IMonoid<T2>
      where T3 : struct, IMonoid<T3>
    {
      return new Encoder<T1, T3>(x => f.Run(g.Run(x)));
    }

    public static Encoder<T1, T3> ComposeLeft<T1, T2, T3>(this Encoder<T2, T3> f, Encoder<T1, T2> g)
      where T2 : struct, IMonoid<T2>
      where T3 : struct, IMonoid<T3>
    {
      return new Encoder<T1, T3>(x => f.Run(g.Run(x)));
    }

    public static Encoder<T3, T4> Dimap<T1, T2, T3, T4>(this Encoder<T1, T2> e, Func<T3, T1> f, Func<T2, T4> g)
      where T2 : struct, IMonoid<T2>
      where T4 : struct, IMonoid<T4>
    {
      return new Encoder<T3, T4>(e.Run.ComposeLeft(f).ComposeRight(g));
    }

    public static Encoder<T1, T3> Map<T1, T2, T3>(this Encoder<T1, T2> e, Func<T2, T3> f)
      where T2 : struct, IMonoid<T2>
      where T3 : struct, IMonoid<T3>
    {
      return e.Dimap<T1, T2, T1, T3>(x => x, f);
    }

    public static Encoder<T3, T2> Contramap<T1, T2, T3>(this Encoder<T1, T2> e, Func<T3, T1> f)
      where T2 : struct, IMonoid<T2>
    {
      return e.Dimap(f, x => x);
    }

    public static Encoder<TWhole, TRaw> Case<TWhole, TRaw, TCase>(
        this Encoder<TWhole, TRaw> encoder,
        Func<TWhole, Maybe<TCase>> getter,
        Encoder<TCase, TRaw> caseEncoder)
      where TRaw : struct, IMonoid<TRaw>
    {
      return Encoder.Choose<TWhole, TRaw, TCase, TWhole>(
        x => getter(x).Match(
          Either<TCase, TWhole>.Case1,
          () => Either<TCase, TWhole>.Case2(x)),
        caseEncoder,
        encoder
      );
    }

    public static Encoder<TWhole, TRaw> Part<TWhole, TRaw, TPart>(
        this Encoder<TWhole, TRaw> encoder,
        Func<TWhole, TPart> getter,
        Encoder<TPart, TRaw> partEncoder)
      where TRaw : struct, IMonoid<TRaw>
    {
      return Encoder.Divide<TWhole, TRaw, TWhole, TPart>(x => (x, getter(x)), encoder, partEncoder);
    }

  }

}