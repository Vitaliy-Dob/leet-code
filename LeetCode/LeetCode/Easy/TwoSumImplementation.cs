using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    public static class TwoSumImplementation
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            var result = new int[2];
            var dict = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                if (dict.TryGetValue(nums[i], out var j))
                {
                    result[0] = j;
                    result[1] = i;
                    break;
                }

                dict[target - nums[i]] = i;
            }

            return result;
        }
    }
}