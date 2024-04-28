using System.Collections.Generic;

namespace Solutions
{
    public class FrogRiverOne
    {
        public int solution(int X, int[] A)
        {
            HashSet<int> set = new HashSet<int>();

            for (int i = 1; i <= X; i++)
            {
                set.Add(i);
            }

            for (int i = 0; i < A.Length; i++)
            {
                if (set.Contains(A[i]))
                {
                    set.Remove(A[i]);
                }

                if (set.Count == 0)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
