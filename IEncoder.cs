using System;

namespace AfeCodec
{

  public struct Encoder<TRich, TRaw> : IMonoid<Encoder<TRich, TRaw>>
    where TRaw : struct, IMonoid<TRaw>
  {

    public Encoder(Func<TRich, TRaw> run)
    {
      this.Run = run;
    }

    public readonly Func<TRich, TRaw> Run;

    public Encoder<TRich, TRaw> Zero => new Encoder<TRich, TRaw>(_ => default(TRaw).Zero);

    public Encoder<TRich, TRaw> Append(Encoder<TRich, TRaw> b)
    {
      var self = this;
      return new Encoder<TRich, TRaw>(x => self.Run(x).Append(b.Run(x)));
    }
    
    public static Encoder<TRich, TRaw> operator +(Encoder<TRich, TRaw> a, Encoder<TRich, TRaw> b) => a.Append(b);
    
  }

}