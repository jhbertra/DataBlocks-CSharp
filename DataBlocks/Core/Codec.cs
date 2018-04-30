using System;

using JetBrains.Annotations;
using LanguageExt;
using LanguageExt.TypeClasses;

namespace DataBlocks.Core
{

    /// <summary>
    /// The base codec data structure. Contains a Decoder
    /// and an Encoder.
    /// </summary>
    public sealed class Codec<TRaw, T>
    {

        /***********************************************/
        /* Data
        /***********************************************/

        /// <summary>
        /// The Decoder of this Codec.
        /// </summary>
        public readonly Decoder<TRaw, T> Decoder;


        /// <summary>
        /// The Encoder of this Codec.
        /// </summary>
        public readonly Encoder<TRaw, T> Encoder;



        /***********************************************/
        /* Constructors
        /***********************************************/

        /// <summary>
        /// Create a new Codec from the given decoder and encoder.
        /// </summary>
        public Codec(Decoder<TRaw, T> decoder, Encoder<TRaw, T> encoder)
        {
            this.Decoder = decoder;
            this.Encoder = encoder;
        }



        /***********************************************/
        /* Methods
        /***********************************************/

        /// <summary>
        /// Decode the raw data and return either a collection of
        /// errors or the decoded data.
        /// </summary>
        public Either<DecoderErrors, T> Decode(TRaw raw) => this.Decoder.Decode(raw);


        /// <summary>
        /// Encode the data into raw data.
        /// </summary>
        public TRaw Encode(T data) => this.Encoder(data);


        /// <summary>
        /// Make a new Codec with the given error reporting id.
        /// </summary>
        public Codec<TRaw, T> SetId([NotNull] string id) => new Codec<TRaw, T>(this.Decoder.SetId(id), this.Encoder);

    }


    /// <summary>
    /// A Codec with and encoder and a decoder whose rich data
    /// types are different.
    /// </summary>
    public sealed class Codec<TRaw, TDecoder, TEncoder>
    {

        /***********************************************/
        /* Data
        /***********************************************/

        /// <summary>
        /// The Decoder of this Codec
        /// </summary>
        public readonly Decoder<TRaw, TDecoder> Decoder;


        /// <summary>
        /// The Encoder of this Codec
        /// </summary>
        public readonly Encoder<TRaw, TEncoder> Encoder;


        /// <summary>
        /// Empty member of the set of raw data.
        /// </summary>
        [NotNull] public readonly TRaw EmptyRaw;


        /// <summary>
        /// Associative combination operator for the raw data format.
        /// </summary>
        [NotNull] public readonly Func<TRaw, TRaw, TRaw> AppendRaw;



        /***********************************************/
        /* Constructors
        /***********************************************/

        /// <summary>
        /// Create a new Codec
        /// </summary>
        public Codec(
            Decoder<TRaw, TDecoder> decoder,
            Encoder<TRaw, TEncoder> encoder,
            [NotNull] TRaw emptyRaw,
            [NotNull] Func<TRaw, TRaw, TRaw> appendRaw)
        {
            if (emptyRaw == null) throw new ArgumentNullException(nameof(emptyRaw));
            if (appendRaw == null) throw new ArgumentNullException(nameof(appendRaw));

            this.Decoder = decoder;
            this.Encoder = encoder;
            this.EmptyRaw = emptyRaw;
            this.AppendRaw = appendRaw;
        }

    }


    /// <summary>
    /// Utilities for creating Codecs.
    /// </summary>
    public static class Codec
    {

        /// <summary>
        /// Begin assembling a Codec for a larger datatype.
        /// </summary>
        public static Codec<TRaw, Unit, T> BeginConstruction<TRaw, T>(
            [NotNull] TRaw emptyRaw,
            [NotNull] Func<TRaw, TRaw, TRaw> appendRaw)
        {
            if (emptyRaw == null) throw new ArgumentNullException(nameof(emptyRaw));
            if (appendRaw == null) throw new ArgumentNullException(nameof(appendRaw));

            return new Codec<TRaw, Unit, T>(
                Decoder<TRaw, Unit>.Return(Unit.Default),
                Encoder.Conquer<TRaw, T>(emptyRaw),
                emptyRaw,
                appendRaw
            );
        }


        /// <summary>
        /// Start a sequence of alternative representations of data.
        /// </summary>
        public static Codec<TRaw, T> Switch<TRaw, T>()
        {
            return new Codec<TRaw, T>(
                Decoder<TRaw, T>.Zero,
                Encoder.Lose<TRaw, T>(Void.Halt)
            );
        }


        /// <summary>
        /// Create a decoder from the two functions.
        /// </summary>
        public static Codec<TRaw, T> Lift<TRaw, T>(Func<TRaw, T> decode, Func<T, TRaw> encode)
        {
            if (decode == null) throw new ArgumentNullException(nameof(decode));
            if (encode == null) throw new ArgumentNullException(nameof(encode));

            return new Codec<TRaw, T>(
                new Decoder<TRaw, T>((_, x) => decode(x)),
                new Encoder<TRaw, T>(encode)
            );
        }

    }

}