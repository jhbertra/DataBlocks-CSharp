using System;

using JetBrains.Annotations;
using LanguageExt;
using LanguageExt.TypeClasses;

namespace DataBlocks.Core
{

    /// <summary>
    /// Converts a data type into a raw data type.
    /// </summary>
    [NotNull] public delegate TRaw Encoder<TRaw, T>([NotNull] T data);


    /// <summary>
    /// Utilities for creating Encoders.
    /// </summary>

    public static class Encoder
    {

        /// <summary>
        /// Create an encoder that breaks a larger data structure
        /// into two pieces and handles each piece with a separate
        /// encoder, combining the outputs in order.
        /// </summary>
        public static Encoder<TRaw, T> Divide<TRaw, T, T1, T2>(
            [NotNull] Func<TRaw, TRaw, TRaw> appendResults,
            [NotNull] Func<T, Pair<T1, T2>> divide,
            Encoder<TRaw, T1> a,
            Encoder<TRaw, T2> b)
        {
            if (appendResults == null) throw new ArgumentNullException(nameof(appendResults));
            if (divide == null) throw new ArgumentNullException(nameof(divide));

            return data =>
            {
                var pair = divide(data);
                return appendResults(a(pair._1), b(pair._2));
            };
        }


        /// <summary>
        /// Create an encoder that outputs nothing to terminate a chain of
        /// data structure divisions.
        /// </summary>
        /// /// <remarks>
        /// Acts as an identity to Divide.
        /// </remarks>
        public static Encoder<TRaw, T> Conquer<TRaw, T>([NotNull] TRaw emptyRaw)
        {
            if (emptyRaw == null) throw new ArgumentNullException(nameof(emptyRaw));

            return _ => emptyRaw;
        }


        /// <summary>
        /// Create an encoder that runs one of the two given encoders depending
        /// on the result of toEither.
        /// </summary>
        public static Encoder<TRaw, T> Choose<TRaw, T, T1, T2>(
            [NotNull] Func<T, Either<T1, T2>> toEither,
            Encoder<TRaw, T1> a,
            Encoder<TRaw, T2> b)
        {
            if (toEither == null) throw new ArgumentNullException(nameof(toEither));

            return t => toEither(t).Match(b.Invoke, a.Invoke);
        }


        /// <summary>
        /// Create an encoder that represents a lack of valid choices
        /// in a sequence of encoder choices, for example at the start.
        /// </summary>
        /// <remarks>
        /// Acts as an identity to Choose.
        /// </remarks>
        public static Encoder<TRaw, T> Lose<TRaw, T>([NotNull] Func<T, Void> f)
        {
            if (f == null) throw new ArgumentNullException(nameof(f));

            return t => Void.Absurd<TRaw>(f(t));
        }

    }

}