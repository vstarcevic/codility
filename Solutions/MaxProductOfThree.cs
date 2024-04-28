using System;

namespace Solutions
{
    public class MaxProductOfThree
    {
        public int solution(int[] A)
        {
            Array.Sort(A);

            var result1 = A[A.Length - 1] * A[A.Length - 2] * A[A.Length - 3];
            var result2 = A[0] * A[1] * A[A.Length - 1];
      
            return Math.Max(result1, result2);
        }
    }
}
