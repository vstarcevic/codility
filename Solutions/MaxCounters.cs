namespace Solutions
{
    public class MaxCounters
    {
        public int[] solution(int N, int[] A)
        {
            int[] counters = new int[N];

            int max = 0;
            int min = 0;

            for (int i = 0; i < A.Length; i++)
            { 
                if (A[i] > counters.Length)
                {
                    min = max;
                }
                else
                {
                    if (counters[A[i] - 1] < min)
                    {
                        counters[A[i] - 1] = min;
                    }

                    counters[A[i]-1] += 1;
                     
                    if (counters[A[i]-1] > max)
                    {
                        max = counters[A[i] - 1];
                    }
                }
            }
            for (int i = 0; i < counters.Length; i++)
            {
                if (counters[i] < min)
                    counters[i] = min;
            }
            return counters;
        }
    }
}
