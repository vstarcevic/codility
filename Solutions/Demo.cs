using System;
using System.Collections.Generic;
using System.Linq;

namespace Solutions
{
    public class Demo
    { 
        public string solution(int number)
        {
            List<char> numchars = number.ToString().ToCharArray().ToList();
            int counter = 0;
            numchars.Reverse();
             
            for (int i = 0; i < numchars.Count; i ++)
            {
                if (counter % 3 == 0 && counter != 0)
                {
                    numchars.Insert(i, ',');
                    counter = -1;
                }
                counter++;
            }

            numchars.Reverse();
            string s = new string(numchars.ToArray());

            return s;
        }

        public int solution2(int n)
        {
            int result = 0;

            for (int i = 1; i <= n; i++)
            {
                var digits = i.ToString().ToCharArray();

                for (int j = 0; j < digits.Length; j++)
                {
                    result += Int32.Parse(digits[j].ToString());
                }
            }

            return result;
        }
    }
}
