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

            int left = 0, right = 0, length = p.Length - 1, count = dict.Count;

            for (; right < s.Length; right++)
            {
                if (dict.ContainsKey(s[right]))
                {
                    dict[s[right]] = --dict[s[right]];
                    if (dict[s[right]] == 0)
                        count--;
                }

                if (right - left == length)
                {
                    if (count == 0)
                        result.Add(left);

                    if (dict.ContainsKey(s[left]))
                    {
                        dict[s[left]] = ++dict[s[left]];
                        if (dict[s[left]] == 1)
                            count++;
                    }

                    left++;
                }
            }

            return result;
        }
    }
}
