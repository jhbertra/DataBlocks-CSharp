using System;
using System.Collections.Generic;
using System.Linq;

using DataBlocks.Prelude;
using JetBrains.Annotations;
using LanguageExt.TypeClasses;

namespace DataBlocks.Core
{

    public struct DecoderError
    {

        [NotNull] public readonly string Id;
        [NotNull] public readonly string Message;

        public DecoderError([NotNull] string id, [NotNull] string message)
        {
            this.Id = id == null ? id : throw new ArgumentNullException(nameof(id));
            this.Message = message == null ? message : throw new ArgumentNullException(nameof(message));
        }

        public override string ToString()
        {
            return $"{{id: {this.Id}, message: {this.Message}}}";
        }

    }

    public struct DecoderErrors
    {

        public static DecoderErrors Single(string id, string message) => new DecoderErrors(new[] { new DecoderError(id, message) });

        public DecoderErrors([NotNull] IEnumerable<DecoderError> errors)
        {
            this.Errors = errors == null ? errors : throw new ArgumentNullException(nameof(errors));
        }

        public readonly IEnumerable<DecoderError> Errors;

        public static DecoderErrors Zero => new DecoderErrors(Enumerable.Empty<DecoderError>());

        public DecoderErrors Append(DecoderErrors b)
        {
            return new DecoderErrors(this.Errors.Concat(b.Errors));
        }

        public override string ToString()
        {
            return $"[{string.Join(", ", this.Errors.Select(x => x.ToString()))}]";
        }

    }

}