using System.Collections.Generic;
using System.Linq;

namespace DataBlocks.Prelude
{

  public static class MonoidExtensions
  {

    public static T Concat<T>(this IEnumerable<T> monoids)
      where T : struct, IMonoid<T>
    {
      return monoids.Aggregate(default(T).Zero, (s, m) => s.Append(m));
    }

  }

}