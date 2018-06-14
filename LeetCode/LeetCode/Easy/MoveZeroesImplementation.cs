using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    public static class MoveZeroesImplementation
    {
        public static void MoveZeroes(int[] nums)
        {
            int prevNotZeros = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {                    
                    int temp = nums[prevNotZeros];
                    nums[prevNotZeros] = nums[i];
                    nums[i] = temp;
                    prevNotZeros++;
                }
            }
        }
    }
}
