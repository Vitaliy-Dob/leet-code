using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Tests.Easy
{
    public class MaxProfitTests
    {
        [Theory]
        [InlineData(new int[] { 7, 1, 5, 3, 6, 4 }, 5)]
        [InlineData(new int[] { 7, 6, 4, 3, 1 }, 0)]
        [InlineData(new int[] { 5 }, 0)]
        public void MaxProfit_Theory_ShouldFindMaxProfit(int[] input, int expected)
        {
            var result = MaxProfitImplementation.MaxProfit(input);

            Assert.Equal(expected, result);
        }
    }
}
