using System;

namespace Solutions
{
    public class MinAvgTwoSlice
    {
        public int solution(int[] A)
        {
            int minIndex = 0;
            double min = Double.MaxValue;

            for (int i = 0; i < A.Length - 1; i++)
            {
                if (((A[i] + A[i+1]) / 2.0) < min)
                {
                    minIndex = i;
                    min = (A[i] + A[i + 1]) / 2.0;
                }

                if (i < A.Length - 2 &&  (((A[i] + A[i + 1] + A[i+2]) / 3.0) < min))
                {
                    minIndex = i;
                    min = (A[i] + A[i + 1] + A[i+2]) / 3.0;
                }

            }
            return minIndex;
        }
    }
}
