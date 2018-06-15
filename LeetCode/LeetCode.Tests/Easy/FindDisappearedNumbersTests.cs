using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace LeetCode.Tests.Easy
{
    public class FindDisappearedNumbersTests
    {
        [Theory]
        [InlineData(new int[] { 4, 3, 2, 7, 8, 2, 3, 1 }, new int[] { 5, 6 })]
        [InlineData(new int[] { 1 }, new int[] { })]
        [InlineData(new int[] { 2, 2 }, new int[] { 1 })]
        [InlineData(new int[] { 1, 2, 3 }, new int[] { })]
        public void FindDisappearedNumbers_Theory_ShouldFindNumbers(int[] input, int[] expectedResult)
        {
            var result = FindDisappearedNumbersImplementation.FindDisappearedNumbers(input);

            Assert.True(Enumerable.SequenceEqual(result.OrderBy(x => x), expectedResult.OrderBy(x => x)));
        }
    }
}
