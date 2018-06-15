using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    public static class FindDisappearedNumbersImplementation
    {
        public static IList<int> FindDisappearedNumbers(int[] nums)
        {
            var result = new List<int>();

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[Math.Abs(nums[i]) - 1] > 0)
                    nums[Math.Abs(nums[i]) - 1] = nums[Math.Abs(nums[i]) - 1] * -1;
            }

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                    result.Add(i + 1);
            }

            return result;
        }
    }
}
