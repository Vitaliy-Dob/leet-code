using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SingleNumber.Tests
{
    public class SingleNumberTests
    {
        [Theory]
        [InlineData(new int[] { 2, 2, 1 }, 1)]
        [InlineData(new int[] { 9 }, 9)]
        [InlineData(new int[] { 1, 2, 3, 2, 5, 4, 5, 3, 1 }, 4)]
        public void SingleNumber_Theory_ShouldFindSingleNumber(int[] nums, int expectedResult)
        {
            var result = SingleNumberImplementation.SingleNumber(nums);

            Assert.Equal(expectedResult, result);
        }
    }
}
