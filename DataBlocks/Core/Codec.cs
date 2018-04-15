using System;

using DataBlocks.Prelude;

namespace DataBlocks.Core
{

  public sealed class Codec<TRaw, TRichEncoder, TRichDecoder>
    where TRaw : struct, IMonoid<TRaw>
  {

      public Codec(Decoder<TRaw, TRichDecoder> decoder, Encoder<TRichEncoder, TRaw> encoder)
      {
        this.Decoder = decoder;
        this.Encoder = encoder;
      }
      
      public readonly Decoder<TRaw, TRichDecoder> Decoder;
      public readonly Encoder<TRichEncoder, TRaw> Encoder;

  }

  public sealed class Codec<TRaw, TRich>
    where TRaw : struct, IMonoid<TRaw>
  {

      public Codec(Decoder<TRaw, TRich> decoder, Encoder<TRich, TRaw> encoder)
      {
        this.Decoder = decoder;
        this.Encoder = encoder;
      }
      
      public readonly Decoder<TRaw, TRich> Decoder;
      public readonly Encoder<TRich, TRaw> Encoder;

      public Result<DecoderError, TRich> Decode(TRaw raw) => this.Decoder.Run(this.Decoder.Id, raw);
      public TRaw Encode(TRich rich) => this.Encoder.Run(rich);

      public static implicit operator Codec<TRaw, TRich>(Codec<TRaw, TRich, TRich> disengaged)
      {
        return new Codec<TRaw, TRich>(disengaged.Decoder, disengaged.Encoder);
      }

  }

  public static class Codec
  {

    public static Codec<TRaw, TRichEncoder, Unit> BeginConstruction<TRaw, TRichEncoder>()
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Codec<TRaw, TRichEncoder, Unit>(
        Decoder<TRaw, Unit>.Succeed("", Unit.Default),
        Encoder<TRichEncoder, TRaw>.Zero
      );
    }

    public static Codec<TRaw, TWhole> Switch<TRaw, TWhole>()
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Codec<TRaw, TWhole>(
          Decoder<TRaw, TWhole>.Zero,
          Encoder<TWhole, TRaw>.Zero
      );
    }

    public static Codec<TRaw, TRich> Lift<TRaw, TRich>(Func<TRaw, TRich> decode, Func<TRich, TRaw> encode)
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Codec<TRaw, TRich>(
        new Decoder<TRaw, TRich>("", (_, x) => Result<DecoderError, TRich>.Ok(decode(x))),
        new Encoder<TRich, TRaw>(encode)
      );
    }
    
  }

}