using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Medium
{
    public static class GroupAnagramsImplementation
    {
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var dict = new Dictionary<string, IList<string>>();

            for (var i = 0; i < strs.Length; i++)
            {
                var key = Transform(strs[i].ToCharArray());
                IList<string> list;
                if (dict.TryGetValue(key, out list))
                {
                    list.Add(strs[i]);
                }
                else
                {
                    list = new List<string>{
                        strs[i]
                    };
                    dict.Add(key, list);
                }
            }

            return dict.Values.ToList();
        }

        public static string Transform(char[] chars)
        {
            return new string(chars.OrderBy(x => x).ToArray());
        }
    }

}