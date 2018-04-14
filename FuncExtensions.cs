using System;

namespace AfeCodec
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

  }

}