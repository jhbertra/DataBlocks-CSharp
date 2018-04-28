using System;

using DataBlocks.Prelude;
using JetBrains.Annotations;
using LanguageExt;

namespace DataBlocks.Core
{

    public static class EncoderExtensions
    {

        public static Encoder<T3, T1> ComposeRight<T1, T2, T3>(this Encoder<T2, T1> g, Encoder<T3, T2> f)
        {
            return new Encoder<T3, T1>(x => f.Encode(g.Encode(x)));
        }

        public static Encoder<T3, T1> ComposeLeft<T1, T2, T3>(this Encoder<T3, T2> f, Encoder<T2, T1> g)
        {
            return new Encoder<T3, T1>(x => f.Encode(g.Encode(x)));
        }

        public static Encoder<T4, T3> Dimap<T1, T2, T3, T4>(this Encoder<T2, T1> e, [NotNull] Func<T3, T1> f, [NotNull] Func<T2, T4> g)
        {
            if (f == null) throw new ArgumentNullException(nameof(f));
            if (g == null) throw new ArgumentNullException(nameof(g));

            return new Encoder<T4, T3>(x => g(e.Encode(f(x))));
        }

        public static Encoder<T3, T1> Map<T1, T2, T3>(this Encoder<T2, T1> e, [NotNull] Func<T2, T3> f)
        {
            return e.Dimap<T1, T2, T1, T3>(x => x, f);
        }

        public static Encoder<T2, T3> Contramap<T1, T2, T3>(this Encoder<T2, T1> e, [NotNull] Func<T3, T1> f)
        {
            return e.Dimap(f, x => x);
        }

    }

}