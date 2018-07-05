using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    public static class RobImplementation
    {
        public static int Rob(int[] nums)
        {
            return Calculate(nums.Length - 1, nums);
        }

        private static int Calculate(int n, int[] nums)
        {
            if (n < 0)
            {
                return 0;
            }

            if (n == 1)
            {
                return Math.Max(nums[0], nums[1]);
            }
            if (n == 0)
            {
                return nums[0];
            }

            return Math.Max(nums[n] + Calculate(n - 2, nums), nums[n - 1] + Calculate(n - 3, nums));
        }
    }
}
