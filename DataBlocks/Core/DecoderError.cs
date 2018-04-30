using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

using JetBrains.Annotations;
using LanguageExt.TypeClasses;

namespace DataBlocks.Core
{

    /// <summary>
    /// A single error with an ID and a Message.
    /// </summary>
    [DebuggerDisplay("{Id}: {Message}")]
    public struct DecoderError
    {

        /***********************************************/
        /* Data
        /***********************************************/

        /// <summary>
        /// The format-specific ID of the data entity which exhibited the error.
        /// Used to locate the error in the raw data.
        /// </summary>
        [NotNull] public readonly string Id;

        /// <summary>
        /// A description of the error.
        /// </summary>
        [NotNull] public readonly string Message;



        /***********************************************/
        /* Constructors
        /***********************************************/

        /// <summary>
        /// Create a new DecoderError
        /// </summary>
        public DecoderError([NotNull] string id, [NotNull] string message)
        {
            this.Id = id == null ? throw new ArgumentNullException(nameof(id)) : id;
            this.Message = message == null ? throw new ArgumentNullException(nameof(message)) :  message;
        }


        /// <inheritdoc />
        public override string ToString()
        {
            return $"{{id: {this.Id}, message: {this.Message}}}";
        }

    }


    /// <summary>
    /// A collection of DecoderErrors.
    /// </summary>
    public struct DecoderErrors : IEnumerable<DecoderError>
    {

        /***********************************************/
        /* Data
        /***********************************************/

        /// <summary>
        /// The errors in this collection.
        /// </summary>
        [NotNull] public readonly IEnumerable<DecoderError> Errors;



        /***********************************************/
        /* Constructors
        /***********************************************/

        /// <summary>
        /// Create a new collection of DecoderErrors
        /// </summary>
        public DecoderErrors([NotNull] IEnumerable<DecoderError> errors)
        {
            this.Errors = errors == null ? throw new ArgumentNullException(nameof(errors)) : errors;
        }


        /// <summary>
        /// Create a new DecoderErrors with a single error
        /// </summary>
        public static DecoderErrors Single(string id, string message) => new DecoderErrors(Enumerable.Repeat(new DecoderError(id, message), 1));


        /// <summary>
        /// Create an empty collection of DecoderErrors
        /// </summary>
        public static DecoderErrors Empty => new DecoderErrors(Enumerable.Empty<DecoderError>());



        /***********************************************/
        /* Methods
        /***********************************************/

        /// <summary>
        /// Create a collection of DecoderErrors that contains the errors
        /// in this collection and the errors in b
        /// </summary>
        public DecoderErrors Append(DecoderErrors b)
        {
            return new DecoderErrors(this.Errors.Concat(b.Errors));
        }


        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            return obj is DecoderErrors d && d.Errors.SequenceEqual(this.Errors);
        }


        /// <inheritdoc />
        public override int GetHashCode()
        {
            return this.Errors.GetHashCode();
        }


        /// <inheritdoc />
        public override string ToString()
        {
            return $"[{string.Join(", ", this.Errors.Select(x => x.ToString()))}]";
        }


        /// <inheritdoc />
        public IEnumerator<DecoderError> GetEnumerator()
        {
            return this.Errors.GetEnumerator();
        }


        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }

}