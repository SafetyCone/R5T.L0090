using System;

using R5T.T0142;

// Note: unable to alias the open generic type System.Collections.Generic.IEqualityComparer<T>, because C# does not allow aliasing open generic types.
// But we can alias the namespace.
using Framework = System.Collections.Generic;


namespace R5T.L0090.T000
{
    /// <summary>
    /// An implementation of the simplified <see cref="IEqualityComparer{T}"/> interface that just wraps an instance of the full <see cref="Framework.IEqualityComparer{T}"/>.
    /// </summary>
    [UtilityTypeMarker]
    public class EqualityComparerBasedEqualityComparer<T> : IEqualityComparer<T>
    {
        #region Static

        public static EqualityComparerBasedEqualityComparer<T> Default => new EqualityComparerBasedEqualityComparer<T>(
            Framework.EqualityComparer<T>.Default);


        public static EqualityComparerBasedEqualityComparer<T> From(
            Framework.IEqualityComparer<T> equalityComparer)
        {
            var output = new EqualityComparerBasedEqualityComparer<T>(equalityComparer);
            return output;
        }

        #endregion


        private Framework.IEqualityComparer<T> EqualityComparer { get; }


        public EqualityComparerBasedEqualityComparer(
            Framework.IEqualityComparer<T> equalityComparer)
        {
            this.EqualityComparer = equalityComparer;
        }

        public bool Equals(T x, T y)
        {
            var areEqual = this.EqualityComparer.Equals(x, y);
            return areEqual;
        }
    }
}
