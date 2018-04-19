using System;
using System.Linq;

using DataBlocks.Prelude;

namespace DataBlocks.Core
{

  public static class DecoderExtensions
  {

    public static Decoder<TRaw2, TRich2> Dimap<TRaw1, TRich1, TRaw2, TRich2>(
        this Decoder<TRaw1, TRich1> decoder,
        Func<TRaw2, TRaw1> f,
        Func<TRich1, TRich2> g)
      where TRaw1 : struct, IMonoid<TRaw1>
      where TRaw2 : struct, IMonoid<TRaw2>
    {
      return new Decoder<TRaw2, TRich2>("", (id, x) => decoder.Run(id, f(x)).Map(g));
    }

    public static Decoder<TRaw, TRich2> Map<TRaw, TRich1, TRich2>(
        this Decoder<TRaw, TRich1> decoder,
        Func<TRich1, TRich2> f)
      where TRaw : struct, IMonoid<TRaw>
    {
      return decoder.Dimap<TRaw, TRich1, TRaw, TRich2>(x => x, f);
    }

    public static Decoder<TRaw2, TRich> Contramap<TRaw1, TRich, TRaw2>(
        this Decoder<TRaw1, TRich> decoder,
        Func<TRaw2, TRaw1> f)
      where TRaw1 : struct, IMonoid<TRaw1>
      where TRaw2 : struct, IMonoid<TRaw2>
    {
      return decoder.Dimap(f, x => x);
    }

    public static Decoder<TRaw, TRich2> Bind<TRaw, TRich1, TRich2>(
        this Decoder<TRaw, TRich1> decoder,
        Func<TRich1, Decoder<TRaw, TRich2>> f)
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Decoder<TRaw, TRich2>(
        "",
        (id, x) =>
          from result1 in decoder.Run(id, x)
          from result2 in f(result1).Run(id, x)
          select result2
      );
    }

    public static Decoder<TRaw, Duple<TRich1, TRich2>> Plus<TRaw, TRich1, TRich2>(
        this Decoder<TRaw, TRich1> decoder1,
        Decoder<TRaw, TRich2> decoder2)
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Decoder<TRaw, Duple<TRich1, TRich2>>("", (id, x) => decoder1.Run(id, x).Plus(decoder2.Run(id, x)));
    }

    public static Decoder<TRaw, TRich> Or<TRaw, TRich>(
        this Decoder<TRaw, TRich> decoder1,
        Decoder<TRaw, TRich> decoder2)
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Decoder<TRaw, TRich>("", (id, x) => 
        decoder1.Run(id, x).Match(
          v1 => Result<DecoderError, TRich>.Ok(v1),
          _ => decoder2.Run(id, x))
      );
    }

    public static Decoder<TRaw, TRich> Compose<TRaw, TIntermediate, TRich>(
        this Decoder<TRaw, TIntermediate> left,
        Decoder<TIntermediate, TRich> right)
      where TRaw : struct, IMonoid<TRaw>
      where TIntermediate : struct, IMonoid<TIntermediate>
    {
      return new Decoder<TRaw, TRich>(
        "",
        (id, x) =>
          from intermediate in left.Run(id, x)
          from rich in right.Run(id, intermediate)
          select rich
      );
    }

    public static Decoder<TRaw, TRich> Construct<TRaw, TPart1, TPart2, TRich>(
        this Decoder<TRaw, (TPart1, TPart2)> decoder,
        Func<TPart1, TPart2, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
    {
      return decoder.Map(t => f(t.Item1, t.Item2));
    }

  }

}