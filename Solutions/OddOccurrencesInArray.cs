using System.Collections.Generic;

namespace Solutions
{
    public class OddOccurrencesInArray
    {
        public int solution(int[] A)
        {
            HashSet<int> set = new HashSet<int>();

            for (int i = 0; i < A.Length; i++)
            {
                if (!set.Contains(A[i]))
                {
                    set.Add(A[i]);
                }
                else
                {
                    set.Remove(A[i]);
                }

            }

            foreach (var res in set)
            {
                return res;
            }

            return 0;

        }
    }
}
