using System;

namespace DataBlocks.Prelude
{

  public struct Maybe<T>
  {

    public static Maybe<T> None => new Maybe<T>(Either<object, T>.Case1(new object()));

    public static Maybe<T> Some(T value)
    {
      return new Maybe<T>(Either<object, T>.Case2(value));
    }

    private Maybe(Either<object, T> data)
    {
      this._data = data;
    }

    public bool IsOk => this._data.IsCase2;

    public bool IsError => this._data.IsCase1;

    public TOut Match<TOut>(Func<T, TOut> some, Func<TOut> none) => _data.Match(_ => none(), some);

    private readonly Either<object, T> _data;

  }

}