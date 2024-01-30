using System;

using R5T.T0142;


namespace R5T.L0090.T000
{
    /// <summary>
    /// Tests two instances for equality.
    /// Separate from <see cref="System.Collections.Generic.IEqualityComparer{T}"/>,
    /// this type does not require defining the <see cref="System.Collections.Generic.IEqualityComparer{T}.GetHashCode(T)"/> method,
    /// just the <see cref="System.Collections.Generic.IEqualityComparer{T}.Equals(T, T)"/> method.
    /// </summary>
    [UtilityTypeMarker]
    public interface IEqualityComparer<in T>
    {
        bool Equals(T x, T y);
    }
}
