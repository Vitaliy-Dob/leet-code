using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    public static class ValidParentheses
    {
        private const string openingChars = "[{(";
        private static readonly Dictionary<char, char> brackets = new Dictionary<char, char>
        {
            {'[', ']' },
            {'{', '}' },
            {'(', ')' }
        };


        public static bool IsValid(string s)
        {
            if (string.IsNullOrEmpty(s))
                return true;

            var opened = new Stack<char>();

            for (var i = 0; i < s.Length; i++)
            {
                if (IsOpening(s[i]))
                {
                    opened.Push(s[i]);
                    continue;
                }

                if (opened.Count == 0)
                    return false;

                var c = opened.Pop();

                if (brackets[c] != s[i])
                    return false;
            }

            return opened.Count == 0;
        }

        private static bool IsOpening(char c)
        {
            return openingChars.IndexOf(c) != -1;
        }
    }
}
