using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Medium
{
    public static class CountSubstringsImplementation
    {
        public static int CountSubstrings(string s)
        {
            var matrix = new int[s.Length, s.Length];
            var result = 0;

            for (var i = 0; i < s.Length; i++)
            {
                for (var j = 0; j <= i; j++)
                {
                    if (s[i] == s[j] && (i - j < 3 || matrix[i - 1, j + 1] == 1))
                    {
                        result++;
                        matrix[i, j] = 1;
                    }
                }
            }

            return result;
        }
    }
}
