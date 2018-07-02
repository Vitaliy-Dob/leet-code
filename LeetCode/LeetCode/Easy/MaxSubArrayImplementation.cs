using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    public static class MaxSubArrayImplementation
    {
        public static int MaxSubArray(int[] nums)
        {
            var result = int.MinValue;

            for (var i = 0; i < nums.Length; i++)
            {
                var temp = nums[i];
                result = Math.Max(temp, result);

                for (var j = i + 1; j < nums.Length; j++)
                {
                    temp = temp + nums[j];
                    result = Math.Max(temp, result);
                }
            }

            return result;
        }
    }
}
