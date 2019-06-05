using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Easy
{
    public static class FindAnagramImplementation
    {
        public static IList<int> FindAnagrams(string s, string p)
        {
            var dict = new Dictionary<char, int>();
            var result = new List<int>();

            for (var i = 0; i < p.Length; i++)
            {
                dict[p[i]] = dict.GetValueOrDefault(p[i]) + 1;
            }

            int left = 0, right = 0, length = p.Length - 1;

            for (; right < s.Length; right++)
            {
                dict[s[right]] = dict.GetValueOrDefault(s[right]) - 1;

                if (right - left == length)
                {
                    if (dict.Values.All(x => x == 0))
                        result.Add(left);
                    dict[s[left]] = dict.GetValueOrDefault(s[left]) + 1;
                    left++;
                }
            }

            return result;
        }
    }
}
