using System;

namespace Solutions
{
    public class BinaryGap
    {
        public int solution(int N)
        {
            var binary = Convert.ToString(N, 2).ToCharArray();
            int maxGap = 0;
            int tmp = 0;

            if (binary.Length > 0 && binary[0] == '0') return 0;

            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] == '1')
                {
                    if (tmp > maxGap)
                    {
                        maxGap = tmp;
                    }
                    tmp = 0;
                }
                else
                {
                    tmp++;
                }
            }

            return maxGap;
        }

    }
}