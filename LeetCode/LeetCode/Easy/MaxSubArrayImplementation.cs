using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    public static class MaxSubArrayImplementation
    {
        public static int MaxSubArray(int[] nums)
        {
            int result = int.MinValue;
            int previousMax = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                if (previousMax + nums[i] > result)
                {
                    result = previousMax + nums[i];
                }

                if (previousMax + nums[i] > 0)
                {
                    previousMax = previousMax + nums[i];
                }
                else
                {
                    previousMax = 0;
                }
            }

            return result;
        }
    }
}
