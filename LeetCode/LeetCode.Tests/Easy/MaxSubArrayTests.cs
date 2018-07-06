using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Easy
{
    public class MaxSubArrayTests
    {
        [Theory]
        [InlineData(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }, 6)]
        [InlineData(new int[] { -4, 6, -12 }, 6)]
        [InlineData(new int[] { 1, 2, -500, 8, 3 }, 11)]
        [InlineData(new int[] { -1 }, -1)]
        public void MaxSubArray_UseCaseFromLeetCode_ShouldReturnMaxSubArray(int[] data, int expectedResult)
        {
            var result = MaxSubArrayImplementation.MaxSubArray(data);

            Assert.Equal(expectedResult, result);
        }
    }
}
