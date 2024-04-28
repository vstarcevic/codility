using System.Collections.Generic;

namespace Solutions
{
    public class PermCheck
    {
        public int solution(int[] A)
        {
            HashSet<int> set = new HashSet<int>();

            for (int i = 0; i < A.Length; i++)
            {
                if ((A[i] > A.Length) || (set.Contains(A[i])))
                {
                    return 0;
                }
                else
                {
                    set.Add(A[i]);
                }
            }

            return 1;
        }
    }
}
