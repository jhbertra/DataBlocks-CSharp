using System;

namespace DataBlocks.Prelude
{

  public static class MaybeExtensions
  {

    public static Maybe<T2> Map<T1, T2>(this Maybe<T1> maybe, Func<T1, T2> f)
    {
      return maybe.Match(f.ComposeRight(Maybe<T2>.Some), () => Maybe<T2>.None);
    }

  }

}