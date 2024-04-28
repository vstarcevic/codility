namespace Solutions
{
    public class PermMissingElem
    {
        public int solution(int[] A)
        {
            if (A.Length == 0) return 1;

            long N = A.Length + 1;

            long sum = ((1 + N) * N) / 2;

            for (int i = 0; i < A.Length; i++)
            {
                sum -= A[i];
            }

            return (int)sum;
        }
    }
}
