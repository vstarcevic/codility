namespace Solutions
{
    public class GenomicRangeQuery
    {
        public int[] solution(string S, int[] P, int[] Q)
        {
            int[,] dna = new int[S.Length, 4];
            char[] sdna = S.ToCharArray();
            int[] result = new int[P.Length];

            // first fill the table for prefix sum
            // for "CAGCCTA" table is:
            // == A C G T
            // 0) 0 1 0 0
            // 1) 1 1 0 0
            // 2) 1 1 1 0
            // 3) 1 2 1 0
            // 4) 1 3 1 0
            // 5) 2 3 1 1
            // 6) 3 3 1 1
            // for each letter we add 1 on existing value from previous row, 
            // and add values from previous row for other letters
            // it's easy to have CHANGE for given P[x] and Q[x]
            // just subtract values to get change for given letter
            // e.g. from 5th to 6th step we have 3 - 2, 3 - 3, 1 - 1, 1 -1.
            // it is obvious that A has changed so, the letter that occurs in this step is A
            // but from step 4 to 6, we have change on A and T, but since we are looking 
            // for smallest value, we confirm that substring from 4-6 has A
            for (int i = 0; i < S.Length; i++)
            {
                if (sdna[i] == 'A')
                {
                    dna[i, 0] = i - 1 >= 0 ? dna[i - 1, 0] + 1 : 1;
                    dna[i, 1] = i - 1 >= 0 ? dna[i - 1, 1] : 0;
                    dna[i, 2] = i - 1 >= 0 ? dna[i - 1, 2] : 0;
                    dna[i, 3] = i - 1 >= 0 ? dna[i - 1, 3] : 0;
                }
                else if (sdna[i] == 'C')
                {
                    dna[i, 0] = i - 1 >= 0 ? dna[i - 1, 0] : 0;
                    dna[i, 1] = i - 1 >= 0 ? dna[i - 1, 1] + 1 : 1;
                    dna[i, 2] = i - 1 >= 0 ? dna[i - 1, 2] : 0;
                    dna[i, 3] = i - 1 >= 0 ? dna[i - 1, 3] : 0;
                }
                else if (sdna[i] == 'G')
                {
                    dna[i, 0] = i - 1 >= 0 ? dna[i - 1, 0] : 0;
                    dna[i, 1] = i - 1 >= 0 ? dna[i - 1, 1] : 0;
                    dna[i, 2] = i - 1 >= 0 ? dna[i - 1, 2] + 1 : 1;
                    dna[i, 3] = i - 1 >= 0 ? dna[i - 1, 3] : 0;
                }
                else
                {
                    dna[i, 0] = i - 1 >= 0 ? dna[i - 1, 0] : 0;
                    dna[i, 1] = i - 1 >= 0 ? dna[i - 1, 1] : 0;
                    dna[i, 2] = i - 1 >= 0 ? dna[i - 1, 2] : 0;
                    dna[i, 3] = i - 1 >= 0 ? dna[i - 1, 3] + 1 : 1;
                }
            }

            // second, get differences from the table
            for (int i = 0; i < P.Length; i++)
            {
                int from = P[i];
                int to = Q[i]; 

                for (int j = 0; j < 4; j++)
                {
                    int sub = 0;
                    if (from - 1 >= 0) sub = dna[from - 1,j];

                    if (dna[to, j] - sub > 0)
                    {
                        result[i] = j+1;
                        break;
                    }
                }
            }

            return result;
        }
    }
}
