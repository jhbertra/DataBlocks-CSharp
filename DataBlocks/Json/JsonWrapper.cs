using DataBlocks.Prelude;
using Newtonsoft.Json.Linq;

namespace DataBlocks.Json
{

  public struct JsonWrapper : IMonoid<JsonWrapper>
  {
    public JsonWrapper(JToken value)
    {
      this.Value = value;
    }

    public readonly JToken Value;

    public JsonWrapper Zero => new JsonWrapper(new JObject());

    public JsonWrapper Append(JsonWrapper b)
    {
      var newObj = new JObject();
      if (this.Value is JObject o1 && b.Value is JObject o2)
      {
        newObj.Merge(o1);
        newObj.Merge(o2, new JsonMergeSettings { MergeArrayHandling = MergeArrayHandling.Union });
      }
      else if (this.Value is JObject thisO)
      {
        newObj.Merge(thisO);
        newObj.Add(newObj.Count.ToString(), b.Value);
      }
      else if (b.Value is JObject oB)
      {
        newObj.Merge(oB);
        newObj.Add(newObj.Count.ToString(), this.Value);
      }
      else
      {
        newObj.Add("1", this.Value);
        newObj.Add("2", b.Value);
      }
      return newObj;
    }

    public static implicit operator JsonWrapper(JToken t) => new JsonWrapper(t);

    public static implicit operator JToken(JsonWrapper json) => json.Value;
  }

}