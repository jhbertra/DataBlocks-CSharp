using System;
using System.Linq;

using DataBlocks.Prelude;

namespace DataBlocks.Core
{

  public sealed class Decoder<TRaw, TRich> where TRaw : struct, IMonoid<TRaw>
  {

    public Decoder(string id, Func<string, TRaw, Result<DecoderError, TRich>> run)
    {
      this.Run = run;
      this.Id = id;
    }

    public static Decoder<TRaw, TRich> Return(string id, Result<DecoderError, TRich> x)
    {
      return new Decoder<TRaw, TRich>(id, (i, _) => x);
    }

    public static Decoder<TRaw, TRich> Succeed(string id, TRich x)
    {
      return Decoder<TRaw, TRich>.Return(id, Result<DecoderError, TRich>.Ok(x));
    }

    public static Decoder<TRaw, TRich> Fail(string id, DecoderError e)
    {
      return Decoder<TRaw, TRich>.Return(id, Result<DecoderError, TRich>.Error(e));
    }

    public readonly string Id;
    public readonly Func<string, TRaw, Result<DecoderError, TRich>> Run;

    public static Decoder<TRaw, TRich> Zero =>
      Decoder<TRaw, TRich>.Return("", Result<DecoderError, TRich>.Zero);

  }

  public static class Decoder
  {

    public static Decoder<TRaw, TRich> Choose<TRaw, TRich>(params Decoder<TRaw, TRich>[] decoders)
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Decoder<TRaw, TRich>(
        "",
        (id, x) =>
        {
          var last = Result<DecoderError, TRich>.Zero;
          foreach (var result in decoders.Select(d => d.Run(id, x)))
          {
            if (result.IsOk)
            {
              return result;
            }
            last = result;
          }
          return last;
        }
      );
    }

  }

}