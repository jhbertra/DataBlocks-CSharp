using System;

using DataBlocks.Prelude;
using JetBrains.Annotations;
using LanguageExt;
using LanguageExt.TypeClasses;

namespace DataBlocks.Core
{

    public sealed class Codec<MonoidRaw, TRaw, TDecoder, TEncoder> where MonoidRaw : struct, Monoid<TRaw>
    {

        public Codec(Decoder<TRaw, TDecoder> decoder, Encoder<TRaw, TEncoder> encoder)
        {
            this.Decoder = decoder;
            this.Encoder = encoder;
        }

        public readonly Decoder<TRaw, TDecoder> Decoder;
        public readonly Encoder<TRaw, TEncoder> Encoder;

    }

    public sealed class Codec<TRaw, T>
    {

        public readonly Decoder<TRaw, T> Decoder;
        public readonly Encoder<TRaw, T> Encoder;

        public Codec(Decoder<TRaw, T> decoder, Encoder<TRaw, T> encoder)
        {
            this.Decoder = decoder;
            this.Encoder = encoder;
        }

        public Either<DecoderErrors, T> Decode(TRaw raw) => this.Decoder.Decode(raw);
        public TRaw Encode(T data) => this.Encoder.Encode(data);

        public Codec<TRaw, T> SetId([NotNull] string id) => new Codec<TRaw, T>(this.Decoder.SetId(id), this.Encoder);

    }

    public static class Codec
    {

        public static Codec<MonoidRaw, TRaw, Unit, T> BeginConstruction<MonoidRaw, TRaw, T>()
          where MonoidRaw : struct, Monoid<TRaw>
        {
            return new Codec<MonoidRaw, TRaw, Unit, T>(
                Decoder<TRaw, Unit>.Return(Unit.Default),
                Encoder.Conquer<MonoidRaw, TRaw, T>()
            );
        }

        public static Codec<TRaw, T> Switch<TRaw, T>()
        {
            return new Codec<TRaw, T>(
                Decoder<TRaw, T>.Zero,
                Encoder.Lose<TRaw, T>(Void.Halt)
            );
        }

        public static Codec<TRaw, T> Lift<TRaw, T>(Func<TRaw, T> decode, Func<T, TRaw> encode)
        {
            return new Codec<TRaw, T>(
                new Decoder<TRaw, T>((_, x) => decode(x)),
                new Encoder<TRaw, T>(encode)
            );
        }

    }

}