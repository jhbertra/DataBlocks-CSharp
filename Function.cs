using System;

namespace DataBlocks
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

  }

}