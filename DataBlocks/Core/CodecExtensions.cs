using System;

using JetBrains.Annotations;
using LanguageExt;
using LanguageExt.TypeClasses;

namespace DataBlocks.Core
{

    /// <summary>
    /// Extension methods for working with Codecs.
    /// </summary>
    public static partial class CodecExtensions
    {

        /// <summary>
        /// Perform an invariant-map on both the raw data type
        /// and the result data type of the codec.
        /// </summary>
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


        /// <summary>
        /// Perform an invariant-map on the raw data type of the
        /// codec.
        /// </summary>
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


        /// <summary>
        /// Perform an invariant-map of the result data type
        /// of the Codec.
        /// </summary>
        /// <remarks>
        /// the functions correspond to the transformations required
        /// by both the decoder and the encoder. The decoder will
        /// map function f over its result, and the encoder will contramap
        /// function g over its input.
        /// </remarks>
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


        /// <summary>
        /// Perform additional validation on the result of the codec.
        /// </summary>
        /// <remarks>
        /// Note that Invmap is a special case of this function where
        /// the function f implicitly always returns a succesful result.
        /// </remarks>
        public static Codec<TRaw, T2> ChainValidation<TRaw, T1, T2>(
            this Codec<TRaw, T1> codec,
            [NotNull] Func<T1, Either<string, T2>> f,
            [NotNull] Func<T2, T1> g)
        {
            if (f == null) throw new ArgumentNullException(nameof(f));
            if (g == null) throw new ArgumentNullException(nameof(g));

            return new Codec<TRaw, T2>(
                codec.Decoder.ChainValidation(f),
                codec.Encoder.Contramap(g)
            );
        }


        /// <summary>
        /// Create a codec that runs the data through both of the provided
        /// codecs in sequence.
        /// </summary>
        public static Codec<TRaw, T> Compose<TRaw, TIntermediate, T>(
            this Codec<TRaw, TIntermediate> codec1,
            Codec<TIntermediate, T> codec2)
        {
            return new Codec<TRaw, T>(
                codec1.Decoder.Compose(codec2.Decoder),
                codec2.Encoder.ComposeRight(codec1.Encoder)
            );
        }


        /// <summary>
        /// Create a codec for part of a larger data structure.
        /// </summary>
        public static Codec<TRaw, TPart, T> Part<T, TRaw, TPart>(
                this Codec<TRaw, Unit, T> codec,
                [NotNull] Func<T, TPart> getter,
                Codec<TRaw, TPart> partCodec)
        {
            if (getter == null) throw new ArgumentNullException(nameof(getter));

            return new Codec<TRaw, TPart, T>(
                partCodec.Decoder,
                Encoder.Divide<TRaw, T, T, TPart>(codec.AppendRaw, x => Pair.Create(x, getter(x)), codec.Encoder, partCodec.Encoder),
                codec.EmptyRaw,
                codec.AppendRaw
            );
        }


        /// <summary>
        /// Create a codec for part of a larger data structure.
        /// </summary>
        public static Codec<TRaw, Pair<TPrevious, TPart>, T> Part<T, TRaw, TPrevious, TPart>(
                this Codec<TRaw, TPrevious, T> codec,
                [NotNull] Func<T, TPart> getter,
                Codec<TRaw, TPart> partCodec)
        {
            if (getter == null) throw new ArgumentNullException(nameof(getter));

            return new Codec<TRaw, Pair<TPrevious, TPart>, T>(
                codec.Decoder.Combine(partCodec.Decoder),
                Encoder.Divide<TRaw, T, T, TPart>(codec.AppendRaw, x => Pair.Create(x, getter(x)), codec.Encoder, partCodec.Encoder),
                codec.EmptyRaw,
                codec.AppendRaw
            );
        }


        /// <summary>
        /// Create a codec that selects between the "this" reciever codec
        /// and the provided codec.
        /// </summary>
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


        /// <summary>
        /// Project the contents of the codec to the
        /// arguments of the given function. Note that
        /// this is effectively a map that joins the types of the
        /// decoder and the encoder.
        /// </summary>
        public static Codec<TRaw, T> Construct<TRaw, T, T1>(
                this Codec<TRaw, T1, T> codec,
                [NotNull] Func<T1, T> f)
        {
            if (f == null) throw new ArgumentNullException(nameof(f));

            return new Codec<TRaw, T>(
                codec.Decoder.Map(t => f(t)),
                codec.Encoder
            );
        }


        /// <summary>
        /// Project the contents of the pair sequentially to the
        /// arguments of the given function.
        /// </summary>
        public static Codec<TRaw, T> Construct<TRaw, T, T1, T2>(
                this Codec<TRaw, Pair<T1, T2>, T> codec,
                [NotNull] Func<T1, T2, T> f)
        {
            if (f == null) throw new ArgumentNullException(nameof(f));

            return new Codec<TRaw, T>(
                codec.Decoder.Map(t => f(t._1, t._2)),
                codec.Encoder
            );
        }

    }

}