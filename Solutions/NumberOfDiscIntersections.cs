
namespace Solutions
{
    public class NumberOfDiscIntersections
    {
        /// <summary>
        /// Please note that this is not optimal approach
        /// It needs to change to to N * Log N, now it's N^2
        /// It will be changed in next iteration
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public int solution(int[] A)
        {
            int n = A.Length;
            int numIntersects = 0;

            for (long i = 0; i < n - 1; i++)
            {
                long start1 = i - A[i];
                long end1 = i + A[i];

                for (long j = i + 1; j < n; j++)
                {
                    long start2 = j - A[j];
                    long end2 = j + A[j];

                    if (start1 <= end2 && start2 <= end1)
                    {
                        if (numIntersects > 10E6)
                        {
                            numIntersects++;
                        }
                        else
                        {
                            numIntersects++;
                        }
                    }
                }
            }
            return numIntersects;
        }
    }
}
