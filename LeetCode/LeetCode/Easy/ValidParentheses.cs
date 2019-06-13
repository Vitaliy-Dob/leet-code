using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    public static class ValidParentheses
    {
        public static bool IsValid(string s)
        {
            if (string.IsNullOrEmpty(s))
                return true;

            var stack = new Stack<char>();

            for (var i = 0; i < s.Length; i++)
            {
                if (s[i] == '[')
                {
                    stack.Push(']');
                    continue;
                }
                if (s[i] == '{')
                {
                    stack.Push('}');
                    continue;
                }
                if (s[i] == '(')
                {
                    stack.Push(')');
                    continue;
                }

                if (stack.Count == 0 || stack.Pop() != s[i])
                    return false;
            }

            return stack.Count == 0;
        }
    }
}
