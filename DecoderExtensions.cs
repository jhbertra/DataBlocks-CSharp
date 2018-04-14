using System;
using System.Linq;

namespace AfeCodec
{

  public static class DecoderExtensions
  {

    public static Decoder<TRaw2, TError, TRich2> Dimap<TError, TRaw1, TRich1, TRaw2, TRich2>(
        this Decoder<TRaw1, TError, TRich1> decoder,
        Func<TRaw2, TRaw1> f,
        Func<TRich1, TRich2> g)
      where TError : struct, IMonoid<TError>
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
    {
      return decoder.Dimap<TError, TRaw, TRich1, TRaw, TRich2>(x => x, f);
    }

    public static Decoder<TRaw2, TError, TRich> Contramap<TError, TRaw1, TRich, TRaw2>(
        this Decoder<TRaw1, TError, TRich> decoder,
        Func<TRaw2, TRaw1> f)
      where TError : struct, IMonoid<TError>
    {
      return decoder.Dimap(f, x => x);
    }

    public static Decoder<TRaw, TError, TRich2> Bind<TError, TRaw, TRich1, TRich2>(
        this Decoder<TRaw, TError, TRich1> decoder,
        Func<TRich1, Decoder<TRaw, TError, TRich2>> f)
      where TError : struct, IMonoid<TError>
    {
      return new Decoder<TRaw, TError, TRich2>(
        x =>
          from result1 in decoder.Run(x)
          from result2 in f(result1).Run(x)
          select result2
      );
    }

    public static Decoder<TRaw, TError, TRich2> Apply<TError, TRaw, TRich1, TRich2>(
        this Decoder<TRaw, TError, Func<TRich1, TRich2>> decoder1,
        Decoder<TRaw, TError, TRich1> decoder2)
      where TError : struct, IMonoid<TError>
    {
      return new Decoder<TRaw, TError, TRich2>(x => decoder1.Run(x).Apply(decoder2.Run(x)));
    }

    public static Decoder<TRaw, TError, TRich2> LiftApply<TError, TRaw, TRich1, TRich2>(
        this Func<TRich1, TRich2> f,
        Decoder<TRaw, TError, TRich1> decoder)
      where TError : struct, IMonoid<TError>
    {
      return decoder.Map(f);
    }

    public static Decoder<TRaw, TError, TRich> Choose<TError, TRaw, TRich>(
        params Decoder<TRaw, TError, TRich>[] decoders)
      where TError : struct, IMonoid<TError>
    {
      return new Decoder<TRaw, TError, TRich>(x =>
      {
        var last = Result<TError, TRich>.Zero;
        foreach (var result in decoders.Select(d => d.Run(x)))
        {
          if (result.IsOk)
          {
            return result;
          }
          last = result;
        }
        return last;
      });
    }

    public static Decoder<TRaw, TError, TRich> Compose<TError, TRaw, TIntermediate, TRich>(
        this Decoder<TRaw, TError, TIntermediate> left,
        Decoder<TIntermediate, TError, TRich> right)
      where TError : struct, IMonoid<TError>
    {
      return new Decoder<TRaw, TError, TRich>(
        x =>
          from intermediate in left.Run(x)
          from rich in right.Run(intermediate)
          select rich
      );
    }

  }

}