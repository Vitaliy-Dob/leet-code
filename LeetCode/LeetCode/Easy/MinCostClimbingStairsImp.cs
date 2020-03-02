using System;

namespace LeetCode.Easy
{
    public static class MinCostClimbingStairsImp
    {
        public static int MinCostClimbingStairs(int[] cost)
        {
            var prevStepped = 0;
            var prevNotStepped = 0;

            for (var i = 0; i < cost.Length; i++)
            {
                var temp = prevStepped;
                prevStepped = cost[i] + Math.Min(prevStepped, prevNotStepped);
                prevNotStepped = temp;
            }

            return Math.Min(prevStepped, prevNotStepped);
        }
    }
}