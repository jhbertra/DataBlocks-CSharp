using System;

using DataBlocks.Prelude;

namespace DataBlocks.Core
{

  public static partial class CodecExtensions
  {

    public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3>(
      this Codec<TRaw, TRich, ((T1 t1, T2 t2), T3 t3)> codec,
      Func<T1, T2, T3, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
    {
      return codec.Construct((t, v) => f(t.t1, t.t2, v));
    }

    public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4>(
      this Codec<TRaw, TRich, (((T1 t1, T2 t2), T3 t3), T4 t4)> codec,
      Func<T1, T2, T3, T4, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
    {
      return codec.Construct((t, v1, v2) => f(t.t1, t.t2, v1, v2));
    }

    public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5>(
      this Codec<TRaw, TRich, ((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5)> codec,
      Func<T1, T2, T3, T4, T5, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
    {
      return codec.Construct((t, v1, v2, v3) => f(t.t1, t.t2, v1, v2, v3));
    }

    public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6>(
      this Codec<TRaw, TRich, (((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6)> codec,
      Func<T1, T2, T3, T4, T5, T6, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
    {
      return codec.Construct((t, v1, v2, v3, v4) => f(t.t1, t.t2, v1, v2, v3, v4));
    }

    public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7>(
      this Codec<TRaw, TRich, ((((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6), T7 t7)> codec,
      Func<T1, T2, T3, T4, T5, T6, T7, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
    {
      return codec.Construct((t, v1, v2, v3, v4, v5) => f(t.t1, t.t2, v1, v2, v3, v4, v5));
    }

    public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8>(
      this Codec<TRaw, TRich, (((((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6), T7 t7), T8 t8)> codec,
      Func<T1, T2, T3, T4, T5, T6, T7, T8, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
    {
      return codec.Construct((t, v1, v2, v3, v4, v5, v6) => f(t.t1, t.t2, v1, v2, v3, v4, v5, v6));
    }

    public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9>(
      this Codec<TRaw, TRich, ((((((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6), T7 t7), T8 t8), T9 t9)> codec,
      Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
    {
      return codec.Construct((t, v1, v2, v3, v4, v5, v6, v7) => f(t.t1, t.t2, v1, v2, v3, v4, v5, v6, v7));
    }

    public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
      this Codec<TRaw, TRich, (((((((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6), T7 t7), T8 t8), T9 t9), T10 t10)> codec,
      Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
    {
      return codec.Construct((t, v1, v2, v3, v4, v5, v6, v7, v8) => f(t.t1, t.t2, v1, v2, v3, v4, v5, v6, v7, v8));
    }

    public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
      this Codec<TRaw, TRich, ((((((((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6), T7 t7), T8 t8), T9 t9), T10 t10), T11 t11)> codec,
      Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
    {
      return codec.Construct((t, v1, v2, v3, v4, v5, v6, v7, v8, v9) => f(t.t1, t.t2, v1, v2, v3, v4, v5, v6, v7, v8, v9));
    }

    public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
      this Codec<TRaw, TRich, (((((((((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6), T7 t7), T8 t8), T9 t9), T10 t10), T11 t11), T12 t12)> codec,
      Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
    {
      return codec.Construct((t, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10) => f(t.t1, t.t2, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10));
    }

    public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
      this Codec<TRaw, TRich, ((((((((((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6), T7 t7), T8 t8), T9 t9), T10 t10), T11 t11), T12 t12), T13 t13)> codec,
      Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
    {
      return codec.Construct((t, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11) => f(t.t1, t.t2, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11));
    }

    public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
      this Codec<TRaw, TRich, (((((((((((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6), T7 t7), T8 t8), T9 t9), T10 t10), T11 t11), T12 t12), T13 t13), T14 t14)> codec,
      Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
    {
      return codec.Construct((t, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12) => f(t.t1, t.t2, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12));
    }

    public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
      this Codec<TRaw, TRich, ((((((((((((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6), T7 t7), T8 t8), T9 t9), T10 t10), T11 t11), T12 t12), T13 t13), T14 t14), T15 t15)> codec,
      Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
    {
      return codec.Construct((t, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13) => f(t.t1, t.t2, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13));
    }

    public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
      this Codec<TRaw, TRich, (((((((((((((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6), T7 t7), T8 t8), T9 t9), T10 t10), T11 t11), T12 t12), T13 t13), T14 t14), T15 t15), T16 t16)> codec,
      Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
    {
      return codec.Construct((t, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14) => f(t.t1, t.t2, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14));
    }

    public delegate T19 Delegate18<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18);
    public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(
      this Codec<TRaw, TRich, (((((((((((((((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6), T7 t7), T8 t8), T9 t9), T10 t10), T11 t11), T12 t12), T13 t13), T14 t14), T15 t15), T16 t16), T17 t17), T18 t18)> codec,
      Delegate18<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Codec<TRaw, TRich>(
        codec.Decoder.Map(t => f(
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t1,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t2,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t3,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t4,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t5,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t6,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t7,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t8,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t9,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t10,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t11,
          t.Item1.Item1.Item1.Item1.Item1.Item1.t12,
          t.Item1.Item1.Item1.Item1.Item1.t13,
          t.Item1.Item1.Item1.Item1.t14,
          t.Item1.Item1.Item1.t15,
          t.Item1.Item1.t16,
          t.Item1.t17,
          t.t18)),
        codec.Encoder
      );
    }

    public delegate T20 Delegate19<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19);
    public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(
      this Codec<TRaw, TRich, ((((((((((((((((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6), T7 t7), T8 t8), T9 t9), T10 t10), T11 t11), T12 t12), T13 t13), T14 t14), T15 t15), T16 t16), T17 t17), T18 t18), T19 t19)> codec,
      Delegate19<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Codec<TRaw, TRich>(
        codec.Decoder.Map(t => f(
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t1,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t2,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t3,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t4,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t5,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t6,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t7,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t8,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t9,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t10,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t11,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t12,
          t.Item1.Item1.Item1.Item1.Item1.Item1.t13,
          t.Item1.Item1.Item1.Item1.Item1.t14,
          t.Item1.Item1.Item1.Item1.t15,
          t.Item1.Item1.Item1.t16,
          t.Item1.Item1.t17,
          t.Item1.t18,
          t.t19)),
        codec.Encoder
      );
    }

    public delegate T21 Delegate20<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20);
    public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(
      this Codec<TRaw, TRich, (((((((((((((((((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6), T7 t7), T8 t8), T9 t9), T10 t10), T11 t11), T12 t12), T13 t13), T14 t14), T15 t15), T16 t16), T17 t17), T18 t18), T19 t19), T20 t20)> codec,
      Delegate20<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Codec<TRaw, TRich>(
        codec.Decoder.Map(t => f(
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t1,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t2,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t3,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t4,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t5,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t6,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t7,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t8,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t9,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t10,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t11,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t12,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t13,
          t.Item1.Item1.Item1.Item1.Item1.Item1.t14,
          t.Item1.Item1.Item1.Item1.Item1.t15,
          t.Item1.Item1.Item1.Item1.t16,
          t.Item1.Item1.Item1.t17,
          t.Item1.Item1.t18,
          t.Item1.t19,
          t.t20)),
        codec.Encoder
      );
    }

    public delegate T22 Delegate21<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21);
    public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(
      this Codec<TRaw, TRich, ((((((((((((((((((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6), T7 t7), T8 t8), T9 t9), T10 t10), T11 t11), T12 t12), T13 t13), T14 t14), T15 t15), T16 t16), T17 t17), T18 t18), T19 t19), T20 t20), T21 t21)> codec,
      Delegate21<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Codec<TRaw, TRich>(
        codec.Decoder.Map(t => f(
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t1,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t2,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t3,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t4,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t5,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t6,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t7,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t8,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t9,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t10,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t11,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t12,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t13,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t14,
          t.Item1.Item1.Item1.Item1.Item1.Item1.t15,
          t.Item1.Item1.Item1.Item1.Item1.t16,
          t.Item1.Item1.Item1.Item1.t17,
          t.Item1.Item1.Item1.t18,
          t.Item1.Item1.t19,
          t.Item1.t20,
          t.t21)),
        codec.Encoder
      );
    }

    public delegate T23 Delegate22<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22);
    public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(
      this Codec<TRaw, TRich, (((((((((((((((((((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6), T7 t7), T8 t8), T9 t9), T10 t10), T11 t11), T12 t12), T13 t13), T14 t14), T15 t15), T16 t16), T17 t17), T18 t18), T19 t19), T20 t20), T21 t21), T22 t22)> codec,
      Delegate22<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Codec<TRaw, TRich>(
        codec.Decoder.Map(t => f(
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t1,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t2,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t3,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t4,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t5,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t6,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t7,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t8,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t9,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t10,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t11,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t12,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t13,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t14,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t15,
          t.Item1.Item1.Item1.Item1.Item1.Item1.t16,
          t.Item1.Item1.Item1.Item1.Item1.t17,
          t.Item1.Item1.Item1.Item1.t18,
          t.Item1.Item1.Item1.t19,
          t.Item1.Item1.t20,
          t.Item1.t21,
          t.t22)),
        codec.Encoder
      );
    }

    public delegate T24 Delegate23<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23);
    public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(
      this Codec<TRaw, TRich, ((((((((((((((((((((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6), T7 t7), T8 t8), T9 t9), T10 t10), T11 t11), T12 t12), T13 t13), T14 t14), T15 t15), T16 t16), T17 t17), T18 t18), T19 t19), T20 t20), T21 t21), T22 t22), T23 t23)> codec,
      Delegate23<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Codec<TRaw, TRich>(
        codec.Decoder.Map(t => f(
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t1,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t2,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t3,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t4,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t5,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t6,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t7,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t8,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t9,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t10,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t11,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t12,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t13,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t14,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t15,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t16,
          t.Item1.Item1.Item1.Item1.Item1.Item1.t17,
          t.Item1.Item1.Item1.Item1.Item1.t18,
          t.Item1.Item1.Item1.Item1.t19,
          t.Item1.Item1.Item1.t20,
          t.Item1.Item1.t21,
          t.Item1.t22,
          t.t23)),
        codec.Encoder
      );
    }

    public delegate T25 Delegate24<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24);
    public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(
      this Codec<TRaw, TRich, (((((((((((((((((((((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6), T7 t7), T8 t8), T9 t9), T10 t10), T11 t11), T12 t12), T13 t13), T14 t14), T15 t15), T16 t16), T17 t17), T18 t18), T19 t19), T20 t20), T21 t21), T22 t22), T23 t23), T24 t24)> codec,
      Delegate24<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Codec<TRaw, TRich>(
        codec.Decoder.Map(t => f(
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t1,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t2,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t3,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t4,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t5,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t6,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t7,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t8,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t9,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t10,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t11,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t12,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t13,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t14,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t15,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t16,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t17,
          t.Item1.Item1.Item1.Item1.Item1.Item1.t18,
          t.Item1.Item1.Item1.Item1.Item1.t19,
          t.Item1.Item1.Item1.Item1.t20,
          t.Item1.Item1.Item1.t21,
          t.Item1.Item1.t22,
          t.Item1.t23,
          t.t24)),
        codec.Encoder
      );
    }

    public delegate T26 Delegate25<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25);
    public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(
      this Codec<TRaw, TRich, ((((((((((((((((((((((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6), T7 t7), T8 t8), T9 t9), T10 t10), T11 t11), T12 t12), T13 t13), T14 t14), T15 t15), T16 t16), T17 t17), T18 t18), T19 t19), T20 t20), T21 t21), T22 t22), T23 t23), T24 t24), T25 t25)> codec,
      Delegate25<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Codec<TRaw, TRich>(
        codec.Decoder.Map(t => f(
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t1,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t2,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t3,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t4,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t5,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t6,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t7,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t8,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t9,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t10,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t11,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t12,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t13,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t14,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t15,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t16,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t17,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t18,
          t.Item1.Item1.Item1.Item1.Item1.Item1.t19,
          t.Item1.Item1.Item1.Item1.Item1.t20,
          t.Item1.Item1.Item1.Item1.t21,
          t.Item1.Item1.Item1.t22,
          t.Item1.Item1.t23,
          t.Item1.t24,
          t.t25)),
        codec.Encoder
      );
    }

    public delegate T27 Delegate26<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26);
    public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(
      this Codec<TRaw, TRich, (((((((((((((((((((((((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6), T7 t7), T8 t8), T9 t9), T10 t10), T11 t11), T12 t12), T13 t13), T14 t14), T15 t15), T16 t16), T17 t17), T18 t18), T19 t19), T20 t20), T21 t21), T22 t22), T23 t23), T24 t24), T25 t25), T26 t26)> codec,
      Delegate26<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Codec<TRaw, TRich>(
        codec.Decoder.Map(t => f(
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t1,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t2,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t3,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t4,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t5,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t6,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t7,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t8,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t9,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t10,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t11,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t12,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t13,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t14,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t15,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t16,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t17,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t18,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t19,
          t.Item1.Item1.Item1.Item1.Item1.Item1.t20,
          t.Item1.Item1.Item1.Item1.Item1.t21,
          t.Item1.Item1.Item1.Item1.t22,
          t.Item1.Item1.Item1.t23,
          t.Item1.Item1.t24,
          t.Item1.t25,
          t.t26)),
        codec.Encoder
      );
    }

    public delegate T28 Delegate27<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27);
    public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(
      this Codec<TRaw, TRich, ((((((((((((((((((((((((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6), T7 t7), T8 t8), T9 t9), T10 t10), T11 t11), T12 t12), T13 t13), T14 t14), T15 t15), T16 t16), T17 t17), T18 t18), T19 t19), T20 t20), T21 t21), T22 t22), T23 t23), T24 t24), T25 t25), T26 t26), T27 t27)> codec,
      Delegate27<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Codec<TRaw, TRich>(
        codec.Decoder.Map(t => f(
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t1,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t2,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t3,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t4,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t5,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t6,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t7,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t8,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t9,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t10,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t11,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t12,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t13,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t14,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t15,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t16,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t17,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t18,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t19,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t20,
          t.Item1.Item1.Item1.Item1.Item1.Item1.t21,
          t.Item1.Item1.Item1.Item1.Item1.t22,
          t.Item1.Item1.Item1.Item1.t23,
          t.Item1.Item1.Item1.t24,
          t.Item1.Item1.t25,
          t.Item1.t26,
          t.t27)),
        codec.Encoder
      );
    }

    public delegate T29 Delegate28<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28);
    public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(
      this Codec<TRaw, TRich, (((((((((((((((((((((((((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6), T7 t7), T8 t8), T9 t9), T10 t10), T11 t11), T12 t12), T13 t13), T14 t14), T15 t15), T16 t16), T17 t17), T18 t18), T19 t19), T20 t20), T21 t21), T22 t22), T23 t23), T24 t24), T25 t25), T26 t26), T27 t27), T28 t28)> codec,
      Delegate28<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Codec<TRaw, TRich>(
        codec.Decoder.Map(t => f(
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t1,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t2,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t3,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t4,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t5,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t6,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t7,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t8,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t9,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t10,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t11,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t12,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t13,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t14,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t15,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t16,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t17,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t18,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t19,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t20,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t21,
          t.Item1.Item1.Item1.Item1.Item1.Item1.t22,
          t.Item1.Item1.Item1.Item1.Item1.t23,
          t.Item1.Item1.Item1.Item1.t24,
          t.Item1.Item1.Item1.t25,
          t.Item1.Item1.t26,
          t.Item1.t27,
          t.t28)),
        codec.Encoder
      );
    }

    public delegate T30 Delegate29<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29);
    public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(
      this Codec<TRaw, TRich, ((((((((((((((((((((((((((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6), T7 t7), T8 t8), T9 t9), T10 t10), T11 t11), T12 t12), T13 t13), T14 t14), T15 t15), T16 t16), T17 t17), T18 t18), T19 t19), T20 t20), T21 t21), T22 t22), T23 t23), T24 t24), T25 t25), T26 t26), T27 t27), T28 t28), T29 t29)> codec,
      Delegate29<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Codec<TRaw, TRich>(
        codec.Decoder.Map(t => f(
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t1,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t2,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t3,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t4,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t5,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t6,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t7,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t8,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t9,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t10,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t11,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t12,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t13,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t14,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t15,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t16,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t17,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t18,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t19,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t20,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t21,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t22,
          t.Item1.Item1.Item1.Item1.Item1.Item1.t23,
          t.Item1.Item1.Item1.Item1.Item1.t24,
          t.Item1.Item1.Item1.Item1.t25,
          t.Item1.Item1.Item1.t26,
          t.Item1.Item1.t27,
          t.Item1.t28,
          t.t29)),
        codec.Encoder
      );
    }

    public delegate T31 Delegate30<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30);
    public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(
      this Codec<TRaw, TRich, (((((((((((((((((((((((((((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6), T7 t7), T8 t8), T9 t9), T10 t10), T11 t11), T12 t12), T13 t13), T14 t14), T15 t15), T16 t16), T17 t17), T18 t18), T19 t19), T20 t20), T21 t21), T22 t22), T23 t23), T24 t24), T25 t25), T26 t26), T27 t27), T28 t28), T29 t29), T30 t30)> codec,
      Delegate30<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Codec<TRaw, TRich>(
        codec.Decoder.Map(t => f(
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t1,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t2,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t3,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t4,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t5,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t6,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t7,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t8,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t9,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t10,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t11,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t12,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t13,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t14,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t15,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t16,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t17,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t18,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t19,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t20,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t21,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t22,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t23,
          t.Item1.Item1.Item1.Item1.Item1.Item1.t24,
          t.Item1.Item1.Item1.Item1.Item1.t25,
          t.Item1.Item1.Item1.Item1.t26,
          t.Item1.Item1.Item1.t27,
          t.Item1.Item1.t28,
          t.Item1.t29,
          t.t30)),
        codec.Encoder
      );
    }

    public delegate T32 Delegate31<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31);
    public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(
      this Codec<TRaw, TRich, ((((((((((((((((((((((((((((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6), T7 t7), T8 t8), T9 t9), T10 t10), T11 t11), T12 t12), T13 t13), T14 t14), T15 t15), T16 t16), T17 t17), T18 t18), T19 t19), T20 t20), T21 t21), T22 t22), T23 t23), T24 t24), T25 t25), T26 t26), T27 t27), T28 t28), T29 t29), T30 t30), T31 t31)> codec,
      Delegate31<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Codec<TRaw, TRich>(
        codec.Decoder.Map(t => f(
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t1,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t2,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t3,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t4,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t5,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t6,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t7,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t8,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t9,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t10,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t11,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t12,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t13,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t14,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t15,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t16,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t17,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t18,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t19,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t20,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t21,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t22,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t23,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t24,
          t.Item1.Item1.Item1.Item1.Item1.Item1.t25,
          t.Item1.Item1.Item1.Item1.Item1.t26,
          t.Item1.Item1.Item1.Item1.t27,
          t.Item1.Item1.Item1.t28,
          t.Item1.Item1.t29,
          t.Item1.t30,
          t.t31)),
        codec.Encoder
      );
    }

    public delegate T33 Delegate32<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32);
    public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(
      this Codec<TRaw, TRich, (((((((((((((((((((((((((((((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6), T7 t7), T8 t8), T9 t9), T10 t10), T11 t11), T12 t12), T13 t13), T14 t14), T15 t15), T16 t16), T17 t17), T18 t18), T19 t19), T20 t20), T21 t21), T22 t22), T23 t23), T24 t24), T25 t25), T26 t26), T27 t27), T28 t28), T29 t29), T30 t30), T31 t31), T32 t32)> codec,
      Delegate32<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Codec<TRaw, TRich>(
        codec.Decoder.Map(t => f(
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t1,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t2,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t3,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t4,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t5,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t6,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t7,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t8,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t9,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t10,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t11,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t12,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t13,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t14,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t15,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t16,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t17,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t18,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t19,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t20,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t21,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t22,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t23,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t24,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t25,
          t.Item1.Item1.Item1.Item1.Item1.Item1.t26,
          t.Item1.Item1.Item1.Item1.Item1.t27,
          t.Item1.Item1.Item1.Item1.t28,
          t.Item1.Item1.Item1.t29,
          t.Item1.Item1.t30,
          t.Item1.t31,
          t.t32)),
        codec.Encoder
      );
    }

    public delegate T34 Delegate33<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32, T33 t33);
    public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(
      this Codec<TRaw, TRich, ((((((((((((((((((((((((((((((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6), T7 t7), T8 t8), T9 t9), T10 t10), T11 t11), T12 t12), T13 t13), T14 t14), T15 t15), T16 t16), T17 t17), T18 t18), T19 t19), T20 t20), T21 t21), T22 t22), T23 t23), T24 t24), T25 t25), T26 t26), T27 t27), T28 t28), T29 t29), T30 t30), T31 t31), T32 t32), T33 t33)> codec,
      Delegate33<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Codec<TRaw, TRich>(
        codec.Decoder.Map(t => f(
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t1,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t2,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t3,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t4,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t5,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t6,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t7,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t8,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t9,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t10,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t11,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t12,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t13,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t14,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t15,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t16,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t17,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t18,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t19,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t20,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t21,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t22,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t23,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t24,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t25,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t26,
          t.Item1.Item1.Item1.Item1.Item1.Item1.t27,
          t.Item1.Item1.Item1.Item1.Item1.t28,
          t.Item1.Item1.Item1.Item1.t29,
          t.Item1.Item1.Item1.t30,
          t.Item1.Item1.t31,
          t.Item1.t32,
          t.t33)),
        codec.Encoder
      );
    }

    public delegate T35 Delegate34<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32, T33 t33, T34 t34);
    public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(
      this Codec<TRaw, TRich, (((((((((((((((((((((((((((((((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6), T7 t7), T8 t8), T9 t9), T10 t10), T11 t11), T12 t12), T13 t13), T14 t14), T15 t15), T16 t16), T17 t17), T18 t18), T19 t19), T20 t20), T21 t21), T22 t22), T23 t23), T24 t24), T25 t25), T26 t26), T27 t27), T28 t28), T29 t29), T30 t30), T31 t31), T32 t32), T33 t33), T34 t34)> codec,
      Delegate34<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Codec<TRaw, TRich>(
        codec.Decoder.Map(t => f(
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t1,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t2,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t3,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t4,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t5,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t6,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t7,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t8,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t9,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t10,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t11,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t12,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t13,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t14,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t15,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t16,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t17,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t18,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t19,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t20,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t21,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t22,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t23,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t24,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t25,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t26,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t27,
          t.Item1.Item1.Item1.Item1.Item1.Item1.t28,
          t.Item1.Item1.Item1.Item1.Item1.t29,
          t.Item1.Item1.Item1.Item1.t30,
          t.Item1.Item1.Item1.t31,
          t.Item1.Item1.t32,
          t.Item1.t33,
          t.t34)),
        codec.Encoder
      );
    }

    public delegate T36 Delegate35<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32, T33 t33, T34 t34, T35 t35);
    public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(
      this Codec<TRaw, TRich, ((((((((((((((((((((((((((((((((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6), T7 t7), T8 t8), T9 t9), T10 t10), T11 t11), T12 t12), T13 t13), T14 t14), T15 t15), T16 t16), T17 t17), T18 t18), T19 t19), T20 t20), T21 t21), T22 t22), T23 t23), T24 t24), T25 t25), T26 t26), T27 t27), T28 t28), T29 t29), T30 t30), T31 t31), T32 t32), T33 t33), T34 t34), T35 t35)> codec,
      Delegate35<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Codec<TRaw, TRich>(
        codec.Decoder.Map(t => f(
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t1,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t2,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t3,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t4,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t5,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t6,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t7,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t8,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t9,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t10,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t11,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t12,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t13,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t14,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t15,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t16,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t17,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t18,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t19,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t20,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t21,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t22,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t23,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t24,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t25,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t26,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t27,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t28,
          t.Item1.Item1.Item1.Item1.Item1.Item1.t29,
          t.Item1.Item1.Item1.Item1.Item1.t30,
          t.Item1.Item1.Item1.Item1.t31,
          t.Item1.Item1.Item1.t32,
          t.Item1.Item1.t33,
          t.Item1.t34,
          t.t35)),
        codec.Encoder
      );
    }

    public delegate T37 Delegate36<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32, T33 t33, T34 t34, T35 t35, T36 t36);
    public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(
      this Codec<TRaw, TRich, (((((((((((((((((((((((((((((((((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6), T7 t7), T8 t8), T9 t9), T10 t10), T11 t11), T12 t12), T13 t13), T14 t14), T15 t15), T16 t16), T17 t17), T18 t18), T19 t19), T20 t20), T21 t21), T22 t22), T23 t23), T24 t24), T25 t25), T26 t26), T27 t27), T28 t28), T29 t29), T30 t30), T31 t31), T32 t32), T33 t33), T34 t34), T35 t35), T36 t36)> codec,
      Delegate36<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Codec<TRaw, TRich>(
        codec.Decoder.Map(t => f(
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t1,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t2,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t3,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t4,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t5,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t6,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t7,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t8,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t9,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t10,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t11,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t12,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t13,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t14,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t15,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t16,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t17,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t18,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t19,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t20,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t21,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t22,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t23,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t24,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t25,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t26,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t27,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t28,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t29,
          t.Item1.Item1.Item1.Item1.Item1.Item1.t30,
          t.Item1.Item1.Item1.Item1.Item1.t31,
          t.Item1.Item1.Item1.Item1.t32,
          t.Item1.Item1.Item1.t33,
          t.Item1.Item1.t34,
          t.Item1.t35,
          t.t36)),
        codec.Encoder
      );
    }

    public delegate T38 Delegate37<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32, T33 t33, T34 t34, T35 t35, T36 t36, T37 t37);
    public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(
      this Codec<TRaw, TRich, ((((((((((((((((((((((((((((((((((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6), T7 t7), T8 t8), T9 t9), T10 t10), T11 t11), T12 t12), T13 t13), T14 t14), T15 t15), T16 t16), T17 t17), T18 t18), T19 t19), T20 t20), T21 t21), T22 t22), T23 t23), T24 t24), T25 t25), T26 t26), T27 t27), T28 t28), T29 t29), T30 t30), T31 t31), T32 t32), T33 t33), T34 t34), T35 t35), T36 t36), T37 t37)> codec,
      Delegate37<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Codec<TRaw, TRich>(
        codec.Decoder.Map(t => f(
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t1,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t2,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t3,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t4,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t5,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t6,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t7,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t8,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t9,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t10,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t11,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t12,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t13,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t14,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t15,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t16,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t17,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t18,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t19,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t20,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t21,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t22,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t23,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t24,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t25,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t26,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t27,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t28,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t29,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t30,
          t.Item1.Item1.Item1.Item1.Item1.Item1.t31,
          t.Item1.Item1.Item1.Item1.Item1.t32,
          t.Item1.Item1.Item1.Item1.t33,
          t.Item1.Item1.Item1.t34,
          t.Item1.Item1.t35,
          t.Item1.t36,
          t.t37)),
        codec.Encoder
      );
    }

    public delegate T39 Delegate38<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32, T33 t33, T34 t34, T35 t35, T36 t36, T37 t37, T38 t38);
    public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(
      this Codec<TRaw, TRich, (((((((((((((((((((((((((((((((((((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6), T7 t7), T8 t8), T9 t9), T10 t10), T11 t11), T12 t12), T13 t13), T14 t14), T15 t15), T16 t16), T17 t17), T18 t18), T19 t19), T20 t20), T21 t21), T22 t22), T23 t23), T24 t24), T25 t25), T26 t26), T27 t27), T28 t28), T29 t29), T30 t30), T31 t31), T32 t32), T33 t33), T34 t34), T35 t35), T36 t36), T37 t37), T38 t38)> codec,
      Delegate38<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Codec<TRaw, TRich>(
        codec.Decoder.Map(t => f(
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t1,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t2,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t3,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t4,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t5,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t6,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t7,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t8,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t9,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t10,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t11,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t12,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t13,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t14,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t15,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t16,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t17,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t18,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t19,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t20,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t21,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t22,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t23,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t24,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t25,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t26,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t27,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t28,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t29,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t30,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t31,
          t.Item1.Item1.Item1.Item1.Item1.Item1.t32,
          t.Item1.Item1.Item1.Item1.Item1.t33,
          t.Item1.Item1.Item1.Item1.t34,
          t.Item1.Item1.Item1.t35,
          t.Item1.Item1.t36,
          t.Item1.t37,
          t.t38)),
        codec.Encoder
      );
    }

    public delegate T40 Delegate39<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32, T33 t33, T34 t34, T35 t35, T36 t36, T37 t37, T38 t38, T39 t39);
    public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(
      this Codec<TRaw, TRich, ((((((((((((((((((((((((((((((((((((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6), T7 t7), T8 t8), T9 t9), T10 t10), T11 t11), T12 t12), T13 t13), T14 t14), T15 t15), T16 t16), T17 t17), T18 t18), T19 t19), T20 t20), T21 t21), T22 t22), T23 t23), T24 t24), T25 t25), T26 t26), T27 t27), T28 t28), T29 t29), T30 t30), T31 t31), T32 t32), T33 t33), T34 t34), T35 t35), T36 t36), T37 t37), T38 t38), T39 t39)> codec,
      Delegate39<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Codec<TRaw, TRich>(
        codec.Decoder.Map(t => f(
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t1,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t2,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t3,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t4,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t5,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t6,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t7,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t8,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t9,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t10,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t11,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t12,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t13,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t14,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t15,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t16,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t17,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t18,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t19,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t20,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t21,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t22,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t23,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t24,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t25,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t26,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t27,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t28,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t29,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t30,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t31,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t32,
          t.Item1.Item1.Item1.Item1.Item1.Item1.t33,
          t.Item1.Item1.Item1.Item1.Item1.t34,
          t.Item1.Item1.Item1.Item1.t35,
          t.Item1.Item1.Item1.t36,
          t.Item1.Item1.t37,
          t.Item1.t38,
          t.t39)),
        codec.Encoder
      );
    }

    public delegate T41 Delegate40<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32, T33 t33, T34 t34, T35 t35, T36 t36, T37 t37, T38 t38, T39 t39, T40 t40);
    public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(
      this Codec<TRaw, TRich, (((((((((((((((((((((((((((((((((((((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6), T7 t7), T8 t8), T9 t9), T10 t10), T11 t11), T12 t12), T13 t13), T14 t14), T15 t15), T16 t16), T17 t17), T18 t18), T19 t19), T20 t20), T21 t21), T22 t22), T23 t23), T24 t24), T25 t25), T26 t26), T27 t27), T28 t28), T29 t29), T30 t30), T31 t31), T32 t32), T33 t33), T34 t34), T35 t35), T36 t36), T37 t37), T38 t38), T39 t39), T40 t40)> codec,
      Delegate40<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Codec<TRaw, TRich>(
        codec.Decoder.Map(t => f(
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t1,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t2,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t3,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t4,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t5,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t6,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t7,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t8,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t9,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t10,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t11,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t12,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t13,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t14,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t15,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t16,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t17,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t18,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t19,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t20,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t21,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t22,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t23,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t24,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t25,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t26,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t27,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t28,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t29,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t30,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t31,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t32,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t33,
          t.Item1.Item1.Item1.Item1.Item1.Item1.t34,
          t.Item1.Item1.Item1.Item1.Item1.t35,
          t.Item1.Item1.Item1.Item1.t36,
          t.Item1.Item1.Item1.t37,
          t.Item1.Item1.t38,
          t.Item1.t39,
          t.t40)),
        codec.Encoder
      );
    }

    public delegate T42 Delegate41<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32, T33 t33, T34 t34, T35 t35, T36 t36, T37 t37, T38 t38, T39 t39, T40 t40, T41 t41);
    public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(
      this Codec<TRaw, TRich, ((((((((((((((((((((((((((((((((((((((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6), T7 t7), T8 t8), T9 t9), T10 t10), T11 t11), T12 t12), T13 t13), T14 t14), T15 t15), T16 t16), T17 t17), T18 t18), T19 t19), T20 t20), T21 t21), T22 t22), T23 t23), T24 t24), T25 t25), T26 t26), T27 t27), T28 t28), T29 t29), T30 t30), T31 t31), T32 t32), T33 t33), T34 t34), T35 t35), T36 t36), T37 t37), T38 t38), T39 t39), T40 t40), T41 t41)> codec,
      Delegate41<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Codec<TRaw, TRich>(
        codec.Decoder.Map(t => f(
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t1,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t2,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t3,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t4,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t5,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t6,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t7,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t8,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t9,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t10,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t11,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t12,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t13,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t14,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t15,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t16,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t17,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t18,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t19,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t20,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t21,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t22,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t23,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t24,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t25,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t26,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t27,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t28,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t29,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t30,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t31,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t32,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t33,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t34,
          t.Item1.Item1.Item1.Item1.Item1.Item1.t35,
          t.Item1.Item1.Item1.Item1.Item1.t36,
          t.Item1.Item1.Item1.Item1.t37,
          t.Item1.Item1.Item1.t38,
          t.Item1.Item1.t39,
          t.Item1.t40,
          t.t41)),
        codec.Encoder
      );
    }

    public delegate T43 Delegate42<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32, T33 t33, T34 t34, T35 t35, T36 t36, T37 t37, T38 t38, T39 t39, T40 t40, T41 t41, T42 t42);
    public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(
      this Codec<TRaw, TRich, (((((((((((((((((((((((((((((((((((((((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6), T7 t7), T8 t8), T9 t9), T10 t10), T11 t11), T12 t12), T13 t13), T14 t14), T15 t15), T16 t16), T17 t17), T18 t18), T19 t19), T20 t20), T21 t21), T22 t22), T23 t23), T24 t24), T25 t25), T26 t26), T27 t27), T28 t28), T29 t29), T30 t30), T31 t31), T32 t32), T33 t33), T34 t34), T35 t35), T36 t36), T37 t37), T38 t38), T39 t39), T40 t40), T41 t41), T42 t42)> codec,
      Delegate42<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Codec<TRaw, TRich>(
        codec.Decoder.Map(t => f(
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t1,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t2,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t3,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t4,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t5,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t6,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t7,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t8,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t9,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t10,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t11,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t12,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t13,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t14,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t15,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t16,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t17,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t18,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t19,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t20,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t21,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t22,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t23,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t24,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t25,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t26,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t27,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t28,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t29,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t30,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t31,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t32,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t33,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t34,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t35,
          t.Item1.Item1.Item1.Item1.Item1.Item1.t36,
          t.Item1.Item1.Item1.Item1.Item1.t37,
          t.Item1.Item1.Item1.Item1.t38,
          t.Item1.Item1.Item1.t39,
          t.Item1.Item1.t40,
          t.Item1.t41,
          t.t42)),
        codec.Encoder
      );
    }

    public delegate T44 Delegate43<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32, T33 t33, T34 t34, T35 t35, T36 t36, T37 t37, T38 t38, T39 t39, T40 t40, T41 t41, T42 t42, T43 t43);
    public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(
      this Codec<TRaw, TRich, ((((((((((((((((((((((((((((((((((((((((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6), T7 t7), T8 t8), T9 t9), T10 t10), T11 t11), T12 t12), T13 t13), T14 t14), T15 t15), T16 t16), T17 t17), T18 t18), T19 t19), T20 t20), T21 t21), T22 t22), T23 t23), T24 t24), T25 t25), T26 t26), T27 t27), T28 t28), T29 t29), T30 t30), T31 t31), T32 t32), T33 t33), T34 t34), T35 t35), T36 t36), T37 t37), T38 t38), T39 t39), T40 t40), T41 t41), T42 t42), T43 t43)> codec,
      Delegate43<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Codec<TRaw, TRich>(
        codec.Decoder.Map(t => f(
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t1,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t2,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t3,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t4,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t5,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t6,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t7,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t8,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t9,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t10,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t11,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t12,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t13,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t14,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t15,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t16,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t17,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t18,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t19,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t20,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t21,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t22,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t23,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t24,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t25,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t26,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t27,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t28,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t29,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t30,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t31,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t32,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t33,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t34,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t35,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t36,
          t.Item1.Item1.Item1.Item1.Item1.Item1.t37,
          t.Item1.Item1.Item1.Item1.Item1.t38,
          t.Item1.Item1.Item1.Item1.t39,
          t.Item1.Item1.Item1.t40,
          t.Item1.Item1.t41,
          t.Item1.t42,
          t.t43)),
        codec.Encoder
      );
    }

    public delegate T45 Delegate44<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32, T33 t33, T34 t34, T35 t35, T36 t36, T37 t37, T38 t38, T39 t39, T40 t40, T41 t41, T42 t42, T43 t43, T44 t44);
    public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>(
      this Codec<TRaw, TRich, (((((((((((((((((((((((((((((((((((((((((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6), T7 t7), T8 t8), T9 t9), T10 t10), T11 t11), T12 t12), T13 t13), T14 t14), T15 t15), T16 t16), T17 t17), T18 t18), T19 t19), T20 t20), T21 t21), T22 t22), T23 t23), T24 t24), T25 t25), T26 t26), T27 t27), T28 t28), T29 t29), T30 t30), T31 t31), T32 t32), T33 t33), T34 t34), T35 t35), T36 t36), T37 t37), T38 t38), T39 t39), T40 t40), T41 t41), T42 t42), T43 t43), T44 t44)> codec,
      Delegate44<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Codec<TRaw, TRich>(
        codec.Decoder.Map(t => f(
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t1,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t2,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t3,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t4,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t5,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t6,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t7,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t8,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t9,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t10,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t11,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t12,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t13,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t14,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t15,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t16,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t17,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t18,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t19,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t20,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t21,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t22,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t23,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t24,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t25,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t26,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t27,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t28,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t29,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t30,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t31,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t32,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t33,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t34,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t35,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t36,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t37,
          t.Item1.Item1.Item1.Item1.Item1.Item1.t38,
          t.Item1.Item1.Item1.Item1.Item1.t39,
          t.Item1.Item1.Item1.Item1.t40,
          t.Item1.Item1.Item1.t41,
          t.Item1.Item1.t42,
          t.Item1.t43,
          t.t44)),
        codec.Encoder
      );
    }

    public delegate T46 Delegate45<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32, T33 t33, T34 t34, T35 t35, T36 t36, T37 t37, T38 t38, T39 t39, T40 t40, T41 t41, T42 t42, T43 t43, T44 t44, T45 t45);
    public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45>(
      this Codec<TRaw, TRich, ((((((((((((((((((((((((((((((((((((((((((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6), T7 t7), T8 t8), T9 t9), T10 t10), T11 t11), T12 t12), T13 t13), T14 t14), T15 t15), T16 t16), T17 t17), T18 t18), T19 t19), T20 t20), T21 t21), T22 t22), T23 t23), T24 t24), T25 t25), T26 t26), T27 t27), T28 t28), T29 t29), T30 t30), T31 t31), T32 t32), T33 t33), T34 t34), T35 t35), T36 t36), T37 t37), T38 t38), T39 t39), T40 t40), T41 t41), T42 t42), T43 t43), T44 t44), T45 t45)> codec,
      Delegate45<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Codec<TRaw, TRich>(
        codec.Decoder.Map(t => f(
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t1,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t2,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t3,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t4,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t5,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t6,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t7,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t8,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t9,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t10,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t11,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t12,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t13,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t14,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t15,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t16,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t17,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t18,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t19,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t20,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t21,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t22,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t23,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t24,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t25,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t26,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t27,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t28,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t29,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t30,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t31,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t32,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t33,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t34,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t35,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t36,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t37,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t38,
          t.Item1.Item1.Item1.Item1.Item1.Item1.t39,
          t.Item1.Item1.Item1.Item1.Item1.t40,
          t.Item1.Item1.Item1.Item1.t41,
          t.Item1.Item1.Item1.t42,
          t.Item1.Item1.t43,
          t.Item1.t44,
          t.t45)),
        codec.Encoder
      );
    }

    public delegate T47 Delegate46<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32, T33 t33, T34 t34, T35 t35, T36 t36, T37 t37, T38 t38, T39 t39, T40 t40, T41 t41, T42 t42, T43 t43, T44 t44, T45 t45, T46 t46);
    public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46>(
      this Codec<TRaw, TRich, (((((((((((((((((((((((((((((((((((((((((((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6), T7 t7), T8 t8), T9 t9), T10 t10), T11 t11), T12 t12), T13 t13), T14 t14), T15 t15), T16 t16), T17 t17), T18 t18), T19 t19), T20 t20), T21 t21), T22 t22), T23 t23), T24 t24), T25 t25), T26 t26), T27 t27), T28 t28), T29 t29), T30 t30), T31 t31), T32 t32), T33 t33), T34 t34), T35 t35), T36 t36), T37 t37), T38 t38), T39 t39), T40 t40), T41 t41), T42 t42), T43 t43), T44 t44), T45 t45), T46 t46)> codec,
      Delegate46<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Codec<TRaw, TRich>(
        codec.Decoder.Map(t => f(
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t1,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t2,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t3,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t4,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t5,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t6,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t7,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t8,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t9,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t10,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t11,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t12,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t13,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t14,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t15,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t16,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t17,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t18,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t19,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t20,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t21,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t22,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t23,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t24,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t25,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t26,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t27,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t28,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t29,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t30,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t31,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t32,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t33,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t34,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t35,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t36,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t37,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t38,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t39,
          t.Item1.Item1.Item1.Item1.Item1.Item1.t40,
          t.Item1.Item1.Item1.Item1.Item1.t41,
          t.Item1.Item1.Item1.Item1.t42,
          t.Item1.Item1.Item1.t43,
          t.Item1.Item1.t44,
          t.Item1.t45,
          t.t46)),
        codec.Encoder
      );
    }

    public delegate T48 Delegate47<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32, T33 t33, T34 t34, T35 t35, T36 t36, T37 t37, T38 t38, T39 t39, T40 t40, T41 t41, T42 t42, T43 t43, T44 t44, T45 t45, T46 t46, T47 t47);
    public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47>(
      this Codec<TRaw, TRich, ((((((((((((((((((((((((((((((((((((((((((((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6), T7 t7), T8 t8), T9 t9), T10 t10), T11 t11), T12 t12), T13 t13), T14 t14), T15 t15), T16 t16), T17 t17), T18 t18), T19 t19), T20 t20), T21 t21), T22 t22), T23 t23), T24 t24), T25 t25), T26 t26), T27 t27), T28 t28), T29 t29), T30 t30), T31 t31), T32 t32), T33 t33), T34 t34), T35 t35), T36 t36), T37 t37), T38 t38), T39 t39), T40 t40), T41 t41), T42 t42), T43 t43), T44 t44), T45 t45), T46 t46), T47 t47)> codec,
      Delegate47<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Codec<TRaw, TRich>(
        codec.Decoder.Map(t => f(
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t1,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t2,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t3,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t4,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t5,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t6,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t7,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t8,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t9,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t10,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t11,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t12,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t13,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t14,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t15,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t16,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t17,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t18,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t19,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t20,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t21,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t22,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t23,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t24,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t25,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t26,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t27,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t28,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t29,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t30,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t31,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t32,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t33,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t34,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t35,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t36,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t37,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t38,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t39,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t40,
          t.Item1.Item1.Item1.Item1.Item1.Item1.t41,
          t.Item1.Item1.Item1.Item1.Item1.t42,
          t.Item1.Item1.Item1.Item1.t43,
          t.Item1.Item1.Item1.t44,
          t.Item1.Item1.t45,
          t.Item1.t46,
          t.t47)),
        codec.Encoder
      );
    }

    public delegate T49 Delegate48<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32, T33 t33, T34 t34, T35 t35, T36 t36, T37 t37, T38 t38, T39 t39, T40 t40, T41 t41, T42 t42, T43 t43, T44 t44, T45 t45, T46 t46, T47 t47, T48 t48);
    public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48>(
      this Codec<TRaw, TRich, (((((((((((((((((((((((((((((((((((((((((((((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6), T7 t7), T8 t8), T9 t9), T10 t10), T11 t11), T12 t12), T13 t13), T14 t14), T15 t15), T16 t16), T17 t17), T18 t18), T19 t19), T20 t20), T21 t21), T22 t22), T23 t23), T24 t24), T25 t25), T26 t26), T27 t27), T28 t28), T29 t29), T30 t30), T31 t31), T32 t32), T33 t33), T34 t34), T35 t35), T36 t36), T37 t37), T38 t38), T39 t39), T40 t40), T41 t41), T42 t42), T43 t43), T44 t44), T45 t45), T46 t46), T47 t47), T48 t48)> codec,
      Delegate48<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Codec<TRaw, TRich>(
        codec.Decoder.Map(t => f(
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t1,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t2,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t3,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t4,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t5,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t6,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t7,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t8,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t9,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t10,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t11,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t12,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t13,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t14,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t15,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t16,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t17,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t18,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t19,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t20,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t21,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t22,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t23,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t24,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t25,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t26,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t27,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t28,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t29,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t30,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t31,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t32,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t33,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t34,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t35,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t36,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t37,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t38,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t39,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t40,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t41,
          t.Item1.Item1.Item1.Item1.Item1.Item1.t42,
          t.Item1.Item1.Item1.Item1.Item1.t43,
          t.Item1.Item1.Item1.Item1.t44,
          t.Item1.Item1.Item1.t45,
          t.Item1.Item1.t46,
          t.Item1.t47,
          t.t48)),
        codec.Encoder
      );
    }

    public delegate T50 Delegate49<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32, T33 t33, T34 t34, T35 t35, T36 t36, T37 t37, T38 t38, T39 t39, T40 t40, T41 t41, T42 t42, T43 t43, T44 t44, T45 t45, T46 t46, T47 t47, T48 t48, T49 t49);
    public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49>(
      this Codec<TRaw, TRich, ((((((((((((((((((((((((((((((((((((((((((((((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6), T7 t7), T8 t8), T9 t9), T10 t10), T11 t11), T12 t12), T13 t13), T14 t14), T15 t15), T16 t16), T17 t17), T18 t18), T19 t19), T20 t20), T21 t21), T22 t22), T23 t23), T24 t24), T25 t25), T26 t26), T27 t27), T28 t28), T29 t29), T30 t30), T31 t31), T32 t32), T33 t33), T34 t34), T35 t35), T36 t36), T37 t37), T38 t38), T39 t39), T40 t40), T41 t41), T42 t42), T43 t43), T44 t44), T45 t45), T46 t46), T47 t47), T48 t48), T49 t49)> codec,
      Delegate49<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Codec<TRaw, TRich>(
        codec.Decoder.Map(t => f(
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t1,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t2,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t3,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t4,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t5,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t6,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t7,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t8,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t9,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t10,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t11,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t12,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t13,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t14,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t15,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t16,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t17,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t18,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t19,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t20,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t21,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t22,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t23,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t24,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t25,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t26,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t27,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t28,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t29,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t30,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t31,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t32,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t33,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t34,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t35,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t36,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t37,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t38,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t39,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t40,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t41,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t42,
          t.Item1.Item1.Item1.Item1.Item1.Item1.t43,
          t.Item1.Item1.Item1.Item1.Item1.t44,
          t.Item1.Item1.Item1.Item1.t45,
          t.Item1.Item1.Item1.t46,
          t.Item1.Item1.t47,
          t.Item1.t48,
          t.t49)),
        codec.Encoder
      );
    }

    public delegate T51 Delegate50<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32, T33 t33, T34 t34, T35 t35, T36 t36, T37 t37, T38 t38, T39 t39, T40 t40, T41 t41, T42 t42, T43 t43, T44 t44, T45 t45, T46 t46, T47 t47, T48 t48, T49 t49, T50 t50);
    public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50>(
      this Codec<TRaw, TRich, (((((((((((((((((((((((((((((((((((((((((((((((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6), T7 t7), T8 t8), T9 t9), T10 t10), T11 t11), T12 t12), T13 t13), T14 t14), T15 t15), T16 t16), T17 t17), T18 t18), T19 t19), T20 t20), T21 t21), T22 t22), T23 t23), T24 t24), T25 t25), T26 t26), T27 t27), T28 t28), T29 t29), T30 t30), T31 t31), T32 t32), T33 t33), T34 t34), T35 t35), T36 t36), T37 t37), T38 t38), T39 t39), T40 t40), T41 t41), T42 t42), T43 t43), T44 t44), T45 t45), T46 t46), T47 t47), T48 t48), T49 t49), T50 t50)> codec,
      Delegate50<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Codec<TRaw, TRich>(
        codec.Decoder.Map(t => f(
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t1,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t2,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t3,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t4,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t5,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t6,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t7,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t8,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t9,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t10,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t11,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t12,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t13,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t14,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t15,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t16,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t17,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t18,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t19,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t20,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t21,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t22,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t23,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t24,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t25,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t26,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t27,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t28,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t29,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t30,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t31,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t32,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t33,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t34,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t35,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t36,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t37,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t38,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t39,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t40,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t41,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t42,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t43,
          t.Item1.Item1.Item1.Item1.Item1.Item1.t44,
          t.Item1.Item1.Item1.Item1.Item1.t45,
          t.Item1.Item1.Item1.Item1.t46,
          t.Item1.Item1.Item1.t47,
          t.Item1.Item1.t48,
          t.Item1.t49,
          t.t50)),
        codec.Encoder
      );
    }

    public delegate T52 Delegate51<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32, T33 t33, T34 t34, T35 t35, T36 t36, T37 t37, T38 t38, T39 t39, T40 t40, T41 t41, T42 t42, T43 t43, T44 t44, T45 t45, T46 t46, T47 t47, T48 t48, T49 t49, T50 t50, T51 t51);
    public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51>(
      this Codec<TRaw, TRich, ((((((((((((((((((((((((((((((((((((((((((((((((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6), T7 t7), T8 t8), T9 t9), T10 t10), T11 t11), T12 t12), T13 t13), T14 t14), T15 t15), T16 t16), T17 t17), T18 t18), T19 t19), T20 t20), T21 t21), T22 t22), T23 t23), T24 t24), T25 t25), T26 t26), T27 t27), T28 t28), T29 t29), T30 t30), T31 t31), T32 t32), T33 t33), T34 t34), T35 t35), T36 t36), T37 t37), T38 t38), T39 t39), T40 t40), T41 t41), T42 t42), T43 t43), T44 t44), T45 t45), T46 t46), T47 t47), T48 t48), T49 t49), T50 t50), T51 t51)> codec,
      Delegate51<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Codec<TRaw, TRich>(
        codec.Decoder.Map(t => f(
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t1,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t2,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t3,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t4,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t5,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t6,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t7,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t8,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t9,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t10,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t11,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t12,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t13,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t14,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t15,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t16,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t17,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t18,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t19,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t20,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t21,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t22,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t23,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t24,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t25,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t26,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t27,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t28,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t29,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t30,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t31,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t32,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t33,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t34,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t35,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t36,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t37,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t38,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t39,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t40,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t41,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t42,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t43,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t44,
          t.Item1.Item1.Item1.Item1.Item1.Item1.t45,
          t.Item1.Item1.Item1.Item1.Item1.t46,
          t.Item1.Item1.Item1.Item1.t47,
          t.Item1.Item1.Item1.t48,
          t.Item1.Item1.t49,
          t.Item1.t50,
          t.t51)),
        codec.Encoder
      );
    }

    public delegate T53 Delegate52<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32, T33 t33, T34 t34, T35 t35, T36 t36, T37 t37, T38 t38, T39 t39, T40 t40, T41 t41, T42 t42, T43 t43, T44 t44, T45 t45, T46 t46, T47 t47, T48 t48, T49 t49, T50 t50, T51 t51, T52 t52);
    public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52>(
      this Codec<TRaw, TRich, (((((((((((((((((((((((((((((((((((((((((((((((((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6), T7 t7), T8 t8), T9 t9), T10 t10), T11 t11), T12 t12), T13 t13), T14 t14), T15 t15), T16 t16), T17 t17), T18 t18), T19 t19), T20 t20), T21 t21), T22 t22), T23 t23), T24 t24), T25 t25), T26 t26), T27 t27), T28 t28), T29 t29), T30 t30), T31 t31), T32 t32), T33 t33), T34 t34), T35 t35), T36 t36), T37 t37), T38 t38), T39 t39), T40 t40), T41 t41), T42 t42), T43 t43), T44 t44), T45 t45), T46 t46), T47 t47), T48 t48), T49 t49), T50 t50), T51 t51), T52 t52)> codec,
      Delegate52<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Codec<TRaw, TRich>(
        codec.Decoder.Map(t => f(
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t1,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t2,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t3,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t4,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t5,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t6,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t7,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t8,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t9,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t10,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t11,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t12,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t13,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t14,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t15,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t16,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t17,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t18,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t19,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t20,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t21,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t22,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t23,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t24,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t25,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t26,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t27,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t28,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t29,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t30,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t31,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t32,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t33,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t34,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t35,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t36,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t37,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t38,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t39,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t40,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t41,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t42,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t43,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t44,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t45,
          t.Item1.Item1.Item1.Item1.Item1.Item1.t46,
          t.Item1.Item1.Item1.Item1.Item1.t47,
          t.Item1.Item1.Item1.Item1.t48,
          t.Item1.Item1.Item1.t49,
          t.Item1.Item1.t50,
          t.Item1.t51,
          t.t52)),
        codec.Encoder
      );
    }

    public delegate T54 Delegate53<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32, T33 t33, T34 t34, T35 t35, T36 t36, T37 t37, T38 t38, T39 t39, T40 t40, T41 t41, T42 t42, T43 t43, T44 t44, T45 t45, T46 t46, T47 t47, T48 t48, T49 t49, T50 t50, T51 t51, T52 t52, T53 t53);
    public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53>(
      this Codec<TRaw, TRich, ((((((((((((((((((((((((((((((((((((((((((((((((((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6), T7 t7), T8 t8), T9 t9), T10 t10), T11 t11), T12 t12), T13 t13), T14 t14), T15 t15), T16 t16), T17 t17), T18 t18), T19 t19), T20 t20), T21 t21), T22 t22), T23 t23), T24 t24), T25 t25), T26 t26), T27 t27), T28 t28), T29 t29), T30 t30), T31 t31), T32 t32), T33 t33), T34 t34), T35 t35), T36 t36), T37 t37), T38 t38), T39 t39), T40 t40), T41 t41), T42 t42), T43 t43), T44 t44), T45 t45), T46 t46), T47 t47), T48 t48), T49 t49), T50 t50), T51 t51), T52 t52), T53 t53)> codec,
      Delegate53<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Codec<TRaw, TRich>(
        codec.Decoder.Map(t => f(
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t1,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t2,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t3,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t4,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t5,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t6,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t7,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t8,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t9,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t10,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t11,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t12,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t13,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t14,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t15,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t16,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t17,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t18,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t19,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t20,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t21,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t22,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t23,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t24,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t25,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t26,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t27,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t28,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t29,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t30,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t31,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t32,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t33,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t34,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t35,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t36,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t37,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t38,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t39,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t40,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t41,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t42,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t43,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t44,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t45,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t46,
          t.Item1.Item1.Item1.Item1.Item1.Item1.t47,
          t.Item1.Item1.Item1.Item1.Item1.t48,
          t.Item1.Item1.Item1.Item1.t49,
          t.Item1.Item1.Item1.t50,
          t.Item1.Item1.t51,
          t.Item1.t52,
          t.t53)),
        codec.Encoder
      );
    }

    public delegate T55 Delegate54<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32, T33 t33, T34 t34, T35 t35, T36 t36, T37 t37, T38 t38, T39 t39, T40 t40, T41 t41, T42 t42, T43 t43, T44 t44, T45 t45, T46 t46, T47 t47, T48 t48, T49 t49, T50 t50, T51 t51, T52 t52, T53 t53, T54 t54);
    public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54>(
      this Codec<TRaw, TRich, (((((((((((((((((((((((((((((((((((((((((((((((((((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6), T7 t7), T8 t8), T9 t9), T10 t10), T11 t11), T12 t12), T13 t13), T14 t14), T15 t15), T16 t16), T17 t17), T18 t18), T19 t19), T20 t20), T21 t21), T22 t22), T23 t23), T24 t24), T25 t25), T26 t26), T27 t27), T28 t28), T29 t29), T30 t30), T31 t31), T32 t32), T33 t33), T34 t34), T35 t35), T36 t36), T37 t37), T38 t38), T39 t39), T40 t40), T41 t41), T42 t42), T43 t43), T44 t44), T45 t45), T46 t46), T47 t47), T48 t48), T49 t49), T50 t50), T51 t51), T52 t52), T53 t53), T54 t54)> codec,
      Delegate54<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Codec<TRaw, TRich>(
        codec.Decoder.Map(t => f(
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t1,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t2,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t3,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t4,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t5,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t6,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t7,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t8,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t9,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t10,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t11,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t12,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t13,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t14,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t15,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t16,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t17,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t18,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t19,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t20,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t21,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t22,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t23,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t24,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t25,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t26,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t27,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t28,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t29,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t30,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t31,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t32,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t33,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t34,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t35,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t36,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t37,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t38,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t39,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t40,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t41,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t42,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t43,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t44,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t45,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t46,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t47,
          t.Item1.Item1.Item1.Item1.Item1.Item1.t48,
          t.Item1.Item1.Item1.Item1.Item1.t49,
          t.Item1.Item1.Item1.Item1.t50,
          t.Item1.Item1.Item1.t51,
          t.Item1.Item1.t52,
          t.Item1.t53,
          t.t54)),
        codec.Encoder
      );
    }

    public delegate T56 Delegate55<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32, T33 t33, T34 t34, T35 t35, T36 t36, T37 t37, T38 t38, T39 t39, T40 t40, T41 t41, T42 t42, T43 t43, T44 t44, T45 t45, T46 t46, T47 t47, T48 t48, T49 t49, T50 t50, T51 t51, T52 t52, T53 t53, T54 t54, T55 t55);
    public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55>(
      this Codec<TRaw, TRich, ((((((((((((((((((((((((((((((((((((((((((((((((((((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6), T7 t7), T8 t8), T9 t9), T10 t10), T11 t11), T12 t12), T13 t13), T14 t14), T15 t15), T16 t16), T17 t17), T18 t18), T19 t19), T20 t20), T21 t21), T22 t22), T23 t23), T24 t24), T25 t25), T26 t26), T27 t27), T28 t28), T29 t29), T30 t30), T31 t31), T32 t32), T33 t33), T34 t34), T35 t35), T36 t36), T37 t37), T38 t38), T39 t39), T40 t40), T41 t41), T42 t42), T43 t43), T44 t44), T45 t45), T46 t46), T47 t47), T48 t48), T49 t49), T50 t50), T51 t51), T52 t52), T53 t53), T54 t54), T55 t55)> codec,
      Delegate55<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Codec<TRaw, TRich>(
        codec.Decoder.Map(t => f(
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t1,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t2,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t3,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t4,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t5,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t6,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t7,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t8,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t9,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t10,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t11,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t12,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t13,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t14,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t15,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t16,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t17,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t18,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t19,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t20,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t21,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t22,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t23,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t24,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t25,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t26,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t27,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t28,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t29,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t30,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t31,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t32,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t33,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t34,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t35,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t36,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t37,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t38,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t39,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t40,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t41,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t42,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t43,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t44,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t45,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t46,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t47,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t48,
          t.Item1.Item1.Item1.Item1.Item1.Item1.t49,
          t.Item1.Item1.Item1.Item1.Item1.t50,
          t.Item1.Item1.Item1.Item1.t51,
          t.Item1.Item1.Item1.t52,
          t.Item1.Item1.t53,
          t.Item1.t54,
          t.t55)),
        codec.Encoder
      );
    }

    public delegate T57 Delegate56<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32, T33 t33, T34 t34, T35 t35, T36 t36, T37 t37, T38 t38, T39 t39, T40 t40, T41 t41, T42 t42, T43 t43, T44 t44, T45 t45, T46 t46, T47 t47, T48 t48, T49 t49, T50 t50, T51 t51, T52 t52, T53 t53, T54 t54, T55 t55, T56 t56);
    public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56>(
      this Codec<TRaw, TRich, (((((((((((((((((((((((((((((((((((((((((((((((((((((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6), T7 t7), T8 t8), T9 t9), T10 t10), T11 t11), T12 t12), T13 t13), T14 t14), T15 t15), T16 t16), T17 t17), T18 t18), T19 t19), T20 t20), T21 t21), T22 t22), T23 t23), T24 t24), T25 t25), T26 t26), T27 t27), T28 t28), T29 t29), T30 t30), T31 t31), T32 t32), T33 t33), T34 t34), T35 t35), T36 t36), T37 t37), T38 t38), T39 t39), T40 t40), T41 t41), T42 t42), T43 t43), T44 t44), T45 t45), T46 t46), T47 t47), T48 t48), T49 t49), T50 t50), T51 t51), T52 t52), T53 t53), T54 t54), T55 t55), T56 t56)> codec,
      Delegate56<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Codec<TRaw, TRich>(
        codec.Decoder.Map(t => f(
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t1,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t2,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t3,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t4,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t5,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t6,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t7,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t8,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t9,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t10,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t11,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t12,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t13,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t14,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t15,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t16,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t17,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t18,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t19,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t20,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t21,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t22,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t23,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t24,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t25,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t26,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t27,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t28,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t29,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t30,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t31,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t32,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t33,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t34,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t35,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t36,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t37,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t38,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t39,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t40,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t41,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t42,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t43,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t44,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t45,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t46,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t47,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t48,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t49,
          t.Item1.Item1.Item1.Item1.Item1.Item1.t50,
          t.Item1.Item1.Item1.Item1.Item1.t51,
          t.Item1.Item1.Item1.Item1.t52,
          t.Item1.Item1.Item1.t53,
          t.Item1.Item1.t54,
          t.Item1.t55,
          t.t56)),
        codec.Encoder
      );
    }

    public delegate T58 Delegate57<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32, T33 t33, T34 t34, T35 t35, T36 t36, T37 t37, T38 t38, T39 t39, T40 t40, T41 t41, T42 t42, T43 t43, T44 t44, T45 t45, T46 t46, T47 t47, T48 t48, T49 t49, T50 t50, T51 t51, T52 t52, T53 t53, T54 t54, T55 t55, T56 t56, T57 t57);
    public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57>(
      this Codec<TRaw, TRich, ((((((((((((((((((((((((((((((((((((((((((((((((((((((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6), T7 t7), T8 t8), T9 t9), T10 t10), T11 t11), T12 t12), T13 t13), T14 t14), T15 t15), T16 t16), T17 t17), T18 t18), T19 t19), T20 t20), T21 t21), T22 t22), T23 t23), T24 t24), T25 t25), T26 t26), T27 t27), T28 t28), T29 t29), T30 t30), T31 t31), T32 t32), T33 t33), T34 t34), T35 t35), T36 t36), T37 t37), T38 t38), T39 t39), T40 t40), T41 t41), T42 t42), T43 t43), T44 t44), T45 t45), T46 t46), T47 t47), T48 t48), T49 t49), T50 t50), T51 t51), T52 t52), T53 t53), T54 t54), T55 t55), T56 t56), T57 t57)> codec,
      Delegate57<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Codec<TRaw, TRich>(
        codec.Decoder.Map(t => f(
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t1,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t2,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t3,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t4,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t5,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t6,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t7,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t8,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t9,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t10,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t11,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t12,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t13,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t14,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t15,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t16,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t17,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t18,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t19,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t20,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t21,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t22,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t23,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t24,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t25,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t26,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t27,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t28,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t29,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t30,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t31,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t32,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t33,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t34,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t35,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t36,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t37,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t38,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t39,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t40,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t41,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t42,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t43,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t44,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t45,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t46,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t47,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t48,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t49,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t50,
          t.Item1.Item1.Item1.Item1.Item1.Item1.t51,
          t.Item1.Item1.Item1.Item1.Item1.t52,
          t.Item1.Item1.Item1.Item1.t53,
          t.Item1.Item1.Item1.t54,
          t.Item1.Item1.t55,
          t.Item1.t56,
          t.t57)),
        codec.Encoder
      );
    }

    public delegate T59 Delegate58<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32, T33 t33, T34 t34, T35 t35, T36 t36, T37 t37, T38 t38, T39 t39, T40 t40, T41 t41, T42 t42, T43 t43, T44 t44, T45 t45, T46 t46, T47 t47, T48 t48, T49 t49, T50 t50, T51 t51, T52 t52, T53 t53, T54 t54, T55 t55, T56 t56, T57 t57, T58 t58);
    public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(
      this Codec<TRaw, TRich, (((((((((((((((((((((((((((((((((((((((((((((((((((((((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6), T7 t7), T8 t8), T9 t9), T10 t10), T11 t11), T12 t12), T13 t13), T14 t14), T15 t15), T16 t16), T17 t17), T18 t18), T19 t19), T20 t20), T21 t21), T22 t22), T23 t23), T24 t24), T25 t25), T26 t26), T27 t27), T28 t28), T29 t29), T30 t30), T31 t31), T32 t32), T33 t33), T34 t34), T35 t35), T36 t36), T37 t37), T38 t38), T39 t39), T40 t40), T41 t41), T42 t42), T43 t43), T44 t44), T45 t45), T46 t46), T47 t47), T48 t48), T49 t49), T50 t50), T51 t51), T52 t52), T53 t53), T54 t54), T55 t55), T56 t56), T57 t57), T58 t58)> codec,
      Delegate58<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Codec<TRaw, TRich>(
        codec.Decoder.Map(t => f(
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t1,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t2,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t3,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t4,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t5,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t6,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t7,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t8,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t9,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t10,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t11,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t12,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t13,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t14,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t15,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t16,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t17,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t18,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t19,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t20,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t21,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t22,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t23,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t24,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t25,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t26,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t27,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t28,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t29,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t30,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t31,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t32,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t33,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t34,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t35,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t36,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t37,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t38,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t39,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t40,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t41,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t42,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t43,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t44,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t45,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t46,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t47,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t48,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t49,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t50,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t51,
          t.Item1.Item1.Item1.Item1.Item1.Item1.t52,
          t.Item1.Item1.Item1.Item1.Item1.t53,
          t.Item1.Item1.Item1.Item1.t54,
          t.Item1.Item1.Item1.t55,
          t.Item1.Item1.t56,
          t.Item1.t57,
          t.t58)),
        codec.Encoder
      );
    }

    public delegate T60 Delegate59<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59, T60>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32, T33 t33, T34 t34, T35 t35, T36 t36, T37 t37, T38 t38, T39 t39, T40 t40, T41 t41, T42 t42, T43 t43, T44 t44, T45 t45, T46 t46, T47 t47, T48 t48, T49 t49, T50 t50, T51 t51, T52 t52, T53 t53, T54 t54, T55 t55, T56 t56, T57 t57, T58 t58, T59 t59);
    public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59>(
      this Codec<TRaw, TRich, ((((((((((((((((((((((((((((((((((((((((((((((((((((((((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6), T7 t7), T8 t8), T9 t9), T10 t10), T11 t11), T12 t12), T13 t13), T14 t14), T15 t15), T16 t16), T17 t17), T18 t18), T19 t19), T20 t20), T21 t21), T22 t22), T23 t23), T24 t24), T25 t25), T26 t26), T27 t27), T28 t28), T29 t29), T30 t30), T31 t31), T32 t32), T33 t33), T34 t34), T35 t35), T36 t36), T37 t37), T38 t38), T39 t39), T40 t40), T41 t41), T42 t42), T43 t43), T44 t44), T45 t45), T46 t46), T47 t47), T48 t48), T49 t49), T50 t50), T51 t51), T52 t52), T53 t53), T54 t54), T55 t55), T56 t56), T57 t57), T58 t58), T59 t59)> codec,
      Delegate59<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Codec<TRaw, TRich>(
        codec.Decoder.Map(t => f(
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t1,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t2,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t3,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t4,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t5,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t6,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t7,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t8,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t9,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t10,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t11,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t12,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t13,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t14,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t15,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t16,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t17,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t18,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t19,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t20,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t21,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t22,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t23,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t24,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t25,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t26,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t27,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t28,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t29,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t30,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t31,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t32,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t33,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t34,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t35,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t36,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t37,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t38,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t39,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t40,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t41,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t42,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t43,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t44,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t45,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t46,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t47,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t48,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t49,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t50,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t51,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t52,
          t.Item1.Item1.Item1.Item1.Item1.Item1.t53,
          t.Item1.Item1.Item1.Item1.Item1.t54,
          t.Item1.Item1.Item1.Item1.t55,
          t.Item1.Item1.Item1.t56,
          t.Item1.Item1.t57,
          t.Item1.t58,
          t.t59)),
        codec.Encoder
      );
    }

    public delegate T61 Delegate60<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59, T60, T61>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32, T33 t33, T34 t34, T35 t35, T36 t36, T37 t37, T38 t38, T39 t39, T40 t40, T41 t41, T42 t42, T43 t43, T44 t44, T45 t45, T46 t46, T47 t47, T48 t48, T49 t49, T50 t50, T51 t51, T52 t52, T53 t53, T54 t54, T55 t55, T56 t56, T57 t57, T58 t58, T59 t59, T60 t60);
    public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59, T60>(
      this Codec<TRaw, TRich, (((((((((((((((((((((((((((((((((((((((((((((((((((((((((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6), T7 t7), T8 t8), T9 t9), T10 t10), T11 t11), T12 t12), T13 t13), T14 t14), T15 t15), T16 t16), T17 t17), T18 t18), T19 t19), T20 t20), T21 t21), T22 t22), T23 t23), T24 t24), T25 t25), T26 t26), T27 t27), T28 t28), T29 t29), T30 t30), T31 t31), T32 t32), T33 t33), T34 t34), T35 t35), T36 t36), T37 t37), T38 t38), T39 t39), T40 t40), T41 t41), T42 t42), T43 t43), T44 t44), T45 t45), T46 t46), T47 t47), T48 t48), T49 t49), T50 t50), T51 t51), T52 t52), T53 t53), T54 t54), T55 t55), T56 t56), T57 t57), T58 t58), T59 t59), T60 t60)> codec,
      Delegate60<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59, T60, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Codec<TRaw, TRich>(
        codec.Decoder.Map(t => f(
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t1,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t2,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t3,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t4,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t5,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t6,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t7,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t8,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t9,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t10,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t11,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t12,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t13,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t14,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t15,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t16,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t17,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t18,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t19,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t20,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t21,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t22,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t23,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t24,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t25,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t26,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t27,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t28,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t29,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t30,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t31,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t32,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t33,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t34,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t35,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t36,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t37,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t38,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t39,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t40,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t41,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t42,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t43,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t44,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t45,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t46,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t47,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t48,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t49,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t50,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t51,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t52,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t53,
          t.Item1.Item1.Item1.Item1.Item1.Item1.t54,
          t.Item1.Item1.Item1.Item1.Item1.t55,
          t.Item1.Item1.Item1.Item1.t56,
          t.Item1.Item1.Item1.t57,
          t.Item1.Item1.t58,
          t.Item1.t59,
          t.t60)),
        codec.Encoder
      );
    }

    public delegate T62 Delegate61<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59, T60, T61, T62>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32, T33 t33, T34 t34, T35 t35, T36 t36, T37 t37, T38 t38, T39 t39, T40 t40, T41 t41, T42 t42, T43 t43, T44 t44, T45 t45, T46 t46, T47 t47, T48 t48, T49 t49, T50 t50, T51 t51, T52 t52, T53 t53, T54 t54, T55 t55, T56 t56, T57 t57, T58 t58, T59 t59, T60 t60, T61 t61);
    public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59, T60, T61>(
      this Codec<TRaw, TRich, ((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6), T7 t7), T8 t8), T9 t9), T10 t10), T11 t11), T12 t12), T13 t13), T14 t14), T15 t15), T16 t16), T17 t17), T18 t18), T19 t19), T20 t20), T21 t21), T22 t22), T23 t23), T24 t24), T25 t25), T26 t26), T27 t27), T28 t28), T29 t29), T30 t30), T31 t31), T32 t32), T33 t33), T34 t34), T35 t35), T36 t36), T37 t37), T38 t38), T39 t39), T40 t40), T41 t41), T42 t42), T43 t43), T44 t44), T45 t45), T46 t46), T47 t47), T48 t48), T49 t49), T50 t50), T51 t51), T52 t52), T53 t53), T54 t54), T55 t55), T56 t56), T57 t57), T58 t58), T59 t59), T60 t60), T61 t61)> codec,
      Delegate61<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59, T60, T61, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Codec<TRaw, TRich>(
        codec.Decoder.Map(t => f(
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t1,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t2,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t3,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t4,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t5,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t6,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t7,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t8,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t9,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t10,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t11,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t12,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t13,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t14,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t15,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t16,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t17,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t18,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t19,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t20,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t21,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t22,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t23,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t24,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t25,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t26,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t27,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t28,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t29,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t30,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t31,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t32,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t33,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t34,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t35,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t36,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t37,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t38,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t39,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t40,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t41,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t42,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t43,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t44,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t45,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t46,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t47,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t48,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t49,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t50,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t51,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t52,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t53,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t54,
          t.Item1.Item1.Item1.Item1.Item1.Item1.t55,
          t.Item1.Item1.Item1.Item1.Item1.t56,
          t.Item1.Item1.Item1.Item1.t57,
          t.Item1.Item1.Item1.t58,
          t.Item1.Item1.t59,
          t.Item1.t60,
          t.t61)),
        codec.Encoder
      );
    }

    public delegate T63 Delegate62<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59, T60, T61, T62, T63>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32, T33 t33, T34 t34, T35 t35, T36 t36, T37 t37, T38 t38, T39 t39, T40 t40, T41 t41, T42 t42, T43 t43, T44 t44, T45 t45, T46 t46, T47 t47, T48 t48, T49 t49, T50 t50, T51 t51, T52 t52, T53 t53, T54 t54, T55 t55, T56 t56, T57 t57, T58 t58, T59 t59, T60 t60, T61 t61, T62 t62);
    public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59, T60, T61, T62>(
      this Codec<TRaw, TRich, (((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6), T7 t7), T8 t8), T9 t9), T10 t10), T11 t11), T12 t12), T13 t13), T14 t14), T15 t15), T16 t16), T17 t17), T18 t18), T19 t19), T20 t20), T21 t21), T22 t22), T23 t23), T24 t24), T25 t25), T26 t26), T27 t27), T28 t28), T29 t29), T30 t30), T31 t31), T32 t32), T33 t33), T34 t34), T35 t35), T36 t36), T37 t37), T38 t38), T39 t39), T40 t40), T41 t41), T42 t42), T43 t43), T44 t44), T45 t45), T46 t46), T47 t47), T48 t48), T49 t49), T50 t50), T51 t51), T52 t52), T53 t53), T54 t54), T55 t55), T56 t56), T57 t57), T58 t58), T59 t59), T60 t60), T61 t61), T62 t62)> codec,
      Delegate62<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59, T60, T61, T62, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Codec<TRaw, TRich>(
        codec.Decoder.Map(t => f(
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t1,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t2,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t3,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t4,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t5,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t6,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t7,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t8,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t9,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t10,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t11,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t12,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t13,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t14,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t15,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t16,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t17,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t18,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t19,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t20,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t21,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t22,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t23,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t24,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t25,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t26,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t27,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t28,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t29,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t30,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t31,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t32,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t33,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t34,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t35,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t36,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t37,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t38,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t39,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t40,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t41,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t42,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t43,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t44,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t45,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t46,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t47,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t48,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t49,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t50,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t51,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t52,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t53,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t54,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t55,
          t.Item1.Item1.Item1.Item1.Item1.Item1.t56,
          t.Item1.Item1.Item1.Item1.Item1.t57,
          t.Item1.Item1.Item1.Item1.t58,
          t.Item1.Item1.Item1.t59,
          t.Item1.Item1.t60,
          t.Item1.t61,
          t.t62)),
        codec.Encoder
      );
    }

    public delegate T64 Delegate63<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59, T60, T61, T62, T63, T64>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32, T33 t33, T34 t34, T35 t35, T36 t36, T37 t37, T38 t38, T39 t39, T40 t40, T41 t41, T42 t42, T43 t43, T44 t44, T45 t45, T46 t46, T47 t47, T48 t48, T49 t49, T50 t50, T51 t51, T52 t52, T53 t53, T54 t54, T55 t55, T56 t56, T57 t57, T58 t58, T59 t59, T60 t60, T61 t61, T62 t62, T63 t63);
    public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59, T60, T61, T62, T63>(
      this Codec<TRaw, TRich, ((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6), T7 t7), T8 t8), T9 t9), T10 t10), T11 t11), T12 t12), T13 t13), T14 t14), T15 t15), T16 t16), T17 t17), T18 t18), T19 t19), T20 t20), T21 t21), T22 t22), T23 t23), T24 t24), T25 t25), T26 t26), T27 t27), T28 t28), T29 t29), T30 t30), T31 t31), T32 t32), T33 t33), T34 t34), T35 t35), T36 t36), T37 t37), T38 t38), T39 t39), T40 t40), T41 t41), T42 t42), T43 t43), T44 t44), T45 t45), T46 t46), T47 t47), T48 t48), T49 t49), T50 t50), T51 t51), T52 t52), T53 t53), T54 t54), T55 t55), T56 t56), T57 t57), T58 t58), T59 t59), T60 t60), T61 t61), T62 t62), T63 t63)> codec,
      Delegate63<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59, T60, T61, T62, T63, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Codec<TRaw, TRich>(
        codec.Decoder.Map(t => f(
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t1,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t2,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t3,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t4,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t5,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t6,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t7,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t8,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t9,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t10,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t11,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t12,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t13,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t14,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t15,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t16,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t17,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t18,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t19,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t20,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t21,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t22,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t23,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t24,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t25,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t26,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t27,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t28,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t29,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t30,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t31,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t32,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t33,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t34,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t35,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t36,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t37,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t38,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t39,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t40,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t41,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t42,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t43,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t44,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t45,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t46,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t47,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t48,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t49,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t50,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t51,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t52,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t53,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t54,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t55,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t56,
          t.Item1.Item1.Item1.Item1.Item1.Item1.t57,
          t.Item1.Item1.Item1.Item1.Item1.t58,
          t.Item1.Item1.Item1.Item1.t59,
          t.Item1.Item1.Item1.t60,
          t.Item1.Item1.t61,
          t.Item1.t62,
          t.t63)),
        codec.Encoder
      );
    }

    public delegate T65 Delegate64<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59, T60, T61, T62, T63, T64, T65>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32, T33 t33, T34 t34, T35 t35, T36 t36, T37 t37, T38 t38, T39 t39, T40 t40, T41 t41, T42 t42, T43 t43, T44 t44, T45 t45, T46 t46, T47 t47, T48 t48, T49 t49, T50 t50, T51 t51, T52 t52, T53 t53, T54 t54, T55 t55, T56 t56, T57 t57, T58 t58, T59 t59, T60 t60, T61 t61, T62 t62, T63 t63, T64 t64);
    public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59, T60, T61, T62, T63, T64>(
      this Codec<TRaw, TRich, (((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6), T7 t7), T8 t8), T9 t9), T10 t10), T11 t11), T12 t12), T13 t13), T14 t14), T15 t15), T16 t16), T17 t17), T18 t18), T19 t19), T20 t20), T21 t21), T22 t22), T23 t23), T24 t24), T25 t25), T26 t26), T27 t27), T28 t28), T29 t29), T30 t30), T31 t31), T32 t32), T33 t33), T34 t34), T35 t35), T36 t36), T37 t37), T38 t38), T39 t39), T40 t40), T41 t41), T42 t42), T43 t43), T44 t44), T45 t45), T46 t46), T47 t47), T48 t48), T49 t49), T50 t50), T51 t51), T52 t52), T53 t53), T54 t54), T55 t55), T56 t56), T57 t57), T58 t58), T59 t59), T60 t60), T61 t61), T62 t62), T63 t63), T64 t64)> codec,
      Delegate64<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59, T60, T61, T62, T63, T64, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Codec<TRaw, TRich>(
        codec.Decoder.Map(t => f(
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t1,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t2,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t3,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t4,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t5,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t6,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t7,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t8,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t9,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t10,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t11,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t12,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t13,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t14,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t15,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t16,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t17,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t18,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t19,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t20,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t21,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t22,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t23,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t24,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t25,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t26,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t27,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t28,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t29,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t30,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t31,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t32,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t33,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t34,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t35,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t36,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t37,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t38,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t39,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t40,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t41,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t42,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t43,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t44,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t45,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t46,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t47,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t48,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t49,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t50,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t51,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t52,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t53,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t54,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t55,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t56,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t57,
          t.Item1.Item1.Item1.Item1.Item1.Item1.t58,
          t.Item1.Item1.Item1.Item1.Item1.t59,
          t.Item1.Item1.Item1.Item1.t60,
          t.Item1.Item1.Item1.t61,
          t.Item1.Item1.t62,
          t.Item1.t63,
          t.t64)),
        codec.Encoder
      );
    }

    public delegate T66 Delegate65<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59, T60, T61, T62, T63, T64, T65, T66>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32, T33 t33, T34 t34, T35 t35, T36 t36, T37 t37, T38 t38, T39 t39, T40 t40, T41 t41, T42 t42, T43 t43, T44 t44, T45 t45, T46 t46, T47 t47, T48 t48, T49 t49, T50 t50, T51 t51, T52 t52, T53 t53, T54 t54, T55 t55, T56 t56, T57 t57, T58 t58, T59 t59, T60 t60, T61 t61, T62 t62, T63 t63, T64 t64, T65 t65);
    public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59, T60, T61, T62, T63, T64, T65>(
      this Codec<TRaw, TRich, ((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((((T1 t1, T2 t2), T3 t3), T4 t4), T5 t5), T6 t6), T7 t7), T8 t8), T9 t9), T10 t10), T11 t11), T12 t12), T13 t13), T14 t14), T15 t15), T16 t16), T17 t17), T18 t18), T19 t19), T20 t20), T21 t21), T22 t22), T23 t23), T24 t24), T25 t25), T26 t26), T27 t27), T28 t28), T29 t29), T30 t30), T31 t31), T32 t32), T33 t33), T34 t34), T35 t35), T36 t36), T37 t37), T38 t38), T39 t39), T40 t40), T41 t41), T42 t42), T43 t43), T44 t44), T45 t45), T46 t46), T47 t47), T48 t48), T49 t49), T50 t50), T51 t51), T52 t52), T53 t53), T54 t54), T55 t55), T56 t56), T57 t57), T58 t58), T59 t59), T60 t60), T61 t61), T62 t62), T63 t63), T64 t64), T65 t65)> codec,
      Delegate65<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59, T60, T61, T62, T63, T64, T65, TRich> f)
      where TRaw : struct, IMonoid<TRaw>
    {
      return new Codec<TRaw, TRich>(
        codec.Decoder.Map(t => f(
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t1,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t2,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t3,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t4,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t5,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t6,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t7,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t8,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t9,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t10,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t11,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t12,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t13,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t14,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t15,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t16,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t17,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t18,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t19,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t20,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t21,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t22,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t23,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t24,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t25,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t26,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t27,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t28,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t29,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t30,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t31,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t32,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t33,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t34,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t35,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t36,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t37,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t38,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t39,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t40,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t41,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t42,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t43,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t44,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t45,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t46,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t47,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t48,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t49,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t50,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t51,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t52,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t53,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t54,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t55,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t56,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t57,
          t.Item1.Item1.Item1.Item1.Item1.Item1.Item1.t58,
          t.Item1.Item1.Item1.Item1.Item1.Item1.t59,
          t.Item1.Item1.Item1.Item1.Item1.t60,
          t.Item1.Item1.Item1.Item1.t61,
          t.Item1.Item1.Item1.t62,
          t.Item1.Item1.t63,
          t.Item1.t64,
          t.t65)),
        codec.Encoder
      );
    }



  }

}