using System.Collections.Generic;
using System.Linq;

using DataBlocks.Prelude;

namespace DataBlocks.Core
{

  public struct DecoderError : IMonoid<DecoderError>
  {

    public static DecoderError Single(string id, string message) => new DecoderError(new[] { new Data(id, message) });

    public DecoderError(IEnumerable<Data> errors)
    {
      this.Errors = errors;
    }

    public readonly IEnumerable<Data> Errors;

    public DecoderError Zero => new DecoderError(Enumerable.Empty<Data>());

    public DecoderError Append(DecoderError b)
    {
      return new DecoderError(this.Errors.Concat(b.Errors));
    }

    public override bool Equals(object obj)
    {
      return obj is DecoderError other && this == other;
    }

    public static bool operator ==(DecoderError a, DecoderError b)
    {
      return a.Errors.SequenceEqual(b.Errors);
    }

    public static bool operator !=(DecoderError a, DecoderError b)
    {
      return !(a == b);
    }

    public override int GetHashCode()
    {
      return this.Errors.GetHashCode();
    }

    public override string ToString()
    {
      return $"[{string.Join(", ", this.Errors.Select(x => x.ToString()))}]";
    }

    public struct Data
    {
      public Data(string id, string message)
      {
        this.Id = id;
        this.Message = message;
      }

      public readonly string Id;
      public readonly string Message;

      public override bool Equals(object obj)
      {
        return obj is Data other && this == other;
      }

      public static bool operator ==(Data a, Data b)
      {
        return a.Id == b.Id
          && a.Message == b.Message;
      }

      public static bool operator !=(Data a, Data b)
      {
        return !(a == b);
      }

      public override int GetHashCode()
      {
        return this.Id.GetHashCode() ^ (this.Message.GetHashCode() * 397);
      }

      public override string ToString()
      {
        return $"{{id: {this.Id}, message: {this.Message}}}";
      }
    }
  }
}