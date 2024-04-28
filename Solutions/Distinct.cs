using System;

namespace Solutions
{
    public class Distinct
    {
        public int solution(int[] A)
        {
            Array.Sort(A);
            int tmp = -1;
            int distinct = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] != tmp)
                { 
                    distinct += 1;
                    tmp = A[i];
                }
            }
            return distinct;
        }
            
    }
}
