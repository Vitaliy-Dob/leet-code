using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    public static class MaxProfitImplementation
    {
        public static int MaxProfit(int[] prices)
        {
            int profit = 0;
            int miValue = int.MaxValue;

            for (var i = 0; i < prices.Length; i++)
            {
                if (prices[i] < miValue)
                {
                    miValue = prices[i];
                }
                else if (prices[i] - miValue > profit)
                {
                    profit = prices[i] - miValue;
                }
            }

            return profit;
        }
    }
}
