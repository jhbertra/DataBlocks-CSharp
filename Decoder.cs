using System;
using System.Linq;

namespace DataBlocks
{

  public sealed class Decoder<TRaw, TError, TRich>
    where TError : struct, IMonoid<TError>
    where TRaw : struct, IMonoid<TRaw>
  {

    public readonly Func<TRaw, Result<TError, TRich>> Run;

    public Decoder(Func<TRaw, Result<TError, TRich>> run)
    {
      this.Run = run;
    }

    public static Decoder<TRaw, TError, TRich> Return(Result<TError, TRich> x)
    {
      return new Decoder<TRaw, TError, TRich>(_ => x);
    }

    public static Decoder<TRaw, TError, TRich> Succeed(TRich x)
    {
      return Decoder<TRaw, TError, TRich>.Return(Result<TError, TRich>.Ok(x));
    }

    public static Decoder<TRaw, TError, TRich> Fail(TError e)
    {
      return Decoder<TRaw, TError, TRich>.Return(Result<TError, TRich>.Error(e));
    }

    public static Decoder<TRaw, TError, TRich> Zero =>
      Decoder<TRaw, TError, TRich>.Return(Result<TError, TRich>.Zero);

  }

  public static class Decoder
  {

    public static Decoder<TRaw, TError, TRich> Choose<TError, TRaw, TRich>(
        params Decoder<TRaw, TError, TRich>[] decoders)
      where TError : struct, IMonoid<TError>
      where TRaw : struct, IMonoid<TRaw>
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

  }

}