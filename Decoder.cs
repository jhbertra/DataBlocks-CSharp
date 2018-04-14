using System;

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

}