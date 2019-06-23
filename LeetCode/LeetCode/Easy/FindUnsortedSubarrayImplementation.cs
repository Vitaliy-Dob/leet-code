using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Easy
{
    public static class FindUnsortedSubarrayImplementation
    {
        public static int FindUnsortedSubarray(int[] nums)
        {
            var left = -1;
            var right = -2;
            var min = nums[nums.Length - 1];
            var max = nums[0];

            for (var i = 1; i < nums.Length; i++)
            {
                max = Math.Max(max, nums[i]);
                min = Math.Min(min, nums[nums.Length - 1 - i]);
                if (nums[i] < max) right = i;
                if (nums[nums.Length - 1 - i] > min) left = nums.Length - 1 - i;
            }

            return right - left + 1;
        }
    }
}
