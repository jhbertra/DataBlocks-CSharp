using System;
using JetBrains.Annotations;

namespace DataBlocks
{

    /// <summary>
    /// The logically uninhabited datatype.
    /// </summary>
    public sealed class Void
    {

        private Void() { }


        /// <summary>
        /// Function which can be used to prove a situation cannot arise by
        /// contradiction.  Assume the function could be called. This implies
        /// that an instance of void would have to be created. Void is uninstantiable.
        /// The contradiction proves the function cannot be called, and therefore its
        /// execution path is absurd.
        /// </summary>
        public static T Absurd<T>([NotNull] Void v)
        {
            if (v == null) throw new ArgumentNullException(nameof(v));
            throw new InvalidOperationException("Code logically unreachable.");
        }


        /// <summary>
        /// Function which can be used to prove that a program will halt on a given execution
        /// path. Since Void is uninhabited, the function cannot return.
        /// </summary>
        public static Void Halt<T>(T t)
        {
            throw new InvalidOperationException("Function cannot logically return.");
        }

    }

}