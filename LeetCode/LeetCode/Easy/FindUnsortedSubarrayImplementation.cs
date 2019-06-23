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
            if (nums.Length == 0)
                return 0;

            var left = 0;
            var right = 0;
            var prevMax = nums[0];
            bool wasFound = false;

            for (var i = 1; i < nums.Length; i++)
            {
                if (nums[i] < prevMax)
                {
                    wasFound = true;
                    right = i;

                    for (; left >= 0; left--)
                    {
                        if (nums[left] <= nums[i])
                        {
                            break;
                        }
                    }
                }

                if (!wasFound)
                {
                    right = i;
                    left = i;
                }
                prevMax = Math.Max(prevMax, nums[i]);
            }

            if (wasFound)
            {
                return right - left;
            }

            return 0;
        }
    }
}
