using System;

using DataBlocks.Prelude;
using JetBrains.Annotations;
using LanguageExt;
using LanguageExt.TypeClasses;

namespace DataBlocks.Core
{

    public struct Encoder<TRaw, T>
    {

        public Encoder([NotNull] Func<T, TRaw> encode)
        {
            if (encode == null) throw new ArgumentNullException(nameof(encode));
            this.Encode = encode;
        }

        [NotNull] public readonly Func<T, TRaw> Encode;

    }

    public static class Encoder
    {

        public static Encoder<TRaw, T> Divide<MonoidRaw, TRaw, T, T1, T2>(
            [NotNull] Func<T, Pair<T1, T2>> divide,
            Encoder<TRaw, T1> a,
            Encoder<TRaw, T2> b) where MonoidRaw : struct, Monoid<TRaw>
        {
            if (divide == null) throw new ArgumentNullException(nameof(divide));

            return new Encoder<TRaw, T>(
                data =>
                {
                    var pair = divide(data);
                    return default(MonoidRaw).Append(a.Encode(pair._1), b.Encode(pair._2));
                }
            );
        }

        public static Encoder<TRaw, T> Conquer<MonoidRaw, TRaw, T>() where MonoidRaw : struct, Monoid<TRaw>
        {
            return new Encoder<TRaw, T>(_ => default(MonoidRaw).Empty());
        }

        public static Encoder<TRaw, T> Choose<TRaw, T, T1, T2>(
            [NotNull] Func<T, Either<T1, T2>> toEither,
            Encoder<TRaw, T1> a,
            Encoder<TRaw, T2> b)
        {
            if (toEither == null) throw new ArgumentNullException(nameof(toEither));

            return new Encoder<TRaw, T>(t => toEither(t).Match(b.Encode, a.Encode));
        }

        public static Encoder<TRaw, T> Lose<TRaw, T>([NotNull] Func<T, Void> f)
        {
            if (f == null) throw new ArgumentNullException(nameof(f));

            return new Encoder<TRaw, T>(t => Void.Absurd<TRaw>(f(t)));
        }

    }

}