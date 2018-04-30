using System;
using System.Linq;

using DataBlocks.Prelude;
using JetBrains.Annotations;
using LanguageExt;

namespace DataBlocks.Core
{

    public sealed class Decoder<TRaw, T>
    {

        [NotNull] public readonly string Id;
        [NotNull] public readonly Func<string, TRaw, Either<DecoderErrors, T>> Run;

        public Decoder([NotNull] Func<string, TRaw, Either<DecoderErrors, T>> run, [CanBeNull] string id = null)
        {
            this.Run = run == null ? throw new ArgumentNullException(nameof(run)) : run;
            this.Id = id ?? string.Empty;
        }

        public static Decoder<TRaw, T> Return(Either<DecoderErrors, T> x)
        {
            return new Decoder<TRaw, T>((i, _) => x);
        }

        public static Decoder<TRaw, T> Zero => Decoder<TRaw, T>.Return(DecoderErrors.Zero);

        public Either<DecoderErrors, T> Decode([NotNull] TRaw rawData)
        {
            if (rawData == null) throw new ArgumentNullException(nameof(rawData));
            return this.Run(this.Id, rawData);
        }

        public Decoder<TRaw, T> SetId([NotNull] string id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));

            return new Decoder<TRaw, T>(this.Run, this.Id);
        }


    }

}