using System;

namespace DataBlocks.Prelude
{

  public static class eitherExtensions
  {

    public static Either<T3, T4> Bimap<T1, T2, T3, T4>(
        this Either<T1, T2> either,
        Func<T1, T3> f,
        Func<T2, T4> g)
      {
        return either.Match(
          f.ComposeRight(Either<T3, T4>.Case1),
          g.ComposeRight(Either<T3, T4>.Case2)
        );
      }

    public static Either<T3, T2> MapLeft<T1, T2, T3>(this Either<T1, T2> either, Func<T1, T3> f)
    {
      return either.Bimap(f, e => e);
    }

    public static Either<T1, T3> MapRight<T1, T2, T3>(this Either<T1, T2> either, Func<T2, T3> f)
    {
      return either.Bimap(v => v, f);
    }

    public static Either<T1, T3> Select<T1, T2, T3>(this Either<T1, T2> either, Func<T2, T3> f)
    {
      return either.Bimap(v => v, f);
    }

    public static Either<T1, T3> Bind<T1, T2, T3>(this Either<T1, T2> either, Func<T2, Either<T1, T3>> f)
    {
      return either.Match(Either<T1, T3>.Case1, f);
    }

    public static Either<T1, T3> SelectMany<T1, T2, TIntermediate, T3>(this Either<T1, T2> either, Func<T2, Either<T1, TIntermediate>> f, Func<T2, TIntermediate, T3> project)
    {
      return either.Bind(x => f(x).MapRight(y => project(x, y)));
    }

    public static Func<TIn, Either<T1, T3>> KleisliRight<TIn, T1, T2, T3>(this Func<TIn, Either<T1, T2>> f, Func<T2, Either<T1, T3>> g)
    {
      return x => f(x).Bind(g);
    }

    public static Either<T1, (T2, T3)> Plus<T1, T2, T3>(this Either<T1, T2> either1, Either<T1, T3> either2)
    {
      return either1.Bind(v1 => either2.MapRight(v2 => (v1, v2)));
    }
    
  }

}