using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    public static class RobImplementation
    {
        public static int Rob(int[] nums)
        {
            return Calculate(0, nums);
        }

        private static int Calculate(int n, int[] nums)
        {
            if (n > nums.Length - 1)
                return 0;

            return Math.Max(nums[n] + Calculate(n + 2, nums), Calculate(n + 1, nums));
        }
    }
}
