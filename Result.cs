using System;

namespace AfeCodec
{

  public struct Result<TError, TResult> where TError : struct, IMonoid<TError>
  {

    public static Result<TError, TResult> Zero => Error(default(TError).Zero);

    public static Result<TError, TResult> Error(TError error)
    {
      return new Result<TError, TResult>(false, default(TResult), error);
    }

    public static Result<TError, TResult> Ok(TResult value)
    {
      return new Result<TError, TResult>(true, value, default(TError));
    }

    private Result(bool isSuccess, TResult value, TError error)
    {
      this._isSuccess = isSuccess;
      this._value = value;
      this._error = error;
      this._isInitialized = true;
    }

    public bool IsOk => this._isInitialized ? this._isSuccess : throw new InvalidOperationException("This result struct has not been initialized.");

    public bool IsError => !this.IsOk;

    public T Match<T>(Func<TResult, T> ok, Func<TError, T> error)
    {
      return this._isInitialized 
        ? this._isSuccess
          ? ok(this._value)
          : error(this._error)
        : throw new InvalidOperationException("This result struct has not been initialized.");
    }

    private readonly bool _isInitialized;
    private readonly bool _isSuccess;
    private readonly TResult _value;
    private readonly TError _error;

  }

}