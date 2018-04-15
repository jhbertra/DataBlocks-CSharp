using System;

namespace DataBlocks
{

  public static class FuncExtensions
  {

    public static Func<T1, T3> ComposeRight<T1, T2, T3>(this Func<T1, T2> g, Func<T2, T3> f)
    {

      return x => f(g(x));

    }

    public static Func<T1, T3> ComposeLeft<T1, T2, T3>(this Func<T2, T3> f, Func<T1, T2> g)
    {

      return x => f(g(x));

    }

    public static Func<T3, T4> Dimap<T1, T2, T3, T4>(this Func<T1, T2> f, Func<T3, T1> g, Func<T2, T4> h)
    {
      return h.ComposeLeft(f.ComposeLeft(g));
    }

    public static Func<T1, T3> Map<T1, T2, T3>(this Func<T1, T2> f, Func<T2, T3> g)
    {
      return f.Dimap<T1, T2, T1, T3>(x => x, g);
    }

    public static Func<T3, T2> Contramap<T1, T2, T3>(this Func<T1, T2> f, Func<T3, T1> g)
    {
      return f.Dimap(g, x => x);
    }

  }

}