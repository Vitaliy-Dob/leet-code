using System;
using System.Collections.Generic;
using System.Text;

namespace SingleNumber.Tests
{
    public static class SingleNumberImplementation
    {
        public static int SingleNumber(int[] nums)
        {
            var result = nums[0];

            for (var i = 1; i < nums.Length; i++)
            {
                result = result ^ nums[i];
            }

            return result;
        }
    }
}
