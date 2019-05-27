using FluentAssertions;
using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Tests.Easy
{
    public class TwoSumTest
    {
        [Theory]
        [InlineData(new int[] { 11, 15, 2, 7 }, 9, new int[] { 2, 3 })]
        [InlineData(new int[] { 11, 15, 11, 2, 7 }, 9, new int[] { 3, 4 })]
        public void TwoSum_FromLeetCode_ShouldReturnIndices(int[] array, int target, int[] expectedResult)
        {
            var result = TwoSumImplementation.TwoSum(array, target);

            result.Should().Equal(expectedResult);
        }
    }
}
