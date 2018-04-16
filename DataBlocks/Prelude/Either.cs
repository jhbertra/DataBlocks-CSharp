using System;

namespace DataBlocks.Prelude
{

  public struct Either<T1, T2>
  {

    public static Either<T1, T2> Case1(T1 value)
    {
      return new Either<T1, T2>(true, value, default(T2));
    }

    public static Either<T1, T2> Case2(T2 value)
    {
      return new Either<T1, T2>(false, default(T1), value);
    }

    private Either(bool isCase1, T1 value1, T2 value2)
    {
      this._isCase1 = isCase1;
      this._value1 = value1;
      this._value2 = value2;
      this._isInitialized = true;
    }

    public bool IsCase1 => this._isInitialized ? this._isCase1 : throw new InvalidOperationException("This result struct has not been initialized.");

    public bool IsCase2 => !this.IsCase1;

    public T Match<T>(Func<T1, T> case1, Func<T2, T> case2)
    {
      return this._isInitialized 
        ? this._isCase1
          ? case1(this._value1)
          : case2(this._value2)
        : throw new InvalidOperationException("This either struct has not been initialized.");
    }

    public override bool Equals(object obj)
    {
      return obj is Either<T1, T2> other && this == other;
    }

    public static bool operator ==(Either<T1, T2> a, Either<T1, T2> b)
    {
      return a.Match(
        v1 => b.Match(
          v2 => v1.Equals(v2),
          _ => false),
        v1 => b.Match(
          _ => false,
          v2 => v1.Equals(v2))
      );
    }

    public static bool operator !=(Either<T1, T2> a, Either<T1, T2> b)
    {
      return !(a == b);
    }

    public override string ToString()
    {
      return this.Match(
        t1 => $"Case1 ({t1})",
        t2 => $"Case2 ({t2})"
      );
    }

    private readonly bool _isInitialized;
    private readonly bool _isCase1;
    private readonly T1 _value1;
    private readonly T2 _value2;

  }

}