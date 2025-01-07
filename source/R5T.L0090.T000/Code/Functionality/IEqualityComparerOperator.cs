using System;

using R5T.T0132;

using Framework = System.Collections.Generic;


namespace R5T.L0090.T000
{
    [FunctionalityMarker]
    public partial interface IEqualityComparerOperator : IFunctionalityMarker
    {
        public EqualityComparerBasedEqualityComparer<T> From<T>(
            Framework.IEqualityComparer<T> equalityComparer)
            => EqualityComparerBasedEqualityComparer<T>.From(equalityComparer);

        public FunctionBasedEqualityComparer<T[]> From_ToArray<T>(IEqualityComparer<T> instance_equalityComparer)
        {
            var output = new FunctionBasedEqualityComparer<T[]>((x, y) =>
            {
                var output = Instances.ArrayOperator.Are_Equal(x, y, instance_equalityComparer.Equals);
                return output;
            });

            return output;
        }

        public FunctionBasedEqualityComparer<T> From_Function<T>(Func<T, T, bool> equalityFunction)
            => new FunctionBasedEqualityComparer<T>(equalityFunction);
    }
}
