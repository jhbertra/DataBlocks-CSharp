using System;
using System.Linq;
using JetBrains.Annotations;
using LanguageExt;

namespace DataBlocks.Core
{

    /// <summary>
    /// Extension methods for working with Decoders.
    /// </summary>
    public static class DecoderExtensions
    {

        /// <summary>
        /// Map both the input and output of a decoder to
        /// produce a new decoder.
        /// </summary>
        public static Decoder<TRaw2, T2> Dimap<TRaw1, T1, TRaw2, T2>(
            this Decoder<TRaw1, T1> decoder,
            [NotNull] Func<TRaw2, TRaw1> f,
            [NotNull] Func<T1, T2> g)
        {
            if (f == null) throw new ArgumentNullException(nameof(f));
            if (g == null) throw new ArgumentNullException(nameof(g));

            return new Decoder<TRaw2, T2>((id, x) => decoder.Run(id, f(x)).Map(g), decoder.Id);
        }


        /// <summary>
        /// Map the output of the decoder.
        /// </summary>
        public static Decoder<TRaw, T2> Map<TRaw, T1, T2>(
            this Decoder<TRaw, T1> decoder,
            [NotNull] Func<T1, T2> f)
        {
            return decoder.Dimap<TRaw, T1, TRaw, T2>(x => x, f);
        }


        /// <summary>
        /// Map the input of the decoder.
        /// </summary>
        public static Decoder<TRaw2, T> Contramap<TRaw1, T, TRaw2>(
            this Decoder<TRaw1, T> decoder,
            [NotNull] Func<TRaw2, TRaw1> f)
        {
            return decoder.Dimap(f, x => x);
        }


        /// <summary>
        /// Return a new Decoder computed from the result of the first.
        /// </summary>
        public static Decoder<TRaw, T2> Bind<TRaw, T1, T2>(
            this Decoder<TRaw, T1> decoder,
            [NotNull] Func<T1, Decoder<TRaw, T2>> f)
        {
            if (f == null) throw new ArgumentNullException(nameof(f));

            return new Decoder<TRaw, T2>(
                (id, x) =>
                    from result1 in decoder.Run(id, x)
                    from result2 in f(result1).Run(id, x)
                    select result2,
                decoder.Id);
        }


        /// <summary>
        /// Add an additional validation step to the decoder.
        /// </summary>
        public static Decoder<TRaw, T2> ChainValidation<TRaw, T1, T2>(
            this Decoder<TRaw, T1> decoder,
            [NotNull] Func<T1, Either<string, T2>> f)
        {
            if (f == null) throw new ArgumentNullException(nameof(f));

            return decoder.Bind(x =>
                new Decoder<TRaw, T2>((id, data) =>
                    f(x).MapLeft(msg => DecoderErrors.Single(id, msg))));
        }


        /// <summary>
        /// Create a Decoder that will run both decoders and collect the
        /// results in a Pair.
        /// </summary>
        public static Decoder<TRaw, Pair<T1, T2>> Combine<TRaw, T1, T2>(
            this Decoder<TRaw, T1> decoder1,
            Decoder<TRaw, T2> decoder2)
        {
            return new Decoder<TRaw, Pair<T1, T2>>(
                (id, x) =>
                    decoder1.Run(id, x).Match(
                        v1 => decoder2.Run(id, x).Map(v2 => Pair.Create(v1, v2)),
                        e1 => decoder2.Run(id, x).Match(
                            _ => e1,
                            e2 => e1.Append(e2))));
        }


        /// <summary>
        /// Create a Decoder that will select the first succesful result, or
        /// the last failure.
        /// </summary>
        public static Decoder<TRaw, T> Or<TRaw, T>(
            this Decoder<TRaw, T> decoder1,
            Decoder<TRaw, T> decoder2)
        {
            return new Decoder<TRaw, T>((id, x) => decoder1.Run(id, x) || decoder2.Run(id, x));
        }


        /// <summary>
        /// Create a decoder that will feed the output of the first decoder
        /// into the second one.
        /// </summary>
        public static Decoder<TRaw, T> Compose<TRaw, TIntermediate, T>(
            this Decoder<TRaw, TIntermediate> left,
            Decoder<TIntermediate, T> right)
        {
            return new Decoder<TRaw, T>(
                (id, x) =>
                    from intermediate in left.Run(id, x)
                    from rich in right.Run(id, intermediate)
                    select rich);
        }


        /// <summary>
        /// Project the elements of the tuple in the result to the
        /// arguments of the given function.
        /// </summary>
        public static Decoder<TRaw, T> Construct<TRaw, T1, T2, T>(
            this Decoder<TRaw, Pair<T1, T2>> decoder,
            [NotNull] Func<T1, T2, T> f)
        {
            return decoder.Map(t => f(t._1, t._2));
        }

    }

}