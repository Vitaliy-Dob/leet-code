using System;
using System.Collections.Generic;

namespace LeetCode.Medium
{
    public static class TopKFrequentImplementation
    {
        public static IList<int> TopKFrequent(int[] nums, int k)
        {
            var dict = new Dictionary<int, int>();
            var bucket = new List<int>[nums.Length];
            var result = new List<int>();

            for (var i = 0; i < nums.Length; i++)
            {
                if (!dict.TryAdd(nums[i], 1))
                {
                    dict[nums[i]] = dict[nums[i]] + 1;
                }
            }

            foreach (var val in dict)
            {
                if (bucket[val.Value - 1] == null)
                {
                    bucket[val.Value - 1] = new List<int>{
                        val.Key
                    };
                }
                else
                {
                    bucket[val.Value - 1].Add(val.Key);
                }
            }

            for (var i = nums.Length - 1; i >= 0 && result.Count < k; i--)
            {
                if (bucket[i] != null)
                    result.AddRange(bucket[i]);
            }

            return result;
        }
    }

}