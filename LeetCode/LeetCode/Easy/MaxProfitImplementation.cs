using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    public static class MaxProfitImplementation
    {
        public static int MaxProfit(int[] prices)
        {
            int result = 0;

            for (var i = 0; i < prices.Length; i++)
            {
                for (var j = i + 1; j < prices.Length; j++)
                {
                    int r = prices[i] - prices[j];
                    if (r < 0)
                    {
                        result = Math.Max(result, Math.Abs(r));
                    }
                }
            }

            return result;
        }
    }
}
