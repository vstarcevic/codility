using System;
using System.Collections.Generic;
using System.Text;

namespace Solutions
{
    public class Brackets
    {
        public int solution(string S)
        {
            Stack<char> stack = new Stack<char>();
            char[] chars = S.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == '(' || chars[i] == '{' || chars[i] == '[')
                {
                    stack.Push(chars[i]);
                }
                else if (chars[i] == ')')
                {
                    if (stack.Count > 0 && stack.Peek() == '(')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        stack.Push(chars[i]);
                    }
                }
                else if (chars[i] == '}')
                {
                    if (stack.Count > 0 && stack.Peek() == '{')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        stack.Push(chars[i]);
                    }
                }
                else if (chars[i] == ']')
                {
                    if (stack.Count > 0 && stack.Peek() == '[')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        stack.Push(chars[i]);
                    }
                }

            }

            if (stack.Count == 0) return 1;

            return 0;
             
        }
    }
}
