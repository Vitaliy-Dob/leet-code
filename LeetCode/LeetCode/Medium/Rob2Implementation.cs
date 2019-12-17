using System;
using static System.Math;

namespace LeetCode.Medium
{
    public static class Rob2Implementation
    {
        public static int Rob2(int[] nums)
        {
            if (nums.Length == 1)
                return nums[0];
            return Math.Max(Rob(nums, 0, nums.Length - 1), Rob(nums, 1, nums.Length));
        }

        public static int Rob(int[] nums, int lo, int hi)
        {
            int robbed = 0;
            int notRobbed = 0;

            for (var i = lo; i < hi; i++)
            {
                var tempNotRobbed = notRobbed;
                notRobbed = Math.Max(robbed, notRobbed);
                robbed = tempNotRobbed + nums[i];
            }

            return Math.Max(robbed, notRobbed);
        }
    }
}