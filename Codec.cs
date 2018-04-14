using System;

namespace DataBlocks
{

  public sealed class Codec<TRaw, TError, TRichEncoder, TRichDecoder>
    where TError : struct, IMonoid<TError>
    where TRaw : struct, IMonoid<TRaw>
  {

      public Codec(Decoder<TRaw, TError, TRichDecoder> decoder, Encoder<TRichEncoder, TRaw> encoder)
      {
        this.Decoder = decoder;
        this.Encoder = encoder;
      }
      
      public readonly Decoder<TRaw, TError, TRichDecoder> Decoder;
      public readonly Encoder<TRichEncoder, TRaw> Encoder;

  }

  public sealed class Codec<TRaw, TError, TRich>
    where TError : struct, IMonoid<TError>
    where TRaw : struct, IMonoid<TRaw>
  {

      public Codec(Decoder<TRaw, TError, TRich> decoder, Encoder<TRich, TRaw> encoder)
      {
        this.Decoder = decoder;
        this.Encoder = encoder;
      }
      
      public readonly Decoder<TRaw, TError, TRich> Decoder;
      public readonly Encoder<TRich, TRaw> Encoder;

      public Result<TError, TRich> Decode(TRaw raw) => this.Decoder.Run(raw);
      public TRaw Encode(TRich rich) => this.Encoder.Run(rich);

      public static implicit operator Codec<TRaw, TError, TRich>(Codec<TRaw, TError, TRich, TRich> disengaged)
      {
        return new Codec<TRaw, TError, TRich>(disengaged.Decoder, disengaged.Encoder);
      }

  }

  public static class Codec
  {

    public static Codec<TRaw, TError, TRichEncoder, TRichDecoder> Construct<TRaw, TError, TRichEncoder, TRichDecoder>(TRichDecoder f)
      where TRaw : struct, IMonoid<TRaw>
      where TError : struct, IMonoid<TError>
    {
      return new Codec<TRaw, TError, TRichEncoder, TRichDecoder>(
        Decoder<TRaw, TError, TRichDecoder>.Succeed(f),
        Encoder<TRichEncoder, TRaw>.Zero
      );
    }

    public static Codec<TRaw, TError, TWhole> Switch<TError, TRaw, TWhole>()
      where TRaw : struct, IMonoid<TRaw>
      where TError : struct, IMonoid<TError>
    {
      return new Codec<TRaw, TError, TWhole>(
          Decoder<TRaw, TError, TWhole>.Zero,
          Encoder<TWhole, TRaw>.Zero
      );
    }
    
  }

}