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

    public bool IsNone => this._data.IsCase1;
    
    public bool IsSome => this._data.IsCase2;

    public TOut Match<TOut>(Func<T, TOut> some, Func<TOut> none) => _data.Match(_ => none(), some);

    public override bool Equals(object obj)
    {
      return obj is Maybe<T> other && this == other;
    }

    public static bool operator ==(Maybe<T> a, Maybe<T> b)
    {
      return a.Match(
        v1 => b.Match(
          v2 => v1.Equals(v2),
          () => false),
        () => b.Match(
          _ => false,
          () => true)
      );
    }

    public static bool operator !=(Maybe<T> a, Maybe<T> b)
    {
      return !(a == b);
    }

    public override string ToString()
    {
      return this.Match(
        t1 => $"Some ({t1})",
        () => $"None"
      );
    }

    public override int GetHashCode()
    {
      return this._data.GetHashCode();
    }

    private readonly Either<object, T> _data;

  }

}