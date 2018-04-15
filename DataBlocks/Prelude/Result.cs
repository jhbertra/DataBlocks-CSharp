using System;

namespace DataBlocks.Prelude
{

  public struct Result<TError, TResult> where TError : struct, IMonoid<TError>
  {

    public static Result<TError, TResult> Zero => Error(default(TError).Zero);

    public static Result<TError, TResult> Error(TError error)
    {
      return new Result<TError, TResult>(Either<TError, TResult>.Case1(error));
    }

    public static Result<TError, TResult> Ok(TResult value)
    {
      return new Result<TError, TResult>(Either<TError, TResult>.Case2(value));
    }

    private Result(Either<TError, TResult> data)
    {
      this._data = data;
    }

    public bool IsOk => this._data.IsCase2;

    public bool IsError => this._data.IsCase1;

    public T Match<T>(Func<TResult, T> ok, Func<TError, T> error) => _data.Match(error, ok);
    
    private Either<TError, TResult> _data;

    public override string ToString()
    {
      return this._data.Match(
        error => $"Error ({error.ToString()})",
        value => $"Ok ({value.ToString()})"
      );
    }

  }

  public static class Result
  {

    public static Result<TError, T> Choose<TError, T>(params Result<TError, T>[] results)
       where TError : struct, IMonoid<TError>
    {
      var last = Result<TError, T>.Zero;
      foreach(var result in results)
      {
        if (result.IsOk)
        {
          return result;
        }
        last = result;
      }
      return last;
    }

  }

}