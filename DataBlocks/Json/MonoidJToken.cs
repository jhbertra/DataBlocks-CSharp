using System;
using System.Linq;
using JetBrains.Annotations;

using LanguageExt.TypeClasses;

using Newtonsoft.Json.Linq;

namespace DataBlocks.Json
{

    public static class JsonUtil
    {

        /// <summary>
        /// Append to pieces of JSON data together.
        /// </summary>
        [NotNull]
        public static JToken Append([NotNull] JToken x, [NotNull] JToken y)
        {
            if (x == null) throw new ArgumentNullException(nameof(x));
            if (y == null) throw new ArgumentNullException(nameof(y));
            
            if (x.Type == JTokenType.Undefined) return y;
            else if (y.Type == JTokenType.Undefined) return x;
            else if (x is JArray a1 && y is JArray a2) return new JArray(a1.Append(a2));
            else if (x is JArray a3 && y is JValue) return new JArray(a3.Append(new[] { y }));
            else if (x is JValue && y is JArray a4) return new JArray(new[] { y }.Append(a4));
            else if (x is JObject o1 && y is JObject o2)
            {
                var newObj = (JObject)o1.DeepClone();
                newObj.Merge(o2, new JsonMergeSettings { MergeArrayHandling = MergeArrayHandling.Replace, MergeNullValueHandling = MergeNullValueHandling.Merge });
                return newObj;
            }
            else if (x is JObject o3)
            {
                var newObj = (JObject)o3.DeepClone();
                newObj.Add(Enumerable.Range(0, int.MaxValue).First(i => !newObj.ContainsKey(i.ToString())).ToString(), y);
                return newObj;
            }
            else if (y is JObject o4)
            {
                var newObj = (JObject)o4.DeepClone();
                newObj.Add(Enumerable.Range(0, int.MaxValue).First(i => !newObj.ContainsKey(i.ToString())).ToString(), x);
                return newObj;
            }
            else
            {
                return new JArray { x, y };
            }
        }


        /// <summary>
        /// Create a piece of empty JSON data (undefined).
        /// </summary>
        [NotNull]
        public static JToken Empty => JValue.CreateUndefined();

    }

}