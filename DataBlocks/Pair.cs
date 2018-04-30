using System;
using JetBrains.Annotations;

namespace DataBlocks
{

    /// <summary>
    /// Data type that contins two items.
    /// </summary>
    public struct Pair<T1, T2>
    {

        /// <summary>
        /// The first element of the pair.
        /// </summary>
        [NotNull] public readonly T1 _1;


        /// <summary>
        /// The second element of the pair.
        /// </summary>
        [NotNull] public readonly T2 _2;


        /// <summary>
        /// Create a new pair.
        /// </summary>
        public Pair([NotNull] T1 t1, [NotNull] T2 t2)
        {
            this._1 = t1 == null ? throw new ArgumentNullException(nameof(t1)) : t1;
            this._2 = t2 == null ? throw new ArgumentNullException(nameof(t2)) : t2;
        }

    }


    /// <summary>
    /// Utilities for creating Pairs
    /// </summary>
    public static class Pair
    {

        /// <summary>
        /// Create a pair from the arguments
        /// </summary>
        public static Pair<T1, T2> Create<T1, T2>(T1 t1, T2 t2)
        {
            return new Pair<T1, T2>(t1, t2);
        }

    }

}