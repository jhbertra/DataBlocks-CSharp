namespace DataBlocks
{

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

  }

}