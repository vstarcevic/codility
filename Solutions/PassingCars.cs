namespace Solutions
{
    public class PassingCars
    {
        public int solution(int[] A)
        {
            int max = 1000000000;
            int zeros = 0;
            int ones = 0;
            long pairs = 0;

            for (int i =(A.Length - 1); i >= 0; i--)
            {
                if (A[i] == 1)
                {
                    ones++;
                }
                else
                {
                    pairs += ones;
                    zeros++;
                }
            }

            if (pairs > max) pairs = -1;

            return (int)pairs;

        }
    }
}
