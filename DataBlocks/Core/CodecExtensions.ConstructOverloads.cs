using System;

using LanguageExt.TypeClasses;

namespace DataBlocks.Core
{

    public static partial class CodecExtensions
    {

        /// <summary>
        /// Project the contents of the nested pair sequentially to the
        /// arguments of the given function
        /// </summary>
        public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3>(
            this Codec<TRaw, Pair<Pair<T1, T2>, T3>, TRich> codec,
            Func<T1, T2, T3, TRich> f)
        {
            return codec.Construct((t, v) => f(t._1, t._2, v));
        }



        /// <summary>
        /// Project the contents of the nested pair sequentially to the
        /// arguments of the given function.
        /// </summary>
        public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4>(
            this Codec<TRaw, Pair<Pair<Pair<T1, T2>, T3>, T4>, TRich> codec,
            Func<T1, T2, T3, T4, TRich> f)
        {
            return codec.Construct((t, v1, v2) => f(t._1, t._2, v1, v2));
        }



        /// <summary>
        /// Project the contents of the nested pair sequentially to the
        /// arguments of the given function.
        /// </summary>
        public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5>(
            this Codec<TRaw, Pair<Pair<Pair<Pair<T1, T2>, T3>, T4>, T5>, TRich> codec,
            Func<T1, T2, T3, T4, T5, TRich> f)
        {
            return codec.Construct((t, v1, v2, v3) => f(t._1, t._2, v1, v2, v3));
        }



        /// <summary>
        /// Project the contents of the nested pair sequentially to the
        /// arguments of the given function.
        /// </summary>
        public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6>(
            this Codec<TRaw, Pair<Pair<Pair<Pair<Pair<T1, T2>, T3>, T4>, T5>, T6>, TRich> codec,
            Func<T1, T2, T3, T4, T5, T6, TRich> f)
        {
            return codec.Construct((t, v1, v2, v3, v4) => f(t._1, t._2, v1, v2, v3, v4));
        }



        /// <summary>
        /// Project the contents of the nested pair sequentially to the
        /// arguments of the given function.
        /// </summary>
        public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7>(
            this Codec<TRaw, Pair<Pair<Pair<Pair<Pair<Pair<T1, T2>, T3>, T4>, T5>, T6>, T7>, TRich> codec,
            Func<T1, T2, T3, T4, T5, T6, T7, TRich> f)
        {
            return codec.Construct((t, v1, v2, v3, v4, v5) => f(t._1, t._2, v1, v2, v3, v4, v5));
        }



        /// <summary>
        /// Project the contents of the nested pair sequentially to the
        /// arguments of the given function.
        /// </summary>
        public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8>(
            this Codec<TRaw, Pair<Pair<Pair<Pair<Pair<Pair<Pair<T1, T2>, T3>, T4>, T5>, T6>, T7>, T8>, TRich> codec,
            Func<T1, T2, T3, T4, T5, T6, T7, T8, TRich> f)
        {
            return codec.Construct((t, v1, v2, v3, v4, v5, v6) => f(t._1, t._2, v1, v2, v3, v4, v5, v6));
        }



        /// <summary>
        /// Project the contents of the nested pair sequentially to the
        /// arguments of the given function.
        /// </summary>
        public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9>(
            this Codec<TRaw, Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<T1, T2>, T3>, T4>, T5>, T6>, T7>, T8>, T9>, TRich> codec,
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TRich> f)
        {
            return codec.Construct((t, v1, v2, v3, v4, v5, v6, v7) => f(t._1, t._2, v1, v2, v3, v4, v5, v6, v7));
        }



        /// <summary>
        /// Project the contents of the nested pair sequentially to the
        /// arguments of the given function.
        /// </summary>
        public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
            this Codec<TRaw, Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<T1, T2>, T3>, T4>, T5>, T6>, T7>, T8>, T9>, T10>, TRich> codec,
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TRich> f)
        {
            return codec.Construct((t, v1, v2, v3, v4, v5, v6, v7, v8) => f(t._1, t._2, v1, v2, v3, v4, v5, v6, v7, v8));
        }



        /// <summary>
        /// Project the contents of the nested pair sequentially to the
        /// arguments of the given function.
        /// </summary>
        public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
            this Codec<TRaw, Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<T1, T2>, T3>, T4>, T5>, T6>, T7>, T8>, T9>, T10>, T11>, TRich> codec,
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TRich> f)
        {
            return codec.Construct((t, v1, v2, v3, v4, v5, v6, v7, v8, v9) => f(t._1, t._2, v1, v2, v3, v4, v5, v6, v7, v8, v9));
        }



        /// <summary>
        /// Project the contents of the nested pair sequentially to the
        /// arguments of the given function.
        /// </summary>
        public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            this Codec<TRaw, Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<T1, T2>, T3>, T4>, T5>, T6>, T7>, T8>, T9>, T10>, T11>, T12>, TRich> codec,
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TRich> f)
        {
            return codec.Construct((t, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10) => f(t._1, t._2, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10));
        }



        /// <summary>
        /// Project the contents of the nested pair sequentially to the
        /// arguments of the given function.
        /// </summary>
        public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            this Codec<TRaw, Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<T1, T2>, T3>, T4>, T5>, T6>, T7>, T8>, T9>, T10>, T11>, T12>, T13>, TRich> codec,
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TRich> f)
        {
            return codec.Construct((t, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11) => f(t._1, t._2, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11));
        }



        /// <summary>
        /// Project the contents of the nested pair sequentially to the
        /// arguments of the given function.
        /// </summary>
        public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            this Codec<TRaw, Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<T1, T2>, T3>, T4>, T5>, T6>, T7>, T8>, T9>, T10>, T11>, T12>, T13>, T14>, TRich> codec,
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TRich> f)
        {
            return codec.Construct((t, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12) => f(t._1, t._2, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12));
        }



        /// <summary>
        /// Project the contents of the nested pair sequentially to the
        /// arguments of the given function.
        /// </summary>
        public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            this Codec<TRaw, Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<T1, T2>, T3>, T4>, T5>, T6>, T7>, T8>, T9>, T10>, T11>, T12>, T13>, T14>, T15>, TRich> codec,
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TRich> f)
        {
            return codec.Construct((t, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13) => f(t._1, t._2, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13));
        }



        /// <summary>
        /// Project the contents of the nested pair sequentially to the
        /// arguments of the given function.
        /// </summary>
        public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            this Codec<TRaw, Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<T1, T2>, T3>, T4>, T5>, T6>, T7>, T8>, T9>, T10>, T11>, T12>, T13>, T14>, T15>, T16>, TRich> codec,
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TRich> f)
        {
            return codec.Construct((t, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14) => f(t._1, t._2, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14));
        }

        public delegate T19 Delegate18<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18);

        /// <summary>
        /// Project the contents of the nested pair sequentially to the
        /// arguments of the given function.
        /// </summary>
        public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(
            this Codec<TRaw, Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<T1, T2>, T3>, T4>, T5>, T6>, T7>, T8>, T9>, T10>, T11>, T12>, T13>, T14>, T15>, T16>, T17>, T18>, TRich> codec,
            Delegate18<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, TRich> f)
        {
            if (f == null) throw new ArgumentNullException(nameof(f));
            
            return new Codec<TRaw, TRich>(
              codec.Decoder.Map(t => f(
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._2,
                t._1._1._1._1._1._2,
                t._1._1._1._1._2,
                t._1._1._1._2,
                t._1._1._2,
                t._1._2,
                t._2)),
                codec.Encoder
            );
        }

        public delegate T20 Delegate19<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19);

        /// <summary>
        /// Project the contents of the nested pair sequentially to the
        /// arguments of the given function.
        /// </summary>
        public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(
            this Codec<TRaw, Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<T1, T2>, T3>, T4>, T5>, T6>, T7>, T8>, T9>, T10>, T11>, T12>, T13>, T14>, T15>, T16>, T17>, T18>, T19>, TRich> codec,
            Delegate19<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, TRich> f)
        {
            if (f == null) throw new ArgumentNullException(nameof(f));
            
            return new Codec<TRaw, TRich>(
              codec.Decoder.Map(t => f(
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._2,
                t._1._1._1._1._1._2,
                t._1._1._1._1._2,
                t._1._1._1._2,
                t._1._1._2,
                t._1._2,
                t._2)),
                codec.Encoder
            );
        }

        public delegate T21 Delegate20<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20);

        /// <summary>
        /// Project the contents of the nested pair sequentially to the
        /// arguments of the given function.
        /// </summary>
        public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(
            this Codec<TRaw, Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<T1, T2>, T3>, T4>, T5>, T6>, T7>, T8>, T9>, T10>, T11>, T12>, T13>, T14>, T15>, T16>, T17>, T18>, T19>, T20>, TRich> codec,
            Delegate20<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, TRich> f)
        {
            if (f == null) throw new ArgumentNullException(nameof(f));
            
            return new Codec<TRaw, TRich>(
              codec.Decoder.Map(t => f(
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._2,
                t._1._1._1._1._1._2,
                t._1._1._1._1._2,
                t._1._1._1._2,
                t._1._1._2,
                t._1._2,
                t._2)),
                codec.Encoder
            );
        }

        public delegate T22 Delegate21<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21);

        /// <summary>
        /// Project the contents of the nested pair sequentially to the
        /// arguments of the given function.
        /// </summary>
        public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(
            this Codec<TRaw, Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<T1, T2>, T3>, T4>, T5>, T6>, T7>, T8>, T9>, T10>, T11>, T12>, T13>, T14>, T15>, T16>, T17>, T18>, T19>, T20>, T21>, TRich> codec,
            Delegate21<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, TRich> f)
        {
            if (f == null) throw new ArgumentNullException(nameof(f));
            
            return new Codec<TRaw, TRich>(
              codec.Decoder.Map(t => f(
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._2,
                t._1._1._1._1._1._2,
                t._1._1._1._1._2,
                t._1._1._1._2,
                t._1._1._2,
                t._1._2,
                t._2)),
                codec.Encoder
            );
        }

        public delegate T23 Delegate22<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22);

        /// <summary>
        /// Project the contents of the nested pair sequentially to the
        /// arguments of the given function.
        /// </summary>
        public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(
            this Codec<TRaw, Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<T1, T2>, T3>, T4>, T5>, T6>, T7>, T8>, T9>, T10>, T11>, T12>, T13>, T14>, T15>, T16>, T17>, T18>, T19>, T20>, T21>, T22>, TRich> codec,
            Delegate22<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, TRich> f)
        {
            if (f == null) throw new ArgumentNullException(nameof(f));
            
            return new Codec<TRaw, TRich>(
              codec.Decoder.Map(t => f(
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._2,
                t._1._1._1._1._1._2,
                t._1._1._1._1._2,
                t._1._1._1._2,
                t._1._1._2,
                t._1._2,
                t._2)),
                codec.Encoder
            );
        }

        public delegate T24 Delegate23<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23);

        /// <summary>
        /// Project the contents of the nested pair sequentially to the
        /// arguments of the given function.
        /// </summary>
        public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(
            this Codec<TRaw, Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<T1, T2>, T3>, T4>, T5>, T6>, T7>, T8>, T9>, T10>, T11>, T12>, T13>, T14>, T15>, T16>, T17>, T18>, T19>, T20>, T21>, T22>, T23>, TRich> codec,
            Delegate23<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, TRich> f)
        {
            if (f == null) throw new ArgumentNullException(nameof(f));
            
            return new Codec<TRaw, TRich>(
              codec.Decoder.Map(t => f(
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._2,
                t._1._1._1._1._1._2,
                t._1._1._1._1._2,
                t._1._1._1._2,
                t._1._1._2,
                t._1._2,
                t._2)),
                codec.Encoder
            );
        }

        public delegate T25 Delegate24<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24);

        /// <summary>
        /// Project the contents of the nested pair sequentially to the
        /// arguments of the given function.
        /// </summary>
        public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(
            this Codec<TRaw, Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<T1, T2>, T3>, T4>, T5>, T6>, T7>, T8>, T9>, T10>, T11>, T12>, T13>, T14>, T15>, T16>, T17>, T18>, T19>, T20>, T21>, T22>, T23>, T24>, TRich> codec,
            Delegate24<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, TRich> f)
        {
            if (f == null) throw new ArgumentNullException(nameof(f));
            
            return new Codec<TRaw, TRich>(
              codec.Decoder.Map(t => f(
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._2,
                t._1._1._1._1._1._2,
                t._1._1._1._1._2,
                t._1._1._1._2,
                t._1._1._2,
                t._1._2,
                t._2)),
                codec.Encoder
            );
        }

        public delegate T26 Delegate25<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25);

        /// <summary>
        /// Project the contents of the nested pair sequentially to the
        /// arguments of the given function.
        /// </summary>
        public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(
            this Codec<TRaw, Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<T1, T2>, T3>, T4>, T5>, T6>, T7>, T8>, T9>, T10>, T11>, T12>, T13>, T14>, T15>, T16>, T17>, T18>, T19>, T20>, T21>, T22>, T23>, T24>, T25>, TRich> codec,
            Delegate25<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, TRich> f)
        {
            if (f == null) throw new ArgumentNullException(nameof(f));
            
            return new Codec<TRaw, TRich>(
              codec.Decoder.Map(t => f(
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._2,
                t._1._1._1._1._1._2,
                t._1._1._1._1._2,
                t._1._1._1._2,
                t._1._1._2,
                t._1._2,
                t._2)),
                codec.Encoder
            );
        }

        public delegate T27 Delegate26<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26);

        /// <summary>
        /// Project the contents of the nested pair sequentially to the
        /// arguments of the given function.
        /// </summary>
        public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(
            this Codec<TRaw, Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<T1, T2>, T3>, T4>, T5>, T6>, T7>, T8>, T9>, T10>, T11>, T12>, T13>, T14>, T15>, T16>, T17>, T18>, T19>, T20>, T21>, T22>, T23>, T24>, T25>, T26>, TRich> codec,
            Delegate26<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, TRich> f)
        {
            if (f == null) throw new ArgumentNullException(nameof(f));
            
            return new Codec<TRaw, TRich>(
              codec.Decoder.Map(t => f(
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._2,
                t._1._1._1._1._1._2,
                t._1._1._1._1._2,
                t._1._1._1._2,
                t._1._1._2,
                t._1._2,
                t._2)),
                codec.Encoder
            );
        }

        public delegate T28 Delegate27<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27);

        /// <summary>
        /// Project the contents of the nested pair sequentially to the
        /// arguments of the given function.
        /// </summary>
        public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(
            this Codec<TRaw, Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<T1, T2>, T3>, T4>, T5>, T6>, T7>, T8>, T9>, T10>, T11>, T12>, T13>, T14>, T15>, T16>, T17>, T18>, T19>, T20>, T21>, T22>, T23>, T24>, T25>, T26>, T27>, TRich> codec,
            Delegate27<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, TRich> f)
        {
            if (f == null) throw new ArgumentNullException(nameof(f));
            
            return new Codec<TRaw, TRich>(
              codec.Decoder.Map(t => f(
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._2,
                t._1._1._1._1._1._2,
                t._1._1._1._1._2,
                t._1._1._1._2,
                t._1._1._2,
                t._1._2,
                t._2)),
                codec.Encoder
            );
        }

        public delegate T29 Delegate28<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28);

        /// <summary>
        /// Project the contents of the nested pair sequentially to the
        /// arguments of the given function.
        /// </summary>
        public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(
            this Codec<TRaw, Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<T1, T2>, T3>, T4>, T5>, T6>, T7>, T8>, T9>, T10>, T11>, T12>, T13>, T14>, T15>, T16>, T17>, T18>, T19>, T20>, T21>, T22>, T23>, T24>, T25>, T26>, T27>, T28>, TRich> codec,
            Delegate28<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, TRich> f)
        {
            if (f == null) throw new ArgumentNullException(nameof(f));
            
            return new Codec<TRaw, TRich>(
              codec.Decoder.Map(t => f(
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._2,
                t._1._1._1._1._1._2,
                t._1._1._1._1._2,
                t._1._1._1._2,
                t._1._1._2,
                t._1._2,
                t._2)),
                codec.Encoder
            );
        }

        public delegate T30 Delegate29<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29);

        /// <summary>
        /// Project the contents of the nested pair sequentially to the
        /// arguments of the given function.
        /// </summary>
        public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(
            this Codec<TRaw, Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<T1, T2>, T3>, T4>, T5>, T6>, T7>, T8>, T9>, T10>, T11>, T12>, T13>, T14>, T15>, T16>, T17>, T18>, T19>, T20>, T21>, T22>, T23>, T24>, T25>, T26>, T27>, T28>, T29>, TRich> codec,
            Delegate29<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, TRich> f)
        {
            if (f == null) throw new ArgumentNullException(nameof(f));
            
            return new Codec<TRaw, TRich>(
              codec.Decoder.Map(t => f(
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._2,
                t._1._1._1._1._1._2,
                t._1._1._1._1._2,
                t._1._1._1._2,
                t._1._1._2,
                t._1._2,
                t._2)),
                codec.Encoder
            );
        }

        public delegate T31 Delegate30<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30);

        /// <summary>
        /// Project the contents of the nested pair sequentially to the
        /// arguments of the given function.
        /// </summary>
        public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(
            this Codec<TRaw, Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<T1, T2>, T3>, T4>, T5>, T6>, T7>, T8>, T9>, T10>, T11>, T12>, T13>, T14>, T15>, T16>, T17>, T18>, T19>, T20>, T21>, T22>, T23>, T24>, T25>, T26>, T27>, T28>, T29>, T30>, TRich> codec,
            Delegate30<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, TRich> f)
        {
            if (f == null) throw new ArgumentNullException(nameof(f));
            
            return new Codec<TRaw, TRich>(
              codec.Decoder.Map(t => f(
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._2,
                t._1._1._1._1._1._2,
                t._1._1._1._1._2,
                t._1._1._1._2,
                t._1._1._2,
                t._1._2,
                t._2)),
                codec.Encoder
            );
        }

        public delegate T32 Delegate31<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31);

        /// <summary>
        /// Project the contents of the nested pair sequentially to the
        /// arguments of the given function.
        /// </summary>
        public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(
            this Codec<TRaw, Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<T1, T2>, T3>, T4>, T5>, T6>, T7>, T8>, T9>, T10>, T11>, T12>, T13>, T14>, T15>, T16>, T17>, T18>, T19>, T20>, T21>, T22>, T23>, T24>, T25>, T26>, T27>, T28>, T29>, T30>, T31>, TRich> codec,
            Delegate31<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, TRich> f)
        {
            if (f == null) throw new ArgumentNullException(nameof(f));
            
            return new Codec<TRaw, TRich>(
              codec.Decoder.Map(t => f(
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._2,
                t._1._1._1._1._1._2,
                t._1._1._1._1._2,
                t._1._1._1._2,
                t._1._1._2,
                t._1._2,
                t._2)),
                codec.Encoder
            );
        }

        public delegate T33 Delegate32<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32);

        /// <summary>
        /// Project the contents of the nested pair sequentially to the
        /// arguments of the given function.
        /// </summary>
        public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(
            this Codec<TRaw, Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<T1, T2>, T3>, T4>, T5>, T6>, T7>, T8>, T9>, T10>, T11>, T12>, T13>, T14>, T15>, T16>, T17>, T18>, T19>, T20>, T21>, T22>, T23>, T24>, T25>, T26>, T27>, T28>, T29>, T30>, T31>, T32>, TRich> codec,
            Delegate32<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, TRich> f)
        {
            if (f == null) throw new ArgumentNullException(nameof(f));
            
            return new Codec<TRaw, TRich>(
              codec.Decoder.Map(t => f(
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._2,
                t._1._1._1._1._1._2,
                t._1._1._1._1._2,
                t._1._1._1._2,
                t._1._1._2,
                t._1._2,
                t._2)),
                codec.Encoder
            );
        }

        public delegate T34 Delegate33<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32, T33 t33);

        /// <summary>
        /// Project the contents of the nested pair sequentially to the
        /// arguments of the given function.
        /// </summary>
        public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33>(
            this Codec<TRaw, Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<T1, T2>, T3>, T4>, T5>, T6>, T7>, T8>, T9>, T10>, T11>, T12>, T13>, T14>, T15>, T16>, T17>, T18>, T19>, T20>, T21>, T22>, T23>, T24>, T25>, T26>, T27>, T28>, T29>, T30>, T31>, T32>, T33>, TRich> codec,
            Delegate33<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, TRich> f)
        {
            if (f == null) throw new ArgumentNullException(nameof(f));
            
            return new Codec<TRaw, TRich>(
              codec.Decoder.Map(t => f(
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._2,
                t._1._1._1._1._1._2,
                t._1._1._1._1._2,
                t._1._1._1._2,
                t._1._1._2,
                t._1._2,
                t._2)),
                codec.Encoder
            );
        }

        public delegate T35 Delegate34<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32, T33 t33, T34 t34);

        /// <summary>
        /// Project the contents of the nested pair sequentially to the
        /// arguments of the given function.
        /// </summary>
        public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34>(
            this Codec<TRaw, Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<T1, T2>, T3>, T4>, T5>, T6>, T7>, T8>, T9>, T10>, T11>, T12>, T13>, T14>, T15>, T16>, T17>, T18>, T19>, T20>, T21>, T22>, T23>, T24>, T25>, T26>, T27>, T28>, T29>, T30>, T31>, T32>, T33>, T34>, TRich> codec,
            Delegate34<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, TRich> f)
        {
            if (f == null) throw new ArgumentNullException(nameof(f));
            
            return new Codec<TRaw, TRich>(
              codec.Decoder.Map(t => f(
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._2,
                t._1._1._1._1._1._2,
                t._1._1._1._1._2,
                t._1._1._1._2,
                t._1._1._2,
                t._1._2,
                t._2)),
                codec.Encoder
            );
        }

        public delegate T36 Delegate35<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32, T33 t33, T34 t34, T35 t35);

        /// <summary>
        /// Project the contents of the nested pair sequentially to the
        /// arguments of the given function.
        /// </summary>
        public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35>(
            this Codec<TRaw, Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<T1, T2>, T3>, T4>, T5>, T6>, T7>, T8>, T9>, T10>, T11>, T12>, T13>, T14>, T15>, T16>, T17>, T18>, T19>, T20>, T21>, T22>, T23>, T24>, T25>, T26>, T27>, T28>, T29>, T30>, T31>, T32>, T33>, T34>, T35>, TRich> codec,
            Delegate35<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, TRich> f)
        {
            if (f == null) throw new ArgumentNullException(nameof(f));
            
            return new Codec<TRaw, TRich>(
              codec.Decoder.Map(t => f(
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._2,
                t._1._1._1._1._1._2,
                t._1._1._1._1._2,
                t._1._1._1._2,
                t._1._1._2,
                t._1._2,
                t._2)),
                codec.Encoder
            );
        }

        public delegate T37 Delegate36<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32, T33 t33, T34 t34, T35 t35, T36 t36);

        /// <summary>
        /// Project the contents of the nested pair sequentially to the
        /// arguments of the given function.
        /// </summary>
        public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36>(
            this Codec<TRaw, Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<T1, T2>, T3>, T4>, T5>, T6>, T7>, T8>, T9>, T10>, T11>, T12>, T13>, T14>, T15>, T16>, T17>, T18>, T19>, T20>, T21>, T22>, T23>, T24>, T25>, T26>, T27>, T28>, T29>, T30>, T31>, T32>, T33>, T34>, T35>, T36>, TRich> codec,
            Delegate36<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, TRich> f)
        {
            if (f == null) throw new ArgumentNullException(nameof(f));
            
            return new Codec<TRaw, TRich>(
              codec.Decoder.Map(t => f(
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._2,
                t._1._1._1._1._1._2,
                t._1._1._1._1._2,
                t._1._1._1._2,
                t._1._1._2,
                t._1._2,
                t._2)),
                codec.Encoder
            );
        }

        public delegate T38 Delegate37<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32, T33 t33, T34 t34, T35 t35, T36 t36, T37 t37);

        /// <summary>
        /// Project the contents of the nested pair sequentially to the
        /// arguments of the given function.
        /// </summary>
        public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37>(
            this Codec<TRaw, Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<T1, T2>, T3>, T4>, T5>, T6>, T7>, T8>, T9>, T10>, T11>, T12>, T13>, T14>, T15>, T16>, T17>, T18>, T19>, T20>, T21>, T22>, T23>, T24>, T25>, T26>, T27>, T28>, T29>, T30>, T31>, T32>, T33>, T34>, T35>, T36>, T37>, TRich> codec,
            Delegate37<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, TRich> f)
        {
            if (f == null) throw new ArgumentNullException(nameof(f));
            
            return new Codec<TRaw, TRich>(
              codec.Decoder.Map(t => f(
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._2,
                t._1._1._1._1._1._2,
                t._1._1._1._1._2,
                t._1._1._1._2,
                t._1._1._2,
                t._1._2,
                t._2)),
                codec.Encoder
            );
        }

        public delegate T39 Delegate38<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32, T33 t33, T34 t34, T35 t35, T36 t36, T37 t37, T38 t38);

        /// <summary>
        /// Project the contents of the nested pair sequentially to the
        /// arguments of the given function.
        /// </summary>
        public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38>(
            this Codec<TRaw, Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<T1, T2>, T3>, T4>, T5>, T6>, T7>, T8>, T9>, T10>, T11>, T12>, T13>, T14>, T15>, T16>, T17>, T18>, T19>, T20>, T21>, T22>, T23>, T24>, T25>, T26>, T27>, T28>, T29>, T30>, T31>, T32>, T33>, T34>, T35>, T36>, T37>, T38>, TRich> codec,
            Delegate38<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, TRich> f)
        {
            if (f == null) throw new ArgumentNullException(nameof(f));
            
            return new Codec<TRaw, TRich>(
              codec.Decoder.Map(t => f(
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._2,
                t._1._1._1._1._1._2,
                t._1._1._1._1._2,
                t._1._1._1._2,
                t._1._1._2,
                t._1._2,
                t._2)),
                codec.Encoder
            );
        }

        public delegate T40 Delegate39<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32, T33 t33, T34 t34, T35 t35, T36 t36, T37 t37, T38 t38, T39 t39);

        /// <summary>
        /// Project the contents of the nested pair sequentially to the
        /// arguments of the given function.
        /// </summary>
        public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39>(
            this Codec<TRaw, Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<T1, T2>, T3>, T4>, T5>, T6>, T7>, T8>, T9>, T10>, T11>, T12>, T13>, T14>, T15>, T16>, T17>, T18>, T19>, T20>, T21>, T22>, T23>, T24>, T25>, T26>, T27>, T28>, T29>, T30>, T31>, T32>, T33>, T34>, T35>, T36>, T37>, T38>, T39>, TRich> codec,
            Delegate39<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, TRich> f)
        {
            if (f == null) throw new ArgumentNullException(nameof(f));
            
            return new Codec<TRaw, TRich>(
              codec.Decoder.Map(t => f(
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._2,
                t._1._1._1._1._1._2,
                t._1._1._1._1._2,
                t._1._1._1._2,
                t._1._1._2,
                t._1._2,
                t._2)),
                codec.Encoder
            );
        }

        public delegate T41 Delegate40<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32, T33 t33, T34 t34, T35 t35, T36 t36, T37 t37, T38 t38, T39 t39, T40 t40);

        /// <summary>
        /// Project the contents of the nested pair sequentially to the
        /// arguments of the given function.
        /// </summary>
        public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40>(
            this Codec<TRaw, Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<T1, T2>, T3>, T4>, T5>, T6>, T7>, T8>, T9>, T10>, T11>, T12>, T13>, T14>, T15>, T16>, T17>, T18>, T19>, T20>, T21>, T22>, T23>, T24>, T25>, T26>, T27>, T28>, T29>, T30>, T31>, T32>, T33>, T34>, T35>, T36>, T37>, T38>, T39>, T40>, TRich> codec,
            Delegate40<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, TRich> f)
        {
            if (f == null) throw new ArgumentNullException(nameof(f));
            
            return new Codec<TRaw, TRich>(
              codec.Decoder.Map(t => f(
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._2,
                t._1._1._1._1._1._2,
                t._1._1._1._1._2,
                t._1._1._1._2,
                t._1._1._2,
                t._1._2,
                t._2)),
                codec.Encoder
            );
        }

        public delegate T42 Delegate41<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32, T33 t33, T34 t34, T35 t35, T36 t36, T37 t37, T38 t38, T39 t39, T40 t40, T41 t41);

        /// <summary>
        /// Project the contents of the nested pair sequentially to the
        /// arguments of the given function.
        /// </summary>
        public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41>(
            this Codec<TRaw, Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<T1, T2>, T3>, T4>, T5>, T6>, T7>, T8>, T9>, T10>, T11>, T12>, T13>, T14>, T15>, T16>, T17>, T18>, T19>, T20>, T21>, T22>, T23>, T24>, T25>, T26>, T27>, T28>, T29>, T30>, T31>, T32>, T33>, T34>, T35>, T36>, T37>, T38>, T39>, T40>, T41>, TRich> codec,
            Delegate41<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, TRich> f)
        {
            if (f == null) throw new ArgumentNullException(nameof(f));
            
            return new Codec<TRaw, TRich>(
              codec.Decoder.Map(t => f(
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._2,
                t._1._1._1._1._1._2,
                t._1._1._1._1._2,
                t._1._1._1._2,
                t._1._1._2,
                t._1._2,
                t._2)),
                codec.Encoder
            );
        }

        public delegate T43 Delegate42<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32, T33 t33, T34 t34, T35 t35, T36 t36, T37 t37, T38 t38, T39 t39, T40 t40, T41 t41, T42 t42);

        /// <summary>
        /// Project the contents of the nested pair sequentially to the
        /// arguments of the given function.
        /// </summary>
        public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42>(
            this Codec<TRaw, Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<T1, T2>, T3>, T4>, T5>, T6>, T7>, T8>, T9>, T10>, T11>, T12>, T13>, T14>, T15>, T16>, T17>, T18>, T19>, T20>, T21>, T22>, T23>, T24>, T25>, T26>, T27>, T28>, T29>, T30>, T31>, T32>, T33>, T34>, T35>, T36>, T37>, T38>, T39>, T40>, T41>, T42>, TRich> codec,
            Delegate42<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, TRich> f)
        {
            if (f == null) throw new ArgumentNullException(nameof(f));
            
            return new Codec<TRaw, TRich>(
              codec.Decoder.Map(t => f(
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._2,
                t._1._1._1._1._1._2,
                t._1._1._1._1._2,
                t._1._1._1._2,
                t._1._1._2,
                t._1._2,
                t._2)),
                codec.Encoder
            );
        }

        public delegate T44 Delegate43<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32, T33 t33, T34 t34, T35 t35, T36 t36, T37 t37, T38 t38, T39 t39, T40 t40, T41 t41, T42 t42, T43 t43);

        /// <summary>
        /// Project the contents of the nested pair sequentially to the
        /// arguments of the given function.
        /// </summary>
        public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43>(
            this Codec<TRaw, Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<T1, T2>, T3>, T4>, T5>, T6>, T7>, T8>, T9>, T10>, T11>, T12>, T13>, T14>, T15>, T16>, T17>, T18>, T19>, T20>, T21>, T22>, T23>, T24>, T25>, T26>, T27>, T28>, T29>, T30>, T31>, T32>, T33>, T34>, T35>, T36>, T37>, T38>, T39>, T40>, T41>, T42>, T43>, TRich> codec,
            Delegate43<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, TRich> f)
        {
            if (f == null) throw new ArgumentNullException(nameof(f));
            
            return new Codec<TRaw, TRich>(
              codec.Decoder.Map(t => f(
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._2,
                t._1._1._1._1._1._2,
                t._1._1._1._1._2,
                t._1._1._1._2,
                t._1._1._2,
                t._1._2,
                t._2)),
                codec.Encoder
            );
        }

        public delegate T45 Delegate44<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32, T33 t33, T34 t34, T35 t35, T36 t36, T37 t37, T38 t38, T39 t39, T40 t40, T41 t41, T42 t42, T43 t43, T44 t44);

        /// <summary>
        /// Project the contents of the nested pair sequentially to the
        /// arguments of the given function.
        /// </summary>
        public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44>(
            this Codec<TRaw, Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<T1, T2>, T3>, T4>, T5>, T6>, T7>, T8>, T9>, T10>, T11>, T12>, T13>, T14>, T15>, T16>, T17>, T18>, T19>, T20>, T21>, T22>, T23>, T24>, T25>, T26>, T27>, T28>, T29>, T30>, T31>, T32>, T33>, T34>, T35>, T36>, T37>, T38>, T39>, T40>, T41>, T42>, T43>, T44>, TRich> codec,
            Delegate44<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, TRich> f)
        {
            if (f == null) throw new ArgumentNullException(nameof(f));
            
            return new Codec<TRaw, TRich>(
              codec.Decoder.Map(t => f(
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._2,
                t._1._1._1._1._1._2,
                t._1._1._1._1._2,
                t._1._1._1._2,
                t._1._1._2,
                t._1._2,
                t._2)),
                codec.Encoder
            );
        }

        public delegate T46 Delegate45<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32, T33 t33, T34 t34, T35 t35, T36 t36, T37 t37, T38 t38, T39 t39, T40 t40, T41 t41, T42 t42, T43 t43, T44 t44, T45 t45);

        /// <summary>
        /// Project the contents of the nested pair sequentially to the
        /// arguments of the given function.
        /// </summary>
        public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45>(
            this Codec<TRaw, Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<T1, T2>, T3>, T4>, T5>, T6>, T7>, T8>, T9>, T10>, T11>, T12>, T13>, T14>, T15>, T16>, T17>, T18>, T19>, T20>, T21>, T22>, T23>, T24>, T25>, T26>, T27>, T28>, T29>, T30>, T31>, T32>, T33>, T34>, T35>, T36>, T37>, T38>, T39>, T40>, T41>, T42>, T43>, T44>, T45>, TRich> codec,
            Delegate45<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, TRich> f)
        {
            if (f == null) throw new ArgumentNullException(nameof(f));
            
            return new Codec<TRaw, TRich>(
              codec.Decoder.Map(t => f(
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._2,
                t._1._1._1._1._1._2,
                t._1._1._1._1._2,
                t._1._1._1._2,
                t._1._1._2,
                t._1._2,
                t._2)),
                codec.Encoder
            );
        }

        public delegate T47 Delegate46<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32, T33 t33, T34 t34, T35 t35, T36 t36, T37 t37, T38 t38, T39 t39, T40 t40, T41 t41, T42 t42, T43 t43, T44 t44, T45 t45, T46 t46);

        /// <summary>
        /// Project the contents of the nested pair sequentially to the
        /// arguments of the given function.
        /// </summary>
        public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46>(
            this Codec<TRaw, Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<T1, T2>, T3>, T4>, T5>, T6>, T7>, T8>, T9>, T10>, T11>, T12>, T13>, T14>, T15>, T16>, T17>, T18>, T19>, T20>, T21>, T22>, T23>, T24>, T25>, T26>, T27>, T28>, T29>, T30>, T31>, T32>, T33>, T34>, T35>, T36>, T37>, T38>, T39>, T40>, T41>, T42>, T43>, T44>, T45>, T46>, TRich> codec,
            Delegate46<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, TRich> f)
        {
            if (f == null) throw new ArgumentNullException(nameof(f));
            
            return new Codec<TRaw, TRich>(
              codec.Decoder.Map(t => f(
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._2,
                t._1._1._1._1._1._2,
                t._1._1._1._1._2,
                t._1._1._1._2,
                t._1._1._2,
                t._1._2,
                t._2)),
                codec.Encoder
            );
        }

        public delegate T48 Delegate47<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32, T33 t33, T34 t34, T35 t35, T36 t36, T37 t37, T38 t38, T39 t39, T40 t40, T41 t41, T42 t42, T43 t43, T44 t44, T45 t45, T46 t46, T47 t47);

        /// <summary>
        /// Project the contents of the nested pair sequentially to the
        /// arguments of the given function.
        /// </summary>
        public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47>(
            this Codec<TRaw, Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<T1, T2>, T3>, T4>, T5>, T6>, T7>, T8>, T9>, T10>, T11>, T12>, T13>, T14>, T15>, T16>, T17>, T18>, T19>, T20>, T21>, T22>, T23>, T24>, T25>, T26>, T27>, T28>, T29>, T30>, T31>, T32>, T33>, T34>, T35>, T36>, T37>, T38>, T39>, T40>, T41>, T42>, T43>, T44>, T45>, T46>, T47>, TRich> codec,
            Delegate47<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, TRich> f)
        {
            if (f == null) throw new ArgumentNullException(nameof(f));
            
            return new Codec<TRaw, TRich>(
              codec.Decoder.Map(t => f(
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._2,
                t._1._1._1._1._1._2,
                t._1._1._1._1._2,
                t._1._1._1._2,
                t._1._1._2,
                t._1._2,
                t._2)),
                codec.Encoder
            );
        }

        public delegate T49 Delegate48<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32, T33 t33, T34 t34, T35 t35, T36 t36, T37 t37, T38 t38, T39 t39, T40 t40, T41 t41, T42 t42, T43 t43, T44 t44, T45 t45, T46 t46, T47 t47, T48 t48);

        /// <summary>
        /// Project the contents of the nested pair sequentially to the
        /// arguments of the given function.
        /// </summary>
        public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48>(
            this Codec<TRaw, Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<T1, T2>, T3>, T4>, T5>, T6>, T7>, T8>, T9>, T10>, T11>, T12>, T13>, T14>, T15>, T16>, T17>, T18>, T19>, T20>, T21>, T22>, T23>, T24>, T25>, T26>, T27>, T28>, T29>, T30>, T31>, T32>, T33>, T34>, T35>, T36>, T37>, T38>, T39>, T40>, T41>, T42>, T43>, T44>, T45>, T46>, T47>, T48>, TRich> codec,
            Delegate48<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, TRich> f)
        {
            if (f == null) throw new ArgumentNullException(nameof(f));
            
            return new Codec<TRaw, TRich>(
              codec.Decoder.Map(t => f(
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._2,
                t._1._1._1._1._1._2,
                t._1._1._1._1._2,
                t._1._1._1._2,
                t._1._1._2,
                t._1._2,
                t._2)),
                codec.Encoder
            );
        }

        public delegate T50 Delegate49<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32, T33 t33, T34 t34, T35 t35, T36 t36, T37 t37, T38 t38, T39 t39, T40 t40, T41 t41, T42 t42, T43 t43, T44 t44, T45 t45, T46 t46, T47 t47, T48 t48, T49 t49);

        /// <summary>
        /// Project the contents of the nested pair sequentially to the
        /// arguments of the given function.
        /// </summary>
        public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49>(
            this Codec<TRaw, Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<T1, T2>, T3>, T4>, T5>, T6>, T7>, T8>, T9>, T10>, T11>, T12>, T13>, T14>, T15>, T16>, T17>, T18>, T19>, T20>, T21>, T22>, T23>, T24>, T25>, T26>, T27>, T28>, T29>, T30>, T31>, T32>, T33>, T34>, T35>, T36>, T37>, T38>, T39>, T40>, T41>, T42>, T43>, T44>, T45>, T46>, T47>, T48>, T49>, TRich> codec,
            Delegate49<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, TRich> f)
        {
            if (f == null) throw new ArgumentNullException(nameof(f));
            
            return new Codec<TRaw, TRich>(
              codec.Decoder.Map(t => f(
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._2,
                t._1._1._1._1._1._2,
                t._1._1._1._1._2,
                t._1._1._1._2,
                t._1._1._2,
                t._1._2,
                t._2)),
                codec.Encoder
            );
        }

        public delegate T51 Delegate50<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32, T33 t33, T34 t34, T35 t35, T36 t36, T37 t37, T38 t38, T39 t39, T40 t40, T41 t41, T42 t42, T43 t43, T44 t44, T45 t45, T46 t46, T47 t47, T48 t48, T49 t49, T50 t50);

        /// <summary>
        /// Project the contents of the nested pair sequentially to the
        /// arguments of the given function.
        /// </summary>
        public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50>(
            this Codec<TRaw, Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<T1, T2>, T3>, T4>, T5>, T6>, T7>, T8>, T9>, T10>, T11>, T12>, T13>, T14>, T15>, T16>, T17>, T18>, T19>, T20>, T21>, T22>, T23>, T24>, T25>, T26>, T27>, T28>, T29>, T30>, T31>, T32>, T33>, T34>, T35>, T36>, T37>, T38>, T39>, T40>, T41>, T42>, T43>, T44>, T45>, T46>, T47>, T48>, T49>, T50>, TRich> codec,
            Delegate50<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, TRich> f)
        {
            if (f == null) throw new ArgumentNullException(nameof(f));
            
            return new Codec<TRaw, TRich>(
              codec.Decoder.Map(t => f(
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._2,
                t._1._1._1._1._1._2,
                t._1._1._1._1._2,
                t._1._1._1._2,
                t._1._1._2,
                t._1._2,
                t._2)),
                codec.Encoder
            );
        }

        public delegate T52 Delegate51<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32, T33 t33, T34 t34, T35 t35, T36 t36, T37 t37, T38 t38, T39 t39, T40 t40, T41 t41, T42 t42, T43 t43, T44 t44, T45 t45, T46 t46, T47 t47, T48 t48, T49 t49, T50 t50, T51 t51);

        /// <summary>
        /// Project the contents of the nested pair sequentially to the
        /// arguments of the given function.
        /// </summary>
        public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51>(
            this Codec<TRaw, Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<T1, T2>, T3>, T4>, T5>, T6>, T7>, T8>, T9>, T10>, T11>, T12>, T13>, T14>, T15>, T16>, T17>, T18>, T19>, T20>, T21>, T22>, T23>, T24>, T25>, T26>, T27>, T28>, T29>, T30>, T31>, T32>, T33>, T34>, T35>, T36>, T37>, T38>, T39>, T40>, T41>, T42>, T43>, T44>, T45>, T46>, T47>, T48>, T49>, T50>, T51>, TRich> codec,
            Delegate51<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, TRich> f)
        {
            if (f == null) throw new ArgumentNullException(nameof(f));
            
            return new Codec<TRaw, TRich>(
              codec.Decoder.Map(t => f(
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._2,
                t._1._1._1._1._1._2,
                t._1._1._1._1._2,
                t._1._1._1._2,
                t._1._1._2,
                t._1._2,
                t._2)),
                codec.Encoder
            );
        }

        public delegate T53 Delegate52<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32, T33 t33, T34 t34, T35 t35, T36 t36, T37 t37, T38 t38, T39 t39, T40 t40, T41 t41, T42 t42, T43 t43, T44 t44, T45 t45, T46 t46, T47 t47, T48 t48, T49 t49, T50 t50, T51 t51, T52 t52);

        /// <summary>
        /// Project the contents of the nested pair sequentially to the
        /// arguments of the given function.
        /// </summary>
        public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52>(
            this Codec<TRaw, Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<T1, T2>, T3>, T4>, T5>, T6>, T7>, T8>, T9>, T10>, T11>, T12>, T13>, T14>, T15>, T16>, T17>, T18>, T19>, T20>, T21>, T22>, T23>, T24>, T25>, T26>, T27>, T28>, T29>, T30>, T31>, T32>, T33>, T34>, T35>, T36>, T37>, T38>, T39>, T40>, T41>, T42>, T43>, T44>, T45>, T46>, T47>, T48>, T49>, T50>, T51>, T52>, TRich> codec,
            Delegate52<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, TRich> f)
        {
            if (f == null) throw new ArgumentNullException(nameof(f));
            
            return new Codec<TRaw, TRich>(
              codec.Decoder.Map(t => f(
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._2,
                t._1._1._1._1._1._2,
                t._1._1._1._1._2,
                t._1._1._1._2,
                t._1._1._2,
                t._1._2,
                t._2)),
                codec.Encoder
            );
        }

        public delegate T54 Delegate53<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32, T33 t33, T34 t34, T35 t35, T36 t36, T37 t37, T38 t38, T39 t39, T40 t40, T41 t41, T42 t42, T43 t43, T44 t44, T45 t45, T46 t46, T47 t47, T48 t48, T49 t49, T50 t50, T51 t51, T52 t52, T53 t53);

        /// <summary>
        /// Project the contents of the nested pair sequentially to the
        /// arguments of the given function.
        /// </summary>
        public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53>(
            this Codec<TRaw, Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<T1, T2>, T3>, T4>, T5>, T6>, T7>, T8>, T9>, T10>, T11>, T12>, T13>, T14>, T15>, T16>, T17>, T18>, T19>, T20>, T21>, T22>, T23>, T24>, T25>, T26>, T27>, T28>, T29>, T30>, T31>, T32>, T33>, T34>, T35>, T36>, T37>, T38>, T39>, T40>, T41>, T42>, T43>, T44>, T45>, T46>, T47>, T48>, T49>, T50>, T51>, T52>, T53>, TRich> codec,
            Delegate53<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, TRich> f)
        {
            if (f == null) throw new ArgumentNullException(nameof(f));
            
            return new Codec<TRaw, TRich>(
              codec.Decoder.Map(t => f(
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._2,
                t._1._1._1._1._1._2,
                t._1._1._1._1._2,
                t._1._1._1._2,
                t._1._1._2,
                t._1._2,
                t._2)),
                codec.Encoder
            );
        }

        public delegate T55 Delegate54<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32, T33 t33, T34 t34, T35 t35, T36 t36, T37 t37, T38 t38, T39 t39, T40 t40, T41 t41, T42 t42, T43 t43, T44 t44, T45 t45, T46 t46, T47 t47, T48 t48, T49 t49, T50 t50, T51 t51, T52 t52, T53 t53, T54 t54);

        /// <summary>
        /// Project the contents of the nested pair sequentially to the
        /// arguments of the given function.
        /// </summary>
        public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54>(
            this Codec<TRaw, Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<T1, T2>, T3>, T4>, T5>, T6>, T7>, T8>, T9>, T10>, T11>, T12>, T13>, T14>, T15>, T16>, T17>, T18>, T19>, T20>, T21>, T22>, T23>, T24>, T25>, T26>, T27>, T28>, T29>, T30>, T31>, T32>, T33>, T34>, T35>, T36>, T37>, T38>, T39>, T40>, T41>, T42>, T43>, T44>, T45>, T46>, T47>, T48>, T49>, T50>, T51>, T52>, T53>, T54>, TRich> codec,
            Delegate54<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, TRich> f)
        {
            if (f == null) throw new ArgumentNullException(nameof(f));
            
            return new Codec<TRaw, TRich>(
              codec.Decoder.Map(t => f(
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._2,
                t._1._1._1._1._1._2,
                t._1._1._1._1._2,
                t._1._1._1._2,
                t._1._1._2,
                t._1._2,
                t._2)),
                codec.Encoder
            );
        }

        public delegate T56 Delegate55<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32, T33 t33, T34 t34, T35 t35, T36 t36, T37 t37, T38 t38, T39 t39, T40 t40, T41 t41, T42 t42, T43 t43, T44 t44, T45 t45, T46 t46, T47 t47, T48 t48, T49 t49, T50 t50, T51 t51, T52 t52, T53 t53, T54 t54, T55 t55);

        /// <summary>
        /// Project the contents of the nested pair sequentially to the
        /// arguments of the given function.
        /// </summary>
        public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55>(
            this Codec<TRaw, Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<T1, T2>, T3>, T4>, T5>, T6>, T7>, T8>, T9>, T10>, T11>, T12>, T13>, T14>, T15>, T16>, T17>, T18>, T19>, T20>, T21>, T22>, T23>, T24>, T25>, T26>, T27>, T28>, T29>, T30>, T31>, T32>, T33>, T34>, T35>, T36>, T37>, T38>, T39>, T40>, T41>, T42>, T43>, T44>, T45>, T46>, T47>, T48>, T49>, T50>, T51>, T52>, T53>, T54>, T55>, TRich> codec,
            Delegate55<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, TRich> f)
        {
            if (f == null) throw new ArgumentNullException(nameof(f));
            
            return new Codec<TRaw, TRich>(
              codec.Decoder.Map(t => f(
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._2,
                t._1._1._1._1._1._2,
                t._1._1._1._1._2,
                t._1._1._1._2,
                t._1._1._2,
                t._1._2,
                t._2)),
                codec.Encoder
            );
        }

        public delegate T57 Delegate56<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32, T33 t33, T34 t34, T35 t35, T36 t36, T37 t37, T38 t38, T39 t39, T40 t40, T41 t41, T42 t42, T43 t43, T44 t44, T45 t45, T46 t46, T47 t47, T48 t48, T49 t49, T50 t50, T51 t51, T52 t52, T53 t53, T54 t54, T55 t55, T56 t56);

        /// <summary>
        /// Project the contents of the nested pair sequentially to the
        /// arguments of the given function.
        /// </summary>
        public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56>(
            this Codec<TRaw, Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<T1, T2>, T3>, T4>, T5>, T6>, T7>, T8>, T9>, T10>, T11>, T12>, T13>, T14>, T15>, T16>, T17>, T18>, T19>, T20>, T21>, T22>, T23>, T24>, T25>, T26>, T27>, T28>, T29>, T30>, T31>, T32>, T33>, T34>, T35>, T36>, T37>, T38>, T39>, T40>, T41>, T42>, T43>, T44>, T45>, T46>, T47>, T48>, T49>, T50>, T51>, T52>, T53>, T54>, T55>, T56>, TRich> codec,
            Delegate56<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, TRich> f)
        {
            if (f == null) throw new ArgumentNullException(nameof(f));
            
            return new Codec<TRaw, TRich>(
              codec.Decoder.Map(t => f(
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._2,
                t._1._1._1._1._1._2,
                t._1._1._1._1._2,
                t._1._1._1._2,
                t._1._1._2,
                t._1._2,
                t._2)),
                codec.Encoder
            );
        }

        public delegate T58 Delegate57<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32, T33 t33, T34 t34, T35 t35, T36 t36, T37 t37, T38 t38, T39 t39, T40 t40, T41 t41, T42 t42, T43 t43, T44 t44, T45 t45, T46 t46, T47 t47, T48 t48, T49 t49, T50 t50, T51 t51, T52 t52, T53 t53, T54 t54, T55 t55, T56 t56, T57 t57);

        /// <summary>
        /// Project the contents of the nested pair sequentially to the
        /// arguments of the given function.
        /// </summary>
        public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57>(
            this Codec<TRaw, Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<T1, T2>, T3>, T4>, T5>, T6>, T7>, T8>, T9>, T10>, T11>, T12>, T13>, T14>, T15>, T16>, T17>, T18>, T19>, T20>, T21>, T22>, T23>, T24>, T25>, T26>, T27>, T28>, T29>, T30>, T31>, T32>, T33>, T34>, T35>, T36>, T37>, T38>, T39>, T40>, T41>, T42>, T43>, T44>, T45>, T46>, T47>, T48>, T49>, T50>, T51>, T52>, T53>, T54>, T55>, T56>, T57>, TRich> codec,
            Delegate57<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, TRich> f)
        {
            if (f == null) throw new ArgumentNullException(nameof(f));
            
            return new Codec<TRaw, TRich>(
              codec.Decoder.Map(t => f(
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._2,
                t._1._1._1._1._1._2,
                t._1._1._1._1._2,
                t._1._1._1._2,
                t._1._1._2,
                t._1._2,
                t._2)),
                codec.Encoder
            );
        }

        public delegate T59 Delegate58<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32, T33 t33, T34 t34, T35 t35, T36 t36, T37 t37, T38 t38, T39 t39, T40 t40, T41 t41, T42 t42, T43 t43, T44 t44, T45 t45, T46 t46, T47 t47, T48 t48, T49 t49, T50 t50, T51 t51, T52 t52, T53 t53, T54 t54, T55 t55, T56 t56, T57 t57, T58 t58);

        /// <summary>
        /// Project the contents of the nested pair sequentially to the
        /// arguments of the given function.
        /// </summary>
        public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58>(
            this Codec<TRaw, Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<T1, T2>, T3>, T4>, T5>, T6>, T7>, T8>, T9>, T10>, T11>, T12>, T13>, T14>, T15>, T16>, T17>, T18>, T19>, T20>, T21>, T22>, T23>, T24>, T25>, T26>, T27>, T28>, T29>, T30>, T31>, T32>, T33>, T34>, T35>, T36>, T37>, T38>, T39>, T40>, T41>, T42>, T43>, T44>, T45>, T46>, T47>, T48>, T49>, T50>, T51>, T52>, T53>, T54>, T55>, T56>, T57>, T58>, TRich> codec,
            Delegate58<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, TRich> f)
        {
            if (f == null) throw new ArgumentNullException(nameof(f));
            
            return new Codec<TRaw, TRich>(
              codec.Decoder.Map(t => f(
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._2,
                t._1._1._1._1._1._2,
                t._1._1._1._1._2,
                t._1._1._1._2,
                t._1._1._2,
                t._1._2,
                t._2)),
                codec.Encoder
            );
        }

        public delegate T60 Delegate59<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59, T60>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32, T33 t33, T34 t34, T35 t35, T36 t36, T37 t37, T38 t38, T39 t39, T40 t40, T41 t41, T42 t42, T43 t43, T44 t44, T45 t45, T46 t46, T47 t47, T48 t48, T49 t49, T50 t50, T51 t51, T52 t52, T53 t53, T54 t54, T55 t55, T56 t56, T57 t57, T58 t58, T59 t59);

        /// <summary>
        /// Project the contents of the nested pair sequentially to the
        /// arguments of the given function.
        /// </summary>
        public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59>(
            this Codec<TRaw, Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<T1, T2>, T3>, T4>, T5>, T6>, T7>, T8>, T9>, T10>, T11>, T12>, T13>, T14>, T15>, T16>, T17>, T18>, T19>, T20>, T21>, T22>, T23>, T24>, T25>, T26>, T27>, T28>, T29>, T30>, T31>, T32>, T33>, T34>, T35>, T36>, T37>, T38>, T39>, T40>, T41>, T42>, T43>, T44>, T45>, T46>, T47>, T48>, T49>, T50>, T51>, T52>, T53>, T54>, T55>, T56>, T57>, T58>, T59>, TRich> codec,
            Delegate59<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59, TRich> f)
        {
            if (f == null) throw new ArgumentNullException(nameof(f));
            
            return new Codec<TRaw, TRich>(
              codec.Decoder.Map(t => f(
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._2,
                t._1._1._1._1._1._2,
                t._1._1._1._1._2,
                t._1._1._1._2,
                t._1._1._2,
                t._1._2,
                t._2)),
                codec.Encoder
            );
        }

        public delegate T61 Delegate60<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59, T60, T61>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32, T33 t33, T34 t34, T35 t35, T36 t36, T37 t37, T38 t38, T39 t39, T40 t40, T41 t41, T42 t42, T43 t43, T44 t44, T45 t45, T46 t46, T47 t47, T48 t48, T49 t49, T50 t50, T51 t51, T52 t52, T53 t53, T54 t54, T55 t55, T56 t56, T57 t57, T58 t58, T59 t59, T60 t60);

        /// <summary>
        /// Project the contents of the nested pair sequentially to the
        /// arguments of the given function.
        /// </summary>
        public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59, T60>(
            this Codec<TRaw, Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<T1, T2>, T3>, T4>, T5>, T6>, T7>, T8>, T9>, T10>, T11>, T12>, T13>, T14>, T15>, T16>, T17>, T18>, T19>, T20>, T21>, T22>, T23>, T24>, T25>, T26>, T27>, T28>, T29>, T30>, T31>, T32>, T33>, T34>, T35>, T36>, T37>, T38>, T39>, T40>, T41>, T42>, T43>, T44>, T45>, T46>, T47>, T48>, T49>, T50>, T51>, T52>, T53>, T54>, T55>, T56>, T57>, T58>, T59>, T60>, TRich> codec,
            Delegate60<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59, T60, TRich> f)
        {
            if (f == null) throw new ArgumentNullException(nameof(f));
            
            return new Codec<TRaw, TRich>(
              codec.Decoder.Map(t => f(
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._2,
                t._1._1._1._1._1._2,
                t._1._1._1._1._2,
                t._1._1._1._2,
                t._1._1._2,
                t._1._2,
                t._2)),
                codec.Encoder
            );
        }

        public delegate T62 Delegate61<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59, T60, T61, T62>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32, T33 t33, T34 t34, T35 t35, T36 t36, T37 t37, T38 t38, T39 t39, T40 t40, T41 t41, T42 t42, T43 t43, T44 t44, T45 t45, T46 t46, T47 t47, T48 t48, T49 t49, T50 t50, T51 t51, T52 t52, T53 t53, T54 t54, T55 t55, T56 t56, T57 t57, T58 t58, T59 t59, T60 t60, T61 t61);

        /// <summary>
        /// Project the contents of the nested pair sequentially to the
        /// arguments of the given function.
        /// </summary>
        public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59, T60, T61>(
            this Codec<TRaw, Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<T1, T2>, T3>, T4>, T5>, T6>, T7>, T8>, T9>, T10>, T11>, T12>, T13>, T14>, T15>, T16>, T17>, T18>, T19>, T20>, T21>, T22>, T23>, T24>, T25>, T26>, T27>, T28>, T29>, T30>, T31>, T32>, T33>, T34>, T35>, T36>, T37>, T38>, T39>, T40>, T41>, T42>, T43>, T44>, T45>, T46>, T47>, T48>, T49>, T50>, T51>, T52>, T53>, T54>, T55>, T56>, T57>, T58>, T59>, T60>, T61>, TRich> codec,
            Delegate61<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59, T60, T61, TRich> f)
        {
            if (f == null) throw new ArgumentNullException(nameof(f));
            
            return new Codec<TRaw, TRich>(
              codec.Decoder.Map(t => f(
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._2,
                t._1._1._1._1._1._2,
                t._1._1._1._1._2,
                t._1._1._1._2,
                t._1._1._2,
                t._1._2,
                t._2)),
                codec.Encoder
            );
        }

        public delegate T63 Delegate62<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59, T60, T61, T62, T63>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32, T33 t33, T34 t34, T35 t35, T36 t36, T37 t37, T38 t38, T39 t39, T40 t40, T41 t41, T42 t42, T43 t43, T44 t44, T45 t45, T46 t46, T47 t47, T48 t48, T49 t49, T50 t50, T51 t51, T52 t52, T53 t53, T54 t54, T55 t55, T56 t56, T57 t57, T58 t58, T59 t59, T60 t60, T61 t61, T62 t62);

        /// <summary>
        /// Project the contents of the nested pair sequentially to the
        /// arguments of the given function.
        /// </summary>
        public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59, T60, T61, T62>(
            this Codec<TRaw, Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<T1, T2>, T3>, T4>, T5>, T6>, T7>, T8>, T9>, T10>, T11>, T12>, T13>, T14>, T15>, T16>, T17>, T18>, T19>, T20>, T21>, T22>, T23>, T24>, T25>, T26>, T27>, T28>, T29>, T30>, T31>, T32>, T33>, T34>, T35>, T36>, T37>, T38>, T39>, T40>, T41>, T42>, T43>, T44>, T45>, T46>, T47>, T48>, T49>, T50>, T51>, T52>, T53>, T54>, T55>, T56>, T57>, T58>, T59>, T60>, T61>, T62>, TRich> codec,
            Delegate62<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59, T60, T61, T62, TRich> f)
        {
            if (f == null) throw new ArgumentNullException(nameof(f));
            
            return new Codec<TRaw, TRich>(
              codec.Decoder.Map(t => f(
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._2,
                t._1._1._1._1._1._2,
                t._1._1._1._1._2,
                t._1._1._1._2,
                t._1._1._2,
                t._1._2,
                t._2)),
                codec.Encoder
            );
        }

        public delegate T64 Delegate63<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59, T60, T61, T62, T63, T64>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32, T33 t33, T34 t34, T35 t35, T36 t36, T37 t37, T38 t38, T39 t39, T40 t40, T41 t41, T42 t42, T43 t43, T44 t44, T45 t45, T46 t46, T47 t47, T48 t48, T49 t49, T50 t50, T51 t51, T52 t52, T53 t53, T54 t54, T55 t55, T56 t56, T57 t57, T58 t58, T59 t59, T60 t60, T61 t61, T62 t62, T63 t63);

        /// <summary>
        /// Project the contents of the nested pair sequentially to the
        /// arguments of the given function.
        /// </summary>
        public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59, T60, T61, T62, T63>(
            this Codec<TRaw, Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<T1, T2>, T3>, T4>, T5>, T6>, T7>, T8>, T9>, T10>, T11>, T12>, T13>, T14>, T15>, T16>, T17>, T18>, T19>, T20>, T21>, T22>, T23>, T24>, T25>, T26>, T27>, T28>, T29>, T30>, T31>, T32>, T33>, T34>, T35>, T36>, T37>, T38>, T39>, T40>, T41>, T42>, T43>, T44>, T45>, T46>, T47>, T48>, T49>, T50>, T51>, T52>, T53>, T54>, T55>, T56>, T57>, T58>, T59>, T60>, T61>, T62>, T63>, TRich> codec,
            Delegate63<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59, T60, T61, T62, T63, TRich> f)
        {
            if (f == null) throw new ArgumentNullException(nameof(f));
            
            return new Codec<TRaw, TRich>(
              codec.Decoder.Map(t => f(
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._2,
                t._1._1._1._1._1._2,
                t._1._1._1._1._2,
                t._1._1._1._2,
                t._1._1._2,
                t._1._2,
                t._2)),
                codec.Encoder
            );
        }

        public delegate T65 Delegate64<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59, T60, T61, T62, T63, T64, T65>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32, T33 t33, T34 t34, T35 t35, T36 t36, T37 t37, T38 t38, T39 t39, T40 t40, T41 t41, T42 t42, T43 t43, T44 t44, T45 t45, T46 t46, T47 t47, T48 t48, T49 t49, T50 t50, T51 t51, T52 t52, T53 t53, T54 t54, T55 t55, T56 t56, T57 t57, T58 t58, T59 t59, T60 t60, T61 t61, T62 t62, T63 t63, T64 t64);

        /// <summary>
        /// Project the contents of the nested pair sequentially to the
        /// arguments of the given function.
        /// </summary>
        public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59, T60, T61, T62, T63, T64>(
            this Codec<TRaw, Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<T1, T2>, T3>, T4>, T5>, T6>, T7>, T8>, T9>, T10>, T11>, T12>, T13>, T14>, T15>, T16>, T17>, T18>, T19>, T20>, T21>, T22>, T23>, T24>, T25>, T26>, T27>, T28>, T29>, T30>, T31>, T32>, T33>, T34>, T35>, T36>, T37>, T38>, T39>, T40>, T41>, T42>, T43>, T44>, T45>, T46>, T47>, T48>, T49>, T50>, T51>, T52>, T53>, T54>, T55>, T56>, T57>, T58>, T59>, T60>, T61>, T62>, T63>, T64>, TRich> codec,
            Delegate64<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59, T60, T61, T62, T63, T64, TRich> f)
        {
            if (f == null) throw new ArgumentNullException(nameof(f));
            
            return new Codec<TRaw, TRich>(
              codec.Decoder.Map(t => f(
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._2,
                t._1._1._1._1._1._2,
                t._1._1._1._1._2,
                t._1._1._1._2,
                t._1._1._2,
                t._1._2,
                t._2)),
                codec.Encoder
            );
        }

        public delegate T66 Delegate65<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59, T60, T61, T62, T63, T64, T65, T66>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32, T33 t33, T34 t34, T35 t35, T36 t36, T37 t37, T38 t38, T39 t39, T40 t40, T41 t41, T42 t42, T43 t43, T44 t44, T45 t45, T46 t46, T47 t47, T48 t48, T49 t49, T50 t50, T51 t51, T52 t52, T53 t53, T54 t54, T55 t55, T56 t56, T57 t57, T58 t58, T59 t59, T60 t60, T61 t61, T62 t62, T63 t63, T64 t64, T65 t65);

        /// <summary>
        /// Project the contents of the nested pair sequentially to the
        /// arguments of the given function.
        /// </summary>
        public static Codec<TRaw, TRich> Construct<TRaw, TRich, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59, T60, T61, T62, T63, T64, T65>(
            this Codec<TRaw, Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<Pair<T1, T2>, T3>, T4>, T5>, T6>, T7>, T8>, T9>, T10>, T11>, T12>, T13>, T14>, T15>, T16>, T17>, T18>, T19>, T20>, T21>, T22>, T23>, T24>, T25>, T26>, T27>, T28>, T29>, T30>, T31>, T32>, T33>, T34>, T35>, T36>, T37>, T38>, T39>, T40>, T41>, T42>, T43>, T44>, T45>, T46>, T47>, T48>, T49>, T50>, T51>, T52>, T53>, T54>, T55>, T56>, T57>, T58>, T59>, T60>, T61>, T62>, T63>, T64>, T65>, TRich> codec,
            Delegate65<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55, T56, T57, T58, T59, T60, T61, T62, T63, T64, T65, TRich> f)
        {
            if (f == null) throw new ArgumentNullException(nameof(f));
            
            return new Codec<TRaw, TRich>(
              codec.Decoder.Map(t => f(
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._1._2,
                t._1._1._1._1._1._1._2,
                t._1._1._1._1._1._2,
                t._1._1._1._1._2,
                t._1._1._1._2,
                t._1._1._2,
                t._1._2,
                t._2)),
                codec.Encoder
            );
        }



    }

}