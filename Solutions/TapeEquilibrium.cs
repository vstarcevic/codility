using System;

namespace Solutions
{
    public class TapeEquilibrium
    {
        public int solution (int[] A)
        {
            long sum = 0;
            long partialSum = 0;
            for (int i = 0; i < A.Length; i++)
                sum += A[i];

            long minSum = Int64.MaxValue;

            for (int i = 0; i < A.Length; i++)
            {
                partialSum += A[i];
                long result = Math.Abs(partialSum - (sum - partialSum));

                minSum = Math.Min(result, minSum);
            }

            return (int)minSum;

        }
    }
}
