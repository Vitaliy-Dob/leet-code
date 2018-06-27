using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Tests.Easy
{
    public class ClimbStairsTests
    {
        [Theory]
        [InlineData(2, 2)]
        [InlineData(3, 3)]
        public void ClimbStairs_Theory_ShouldReturnWaystoClimbCount(int input, int expectedResult)
        {
            var result = ClimbStairsImplementation.ClimbStairs(input);

            Assert.Equal(expectedResult, result);
        }
    }
}
