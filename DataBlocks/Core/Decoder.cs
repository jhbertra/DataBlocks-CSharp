using System;
using System.Linq;

using JetBrains.Annotations;
using LanguageExt;

namespace DataBlocks.Core
{

    /// <summary>
    /// Attempts to convert raw data into another format.
    /// </summary>
    public sealed class Decoder<TRaw, T>
    {

        /***********************************************/
        /* Data
        /***********************************************/

        /// <summary>
        /// The id of this decoder. Used when reporting errors in the
        /// raw data to help locate the invalid data.
        /// </summary>
        [NotNull] public readonly string Id;


        /// <summary>
        /// The delegate that performs the decoding.
        /// </summary>
        [NotNull] public readonly Func<string, TRaw, Either<DecoderErrors, T>> Run;



        /***********************************************/
        /* Constructors
        /***********************************************/

        /// <summary>
        /// Create a new Decoder
        /// </summary>
        public Decoder([NotNull] Func<string, TRaw, Either<DecoderErrors, T>> run, [CanBeNull] string id = null)
        {
            this.Run = run == null ? throw new ArgumentNullException(nameof(run)) : run;
            this.Id = id ?? string.Empty;
        }


        /// <summary>
        /// Create a Decoder that returns a predetermined result.
        /// </summary>
        public static Decoder<TRaw, T> Return(Either<DecoderErrors, T> x)
        {
            return new Decoder<TRaw, T>((i, _) => x);
        }


        /// <summary>
        /// A Decoder that fails with an empty error collection.
        /// </summary>
        public static Decoder<TRaw, T> Zero => Decoder<TRaw, T>.Return(DecoderErrors.Empty);



        /***********************************************/
        /* Methods
        /***********************************************/

        /// <summary>
        /// Attempt to decode the raw data.
        /// </summary>
        public Either<DecoderErrors, T> Decode([NotNull] TRaw rawData)
        {
            if (rawData == null) throw new ArgumentNullException(nameof(rawData));
            return this.Run(this.Id, rawData);
        }


        /// <summary>
        /// Create a copy of this Decoder with the given ID.
        /// </summary>
        public Decoder<TRaw, T> SetId([NotNull] string id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));

            return new Decoder<TRaw, T>(this.Run, this.Id);
        }


    }

}