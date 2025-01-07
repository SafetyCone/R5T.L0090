using System;


namespace R5T.L0090.T000
{
    public class EqualityComparerOperator : IEqualityComparerOperator
    {
        #region Infrastructure

        public static IEqualityComparerOperator Instance { get; } = new EqualityComparerOperator();


        private EqualityComparerOperator()
        {
        }

        #endregion
    }
}
