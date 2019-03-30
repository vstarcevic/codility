namespace Solutions
{
    public class CyclicRotation
    {
        public int[] solution(int [] A, int K)
        {
            if (A.Length == 0) return new int[] { };

            int[] newArray = new int[A.Length];

            K = K % A.Length;

            for (int i = 0; i < A.Length; i++)
            {

                var position = (i + K) % A.Length;

                newArray[position] = A[i];
            }

            return newArray;

        }
    }
}
