using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    public static class RobImplementation
    {
        public static int Rob(int[] nums)
        {
            int robbed = 0;
            int notRobbed = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                var tempNotRobbe = notRobbed;
                notRobbed = Math.Max(robbed, notRobbed);
                robbed = tempNotRobbe + nums[i];
            }

            return Math.Max(robbed, notRobbed);
        }
    }
}
