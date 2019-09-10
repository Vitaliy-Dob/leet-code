using System;

namespace LeetCode.Medium
{
    public static class FindDuplicateImplementation
    {
        public static int FindDuplicate(int[] nums)
        {
            var result = -1;

            for (var i = 0; i < nums.Length; i++)
            {
                var val = Math.Abs(nums[i]);
                if (nums[val - 1] < 0)
                {
                    result = val;
                    break;
                }

                nums[val - 1] = nums[val - 1] * -1;
            }

            return result;
        }
    }
}