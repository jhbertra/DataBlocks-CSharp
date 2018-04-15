using System;

namespace DataBlocks.Prelude
{

  public static class Function
  {

    public static Func<(T1, T2), (T3, T4)> Split<T1, T2, T3, T4>(Func<T1, T3> f, Func<T2, T4> g)
    {
      return t => (f(t.Item1), g(t.Item2));
    }

    public static Func<Either<T1, T2>, T3> FanIn<T1, T2, T3>(Func<T1, T3> f, Func<T2, T3> g)
    {
      return t => t.Match(f, g);
    }

    public static Func<T1, T2> Curry1<T1, T2>(Func<T1, T2> f)
    {
      return f;
    }

    public static Func<T1, Func<T2, T3>> Curry2<T1, T2, T3>(Func<T1, T2, T3> f)
    {
      return t1 => t2 => f(t1, t2);
    }

  }

}