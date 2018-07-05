using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Tests.Easy
{
    public class RobTests
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 1 }, 4)]
        [InlineData(new int[] { 2, 7, 9, 3, 1 }, 12)]
        public void Rob_Theory_ShouldReturnMaxMoney(int[] nums, int expectedResult)
        {
            var result = RobImplementation.Rob(nums);

            Assert.Equal(expectedResult, result);
        }
    }
}
