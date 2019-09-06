using System;
using System.Collections.Generic;

namespace LeetCode.Medium
{
    public static class SubsetsImplementation
    {
        public static IList<IList<int>> Subsets(int[] nums)
        {
            var result = new List<IList<int>>();
            Generate(result, new List<int>(), nums, 0);

            return result;
        }

        private static void Generate(List<IList<int>> result, List<int> subresult, int[] nums, int i)
        {
            result.Add(subresult.ToArray());

            for (; i < nums.Length; i++)
            {
                subresult.Add(nums[i]);
                Generate(result, subresult, nums, i + 1);
                subresult.RemoveAt(subresult.Count - 1);
            }
        }
    }
}