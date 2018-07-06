using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    public static class MaxSubArrayImplementation
    {
        public static int MaxSubArray(int[] nums)
        {
            int result = nums[0];
            int prev = nums[0];

            for (var i = 1; i < nums.Length; i++)
            {
                prev = prev + nums[i] > nums[i] ? prev + nums[i] : nums[i];
                result = prev > result ? prev : result;
            }

            return result;
        }
    }
}
