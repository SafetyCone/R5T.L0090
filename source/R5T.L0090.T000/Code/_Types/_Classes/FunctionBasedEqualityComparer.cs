using System;

using R5T.T0142;


namespace R5T.L0090.T000
{
    /// <summary>
    /// An implementation of the simplified <see cref="IEqualityComparer{T}"/> interface that just wraps a function.
    /// </summary>
    [UtilityTypeMarker]
    public class FunctionBasedEqualityComparer<T> : IEqualityComparer<T>
    {
        private Func<T, T, bool> EqualityFunction { get; }


        public FunctionBasedEqualityComparer(
            Func<T, T, bool> equalityFunction)
        {
            this.EqualityFunction = equalityFunction;
        }

        public bool Equals(T x, T y)
        {
            var areEqual = this.EqualityFunction(x, y);
            return areEqual;
        }
    }
}
