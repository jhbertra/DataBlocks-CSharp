using System;

using JetBrains.Annotations;
using LanguageExt;

namespace DataBlocks.Core
{

    /// <summary>
    /// Extension methods for working with Encoders.
    /// </summary>
    public static class EncoderExtensions
    {

        /// <summary>
        /// Create an Encoder by feeding the output of the first into the second.
        /// </summary>
        public static Encoder<T3, T1> ComposeRight<T1, T2, T3>(this Encoder<T2, T1> g, Encoder<T3, T2> f)
        {
            return x => f(g(x));
        }


        /// <summary>
        /// Create an Encoder by feeding the output of the second into the first.
        /// </summary>
        public static Encoder<T3, T1> ComposeLeft<T1, T2, T3>(this Encoder<T3, T2> f, Encoder<T2, T1> g)
        {
            return x => f(g(x));
        }


        /// <summary>
        /// Map over the input and the output of the encoder.
        /// </summary>
        public static Encoder<T4, T3> Dimap<T1, T2, T3, T4>(this Encoder<T2, T1> e, [NotNull] Func<T3, T1> f, [NotNull] Func<T2, T4> g)
        {
            if (f == null) throw new ArgumentNullException(nameof(f));
            if (g == null) throw new ArgumentNullException(nameof(g));

            return x => g(e(f(x)));
        }


        /// <summary>
        /// Map over the output of the encoder.
        /// </summary>
        public static Encoder<T3, T1> Map<T1, T2, T3>(this Encoder<T2, T1> e, [NotNull] Func<T2, T3> f)
        {
            return e.Dimap<T1, T2, T1, T3>(x => x, f);
        }


        /// <summary>
        /// Map over the input of the encoder
        /// </summary>
        public static Encoder<T2, T3> Contramap<T1, T2, T3>(this Encoder<T2, T1> e, [NotNull] Func<T3, T1> f)
        {
            return e.Dimap(f, x => x);
        }

    }

}