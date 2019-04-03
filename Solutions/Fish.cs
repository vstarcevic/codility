using System;
using System.Collections.Generic;
using System.Text;

namespace Solutions
{
    public class Fish
    {

        /// <summary>
        /// N ^ 2, without stack
        /// New solution will be added
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public int solution(int[] A, int[] B)
        {

            int alivefishes = A.Length;
            int fishComingIndex = -1;

            for (int i = 0; i < A.Length; i++)
            {

                if (B[i] == -1)
                {
                    continue;
                }
                else if (B[i] == 1)
                {
                    fishComingIndex = i;
                }
                else
                {
                    if (fishComingIndex >= 0)
                    {
                        alivefishes--;
                        if (A[fishComingIndex] > A[i])
                        {
                            B[i] = -1;
                        }
                        else
                        {
                            B[fishComingIndex] = -1;
                            fishComingIndex = -1;
                            i = fishComingIndex;
                        }
                    }
                }
            }
            return alivefishes;
        }
    }
}
