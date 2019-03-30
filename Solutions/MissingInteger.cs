using System;

namespace Solutions
{
    public class MissingInteger
    {
        public int solution(int[] A)
        {
            int min = 1;

            Array.Sort(A);

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == min)
                {
                    min++;
                }
            }

            return min;
        }
    }
}
