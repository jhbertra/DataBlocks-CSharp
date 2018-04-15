using System;
using System.Linq;

using DataBlocks.Prelude;

namespace DataBlocks.Core
{

  public static class DecoderExtensions
  {

    public static Decoder<TRaw2, TError, TRich2> Dimap<TError, TRaw1, TRich1, TRaw2, TRich2>(
        this Decoder<TRaw1, TError, TRich1> decoder,
        Func<TRaw2, TRaw1> f,
        Func<TRich1, TRich2> g)
      where TError : struct, IMonoid<TError>
      where TRaw1 : struct, IMonoid<TRaw1>
      where TRaw2 : struct, IMonoid<TRaw2>
    {
      return new Decoder<TRaw2, TError, TRich2>(
        f.ComposeRight(
          decoder.Run.KleisliRight(
            g.ComposeRight(
              Result<TError, TRich2>.Ok)))
      );
    }

    public static Decoder<TRaw, TError, TRich2> Map<TError, TRaw, TRich1, TRich2>(
        this Decoder<TRaw, TError, TRich1> decoder,
        Func<TRich1, TRich2> f)
      where TError : struct, IMonoid<TError>
      where TRaw : struct, IMonoid<TRaw>
    {
      return decoder.Dimap<TError, TRaw, TRich1, TRaw, TRich2>(x => x, f);
    }

    public static Decoder<TRaw2, TError, TRich> Contramap<TError, TRaw1, TRich, TRaw2>(
        this Decoder<TRaw1, TError, TRich> decoder,
        Func<TRaw2, TRaw1> f)
      where TError : struct, IMonoid<TError>
      where TRaw1 : struct, IMonoid<TRaw1>
      where TRaw2 : struct, IMonoid<TRaw2>
    {
      return decoder.Dimap(f, x => x);
    }

    public static Decoder<TRaw, TError, TRich2> Bind<TError, TRaw, TRich1, TRich2>(
        this Decoder<TRaw, TError, TRich1> decoder,
        Func<TRich1, Decoder<TRaw, TError, TRich2>> f)
      where TError : struct, IMonoid<TError>
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Decoder<TRaw, TError, TRich2>(
        x =>
          from result1 in decoder.Run(x)
          from result2 in f(result1).Run(x)
          select result2
      );
    }

    public static Decoder<TRaw, TError, (TRich1, TRich2)> Plus<TError, TRaw, TRich1, TRich2>(
        this Decoder<TRaw, TError, TRich1> decoder1,
        Decoder<TRaw, TError, TRich2> decoder2)
      where TError : struct, IMonoid<TError>
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Decoder<TRaw, TError, (TRich1, TRich2)>(x => decoder1.Run(x).Plus(decoder2.Run(x)));
    }

    public static Decoder<TRaw, TError, TRich2> LiftApply<TError, TRaw, TRich1, TRich2>(
        this Func<TRich1, TRich2> f,
        Decoder<TRaw, TError, TRich1> decoder)
      where TError : struct, IMonoid<TError>
      where TRaw : struct, IMonoid<TRaw>
    {
      return decoder.Map(f);
    }

    public static Decoder<TRaw, TError, TRich> Compose<TError, TRaw, TIntermediate, TRich>(
        this Decoder<TRaw, TError, TIntermediate> left,
        Decoder<TIntermediate, TError, TRich> right)
      where TError : struct, IMonoid<TError>
      where TRaw : struct, IMonoid<TRaw>
      where TIntermediate : struct, IMonoid<TIntermediate>
    {
      return new Decoder<TRaw, TError, TRich>(
        x =>
          from intermediate in left.Run(x)
          from rich in right.Run(intermediate)
          select rich
      );
    }

    public static Decoder<TRaw, TError, TRich> Construct<TError, TRaw, TPart1, TPart2, TRich>(
        this Decoder<TRaw, TError, (TPart1, TPart2)> decoder,
        Func<TPart1, TPart2, TRich> f)
      where TError : struct, IMonoid<TError>
      where TRaw : struct, IMonoid<TRaw>
    {
      return decoder.Map(t => f(t.Item1, t.Item2));
    }

  }

}