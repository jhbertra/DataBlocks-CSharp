using System;

namespace AfeCodec
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

    public static Encoder<TWhole, TRaw> Divide<TWhole, TRaw, TPart1, TPart2>(
        Func<TWhole, (TPart1, TPart2)> divide,
        Encoder<TPart1, TRaw> part1Encoder,
        Encoder<TPart2, TRaw> part2Encoder)
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Encoder<TWhole, TRaw>(
        divide
        .ComposeRight(FuncExtensions.Split(part1Encoder.Run, part2Encoder.Run)
        .ComposeRight(t => t.Item1.Append(t.Item2)))
      );
    }

    public static Func<Encoder<TWhole, TRaw>, Encoder<TWhole, TRaw>> Part<TWhole, TRaw, TPart>(
        Func<TWhole, TPart> getter,
        Encoder<TPart, TRaw> partEncoder)
      where TRaw : struct, IMonoid<TRaw>
    {
      return e2 => Divide<TWhole, TRaw, TPart, TWhole>(x => (getter(x), x), partEncoder, e2);
    }

    public static Encoder<TWhole, TRaw> Choose<TWhole, TRaw, TChoice1, TChoice2>(
        Func<TWhole, Either<TChoice1, TChoice2>> alternate,
        Encoder<TChoice1, TRaw> choice1Encoder,
        Encoder<TChoice2, TRaw> choice2Encoder)
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Encoder<TWhole, TRaw>(
        alternate.ComposeRight(FuncExtensions.FanIn(choice1Encoder.Run, choice2Encoder.Run))
      );
    }

    public static Func<Encoder<TWhole, TRaw>, Encoder<TWhole, TRaw>> Case<TWhole, TRaw, TCase>(
        Func<TWhole, Maybe<TCase>> getter,
        Encoder<TCase, TRaw> caseEncoder)
      where TRaw : struct, IMonoid<TRaw>
    {
      return e2 =>
        Choose<TWhole, TRaw, TCase, TWhole>(
          x => getter(x).Match(
            Either<TCase, TWhole>.Case1,
            () => Either<TCase, TWhole>.Case2(x)),
          caseEncoder,
          e2
        );
    }

  }

}