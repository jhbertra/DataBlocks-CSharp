using System;
using JetBrains.Annotations;

namespace DataBlocks
{

    public sealed class Void
    {

        private Void() { }

        public static T Absurd<T>([NotNull] Void v)
        {
            if (v == null) throw new ArgumentNullException(nameof(v));
            throw new InvalidOperationException("Code logically unreachable.");
        }

        public static Void Halt<T>(T t)
        {
            throw new InvalidOperationException("Function cannot logically return.");
        }

    }

}