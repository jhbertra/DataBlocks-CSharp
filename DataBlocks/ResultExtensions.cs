using System;

namespace DataBlocks
{

  public static class ResultExtensions
  {

    public static Result<TError2, T2> Bimap<TError1, TError2, T1, T2>(
        this Result<TError1, T1> result,
        Func<T1, T2> f,
        Func<TError1, TError2> g)
      where TError1 : struct, IMonoid<TError1>
      where TError2 : struct, IMonoid<TError2>
      {
        return result.Match(
          f.ComposeRight(Result<TError2, T2>.Ok),
          g.ComposeRight(Result<TError2, T2>.Error)
        );
      }

    public static Result<TError, T2> Map<TError, T1, T2>(this Result<TError, T1> result, Func<T1, T2> f)
       where TError : struct, IMonoid<TError>
    {
      return result.Bimap(f, e => e);
    }

    public static Result<TError, T2> Select<TError, T1, T2>(this Result<TError, T1> result, Func<T1, T2> f)
       where TError : struct, IMonoid<TError>
    {
      return result.Bimap(f, e => e);
    }

    public static Result<TError2, T> MapError<TError1, TError2, T>(this Result<TError1, T> result, Func<TError1, TError2> f)
       where TError1 : struct, IMonoid<TError1>
       where TError2 : struct, IMonoid<TError2>
    {
      return result.Bimap(v => v, f);
    }

    public static Result<TError, T2> Bind<TError, T1, T2>(this Result<TError, T1> result, Func<T1, Result<TError, T2>> f)
       where TError : struct, IMonoid<TError>
    {
      return result.Bind(f);
    }

    public static Result<TError, T2> SelectMany<TError, T1, TIntermediate, T2>(this Result<TError, T1> result, Func<T1, Result<TError, TIntermediate>> f, Func<T1, TIntermediate, T2> project)
       where TError : struct, IMonoid<TError>
    {
      return result.Bind(x => f(x).Map(y => project(x, y)));
    }

    public static Func<TIn, Result<TError, T2>> KleisliRight<TIn, TError, T1, T2>(this Func<TIn, Result<TError, T1>> f, Func<T1, Result<TError, T2>> g)
       where TError : struct, IMonoid<TError>
    {
      return x => f(x).Bind(g);
    }

    public static Result<TError, (T1, T2)> Plus<TError, T1, T2>(this Result<TError, T1> result1, Result<TError, T2> result2)
       where TError : struct, IMonoid<TError>
    {
      return result1.Match(
        v1 => result2.Match(
          v2 => Result<TError, (T1, T2)>.Ok((v1, v2)),
          Result<TError, (T1, T2)>.Error),
        e1 => result2.Match(
          _ => Result<TError, (T1, T2)>.Error(e1),
          e2 => Result<TError,(T1, T2)>.Error(e1.Append(e2)))
      );
    }
    
  }

}