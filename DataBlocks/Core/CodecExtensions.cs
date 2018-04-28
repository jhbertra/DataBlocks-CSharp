using System;

using DataBlocks.Prelude;
using JetBrains.Annotations;
using LanguageExt;
using LanguageExt.TypeClasses;

namespace DataBlocks.Core
{

    public static partial class CodecExtensions
    {

        public static Codec<TRaw2, T2> Invmap2<TRaw1, TRaw2, T1, T2>(
            this Codec<TRaw1, T1> codec,
            [NotNull] Func<TRaw1, TRaw2> f,
            [NotNull] Func<TRaw2, TRaw1> g,
            [NotNull] Func<T1, T2> h,
            [NotNull] Func<T2, T1> i)
        {
            if (f == null) throw new ArgumentNullException(nameof(f));
            if (g == null) throw new ArgumentNullException(nameof(g));
            if (h == null) throw new ArgumentNullException(nameof(h));
            if (i == null) throw new ArgumentNullException(nameof(i));

            return new Codec<TRaw2, T2>(
                codec.Decoder.Dimap(g, h),
                codec.Encoder.Dimap(i, f)
            );
        }


        public static Codec<TRaw2, T> InvmapRaw<TRaw1, TRaw2, T>(
            this Codec<TRaw1, T> codec,
            [NotNull] Func<TRaw1, TRaw2> f,
            [NotNull] Func<TRaw2, TRaw1> g)
        {
            if (f == null) throw new ArgumentNullException(nameof(f));
            if (g == null) throw new ArgumentNullException(nameof(g));

            return new Codec<TRaw2, T>(
                codec.Decoder.Contramap(g),
                codec.Encoder.Map(f)
            );
        }


        public static Codec<TRaw, T2> Invmap<TRaw, T1, T2>(
            this Codec<TRaw, T1> codec,
            [NotNull] Func<T1, T2> f,
            [NotNull] Func<T2, T1> g)
        {
            if (f == null) throw new ArgumentNullException(nameof(f));
            if (g == null) throw new ArgumentNullException(nameof(g));

            return new Codec<TRaw, T2>(
                codec.Decoder.Map(f),
                codec.Encoder.Contramap(g)
            );
        }


        public static Codec<TRaw, T2> ChainValidation<TRaw, T1, T2>(
            this Codec<TRaw, T1> codec,
            [NotNull] Func<T1, Either<string, T2>> f,
            [NotNull] Func<T2, T1> g)
        {
            if (f == null) throw new ArgumentNullException(nameof(f));
            if (g == null) throw new ArgumentNullException(nameof(g));

            return new Codec<TRaw, T2>(
                codec.Decoder.Bind(f),
                codec.Encoder.Contramap(g)
            );
        }


        public static Codec<TRaw, T> Compose<TRaw, TIntermediate, T>(
            this Codec<TRaw, TIntermediate> codec1,
            Codec<TIntermediate, T> codec2)
        {
            return new Codec<TRaw, T>(
                codec1.Decoder.Compose(codec2.Decoder),
                codec2.Encoder.ComposeRight(codec1.Encoder)
            );
        }


        public static Codec<MonoidRaw, TRaw, TPart, T> Part<MonoidRaw, T, TRaw, TPart>(
                this Codec<MonoidRaw, TRaw, Unit, T> codec,
                [NotNull] Func<T, TPart> getter,
                Codec<TRaw, TPart> partCodec)
            where MonoidRaw : struct, Monoid<TRaw>
        {
            if (getter == null) throw new ArgumentNullException(nameof(getter));

            return new Codec<MonoidRaw, TRaw, TPart, T>(
                partCodec.Decoder,
                Encoder.Divide<MonoidRaw, TRaw, T, T, TPart>(x => Pair.Create(x, getter(x)), codec.Encoder, partCodec.Encoder)
            );
        }


        public static Codec<MonoidRaw, TRaw, Pair<TPrevious, TPart>, T> Part<MonoidRaw, T, TRaw, TPrevious, TPart>(
                this Codec<MonoidRaw, TRaw, TPrevious, T> codec,
                [NotNull] Func<T, TPart> getter,
                Codec<TRaw, TPart> partCodec)
            where MonoidRaw : struct, Monoid<TRaw>
        {
            if (getter == null) throw new ArgumentNullException(nameof(getter));

            return new Codec<MonoidRaw, TRaw, Pair<TPrevious, TPart>, T>(
                codec.Decoder.Combine(partCodec.Decoder),
                Encoder.Divide<MonoidRaw, TRaw, T, T, TPart>(x => Pair.Create(x, getter(x)), codec.Encoder, partCodec.Encoder)
            );
        }


        public static Codec<TRaw, T> Case<TRaw, T, TCase>(
            this Codec<TRaw, T> codec,
            [NotNull] Func<T, Option<TCase>> getter,
            [NotNull] Func<TCase, T> wrap,
            Codec<TRaw, TCase> caseCodec)
        {
            if (getter == null) throw new ArgumentNullException(nameof(getter));
            if (wrap == null) throw new ArgumentNullException(nameof(wrap));

            return new Codec<TRaw, T>(
                codec.Decoder.Or(caseCodec.Decoder.Map(wrap)),
                Encoder.Choose<TRaw, T, T, TCase>(x => getter(x).ToEither(x), codec.Encoder, caseCodec.Encoder)
            );
        }


        public static Codec<TRaw, T> Construct<MonoidRaw, TRaw, T, T1>(
                this Codec<MonoidRaw, TRaw, T1, T> codec,
                [NotNull] Func<T1, T> f)
            where MonoidRaw : struct, Monoid<TRaw>
        {
            if (f == null) throw new ArgumentNullException(nameof(f));

            return new Codec<TRaw, T>(
                codec.Decoder.Map(t => f(t)),
                codec.Encoder
            );
        }


        public static Codec<TRaw, T> Construct<MonoidRaw, TRaw, T, T1, T2>(
                this Codec<MonoidRaw, TRaw, Pair<T1, T2>, T> codec,
                [NotNull] Func<T1, T2, T> f)
            where MonoidRaw : struct, Monoid<TRaw>
        {
            if (f == null) throw new ArgumentNullException(nameof(f));

            return new Codec<TRaw, T>(
                codec.Decoder.Map(t => f(t._1, t._2)),
                codec.Encoder
            );
        }

    }

}