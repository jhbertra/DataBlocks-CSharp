using System;

namespace DataBlocks
{

  public static partial class CodecExtensions
  {

    public static Codec<TRaw, TError, TRich> Construct<TRaw, TError, TRich, T1, T2, T3>(
      this Codec<TRaw, TError, TRich, ((T1 t1, T2 t2), T3 t3)> codec,
      Func<T1, T2, T3, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
      where TError : struct, IMonoid<TError>
    {
      return codec.Construct((t, v) => f(t.t1, t.t2, v));
    }

    public static Codec<TRaw, TError, TRich> Construct<TRaw, TError, TRich, T1, T2, T3, T4>(
      this Codec<TRaw, TError, TRich, (((T1 t1, T2 t2), T3 t3), T4 t4)> codec,
      Func<T1, T2, T3, T4, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
      where TError : struct, IMonoid<TError>
    {
      return codec.Construct((t, v1, v2) => f(t.t1, t.t2, v1, v2));
    }

    public static Codec<TRaw, TError, TRich> Construct<TRaw, TError, TRich, T1, T2, T3, T4, T5>(
      this Codec<TRaw, TError, TRich, ((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5)> codec,
      Func<T1, T2, T3, T4, T5, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
      where TError : struct, IMonoid<TError>
    {
      return codec.Construct((t, v1, v2, v3) => f(t.t1, t.t2, v1, v2, v3));
    }

    public static Codec<TRaw, TError, TRich> Construct<TRaw, TError, TRich, T1, T2, T3, T4, T5, T6>(
      this Codec<TRaw, TError, TRich, (((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6)> codec,
      Func<T1, T2, T3, T4, T5, T6, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
      where TError : struct, IMonoid<TError>
    {
      return codec.Construct((t, v1, v2, v3, v4) => f(t.t1, t.t2, v1, v2, v3, v4));
    }

    public static Codec<TRaw, TError, TRich> Construct<TRaw, TError, TRich, T1, T2, T3, T4, T5, T6, T7>(
      this Codec<TRaw, TError, TRich, ((((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6), T7 t7)> codec,
      Func<T1, T2, T3, T4, T5, T6, T7, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
      where TError : struct, IMonoid<TError>
    {
      return codec.Construct((t, v1, v2, v3, v4, v5) => f(t.t1, t.t2, v1, v2, v3, v4, v5));
    }

    public static Codec<TRaw, TError, TRich> Construct<TRaw, TError, TRich, T1, T2, T3, T4, T5, T6, T7, T8>(
      this Codec<TRaw, TError, TRich, (((((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6), T7 t7), T8 t8)> codec,
      Func<T1, T2, T3, T4, T5, T6, T7, T8, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
      where TError : struct, IMonoid<TError>
    {
      return codec.Construct((t, v1, v2, v3, v4, v5, v6) => f(t.t1, t.t2, v1, v2, v3, v4, v5, v6));
    }

    public static Codec<TRaw, TError, TRich> Construct<TRaw, TError, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9>(
      this Codec<TRaw, TError, TRich, ((((((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6), T7 t7), T8 t8), T9 t9)> codec,
      Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
      where TError : struct, IMonoid<TError>
    {
      return codec.Construct((t, v1, v2, v3, v4, v5, v6, v7) => f(t.t1, t.t2, v1, v2, v3, v4, v5, v6, v7));
    }

    public static Codec<TRaw, TError, TRich> Construct<TRaw, TError, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
      this Codec<TRaw, TError, TRich, (((((((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6), T7 t7), T8 t8), T9 t9), T10 t10)> codec,
      Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
      where TError : struct, IMonoid<TError>
    {
      return codec.Construct((t, v1, v2, v3, v4, v5, v6, v7, v8) => f(t.t1, t.t2, v1, v2, v3, v4, v5, v6, v7, v8));
    }

    public static Codec<TRaw, TError, TRich> Construct<TRaw, TError, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
      this Codec<TRaw, TError, TRich, ((((((((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6), T7 t7), T8 t8), T9 t9), T10 t10), T11 t11)> codec,
      Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
      where TError : struct, IMonoid<TError>
    {
      return codec.Construct((t, v1, v2, v3, v4, v5, v6, v7, v8, v9) => f(t.t1, t.t2, v1, v2, v3, v4, v5, v6, v7, v8, v9));
    }

    public static Codec<TRaw, TError, TRich> Construct<TRaw, TError, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
      this Codec<TRaw, TError, TRich, (((((((((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6), T7 t7), T8 t8), T9 t9), T10 t10), T11 t11), T12 t12)> codec,
      Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
      where TError : struct, IMonoid<TError>
    {
      return codec.Construct((t, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10) => f(t.t1, t.t2, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10));
    }

    public static Codec<TRaw, TError, TRich> Construct<TRaw, TError, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
      this Codec<TRaw, TError, TRich, ((((((((((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6), T7 t7), T8 t8), T9 t9), T10 t10), T11 t11), T12 t12), T13 t13)> codec,
      Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
      where TError : struct, IMonoid<TError>
    {
      return codec.Construct((t, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11) => f(t.t1, t.t2, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11));
    }

    public static Codec<TRaw, TError, TRich> Construct<TRaw, TError, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
      this Codec<TRaw, TError, TRich, (((((((((((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6), T7 t7), T8 t8), T9 t9), T10 t10), T11 t11), T12 t12), T13 t13), T14 t14)> codec,
      Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
      where TError : struct, IMonoid<TError>
    {
      return codec.Construct((t, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12) => f(t.t1, t.t2, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12));
    }

    public static Codec<TRaw, TError, TRich> Construct<TRaw, TError, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
      this Codec<TRaw, TError, TRich, ((((((((((((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6), T7 t7), T8 t8), T9 t9), T10 t10), T11 t11), T12 t12), T13 t13), T14 t14), T15 t15)> codec,
      Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
      where TError : struct, IMonoid<TError>
    {
      return codec.Construct((t, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13) => f(t.t1, t.t2, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13));
    }

    public static Codec<TRaw, TError, TRich> Construct<TRaw, TError, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
      this Codec<TRaw, TError, TRich, (((((((((((((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6), T7 t7), T8 t8), T9 t9), T10 t10), T11 t11), T12 t12), T13 t13), T14 t14), T15 t15), T16 t16)> codec,
      Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
      where TError : struct, IMonoid<TError>
    {
      return codec.Construct((t, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14) => f(t.t1, t.t2, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14));
    }

  }

}