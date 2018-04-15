using System;

namespace DataBlocks
{

  public class Encoder<TRich, TRaw>
    where TRaw : struct, IMonoid<TRaw>
  {

    public static Encoder<TRich, TRaw> Zero => new Encoder<TRich, TRaw>(_ => default(TRaw).Zero);

    public Encoder(Func<TRich, TRaw> run)
    {
      this.Run = run;
    }

    public readonly Func<TRich, TRaw> Run;

  }

  public static class Encoder
  {

    public static Encoder<TWhole, TRaw> Build<TWhole, TRaw>()
      where TRaw : struct, IMonoid<TRaw>
    {
      return Encoder<TWhole, TRaw>.Zero;
    }

    public static Encoder<TWhole, TRaw> Divide<TWhole, TRaw, TPart1, TPart2>(
        Func<TWhole, (TPart1, TPart2)> divide,
        Encoder<TPart1, TRaw> part1Encoder,
        Encoder<TPart2, TRaw> part2Encoder)
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Encoder<TWhole, TRaw>(
        divide
        .ComposeRight(Function.Split(part1Encoder.Run, part2Encoder.Run)
        .ComposeRight(t => t.Item1.Append(t.Item2)))
      );
    }

    public static Encoder<TWhole, TRaw> Switch<TWhole, TRaw>()
      where TRaw : struct, IMonoid<TRaw>
    {
      return Encoder<TWhole, TRaw>.Zero;
    }

    public static Encoder<TWhole, TRaw> Choose<TWhole, TRaw, TChoice1, TChoice2>(
        Func<TWhole, Either<TChoice1, TChoice2>> alternate,
        Encoder<TChoice1, TRaw> choice1Encoder,
        Encoder<TChoice2, TRaw> choice2Encoder)
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Encoder<TWhole, TRaw>(
        alternate.ComposeRight(Function.FanIn(choice1Encoder.Run, choice2Encoder.Run))
      );
    }

  }

}