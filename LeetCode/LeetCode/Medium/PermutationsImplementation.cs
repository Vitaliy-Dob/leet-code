using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Medium
{
    public static class PermutationsImplementation
    {
        public static IList<IList<int>> Permute(int[] nums)
        {
            var result = new List<IList<int>>();
            Permute(result, nums, new List<int>());
            return result;
        }

        private static void Permute(List<IList<int>> result, int[] nums, List<int> permutation)
        {
            if(permutation.Count == nums.Length)
            {
                result.Add(permutation.ToArray());
                return;
            }
            for (var i = 0; i < nums.Length; i++)
            {
                if (permutation.Contains(nums[i]))
                    continue;
                permutation.Add(nums[i]);
                Permute(result, nums, permutation);
                permutation.RemoveAt(permutation.Count - 1);
            }
        }
    }
}
