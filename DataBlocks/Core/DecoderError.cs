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

      public override string ToString()
      {
        return $"{{id: {this.Id}, message: {this.Message}}}";
      }
    }
  }
}