using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    public static class TwoSumImplementation
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                var numberToFind = target - nums[i];
                if (dict.TryGetValue(numberToFind, out int j))
                    return new int[] { j, i };
                else
                {
                    if (!dict.ContainsKey(nums[i]))
                    {
                        dict.Add(nums[i], i);
                    }
                }
            }

            throw new ArgumentException();
        }
    }
}
