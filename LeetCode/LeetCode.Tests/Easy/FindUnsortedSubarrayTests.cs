using FluentAssertions;
using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Tests.Easy
{
    public class FindUnsortedSubarrayTests
    {

        [Theory]
        [MemberData(nameof(TestData))]
        public void Should_Return_Unsorted_SubArray(int[] input, int expectedResult)
        {
            var result = FindUnsortedSubarrayImplementation.FindUnsortedSubarray(input);

            result.Should().Be(expectedResult);
        }

        public static IEnumerable<object[]> TestData =>
           new List<object[]>
           {
                new object[] { new int[] { 2, 6, 4, 8, 10, 9, 15 }, 5 },
                new object[] { new int[] { 2, 1 }, 2 },
                new object[] { new int[] { 1, 2, 3, 5 }, 0 },
                new object[] { new int[] { 1, 2, 4, 3, 3, 3}, 4 },
                new object[] { new int[] { 1, 2, 5, 3, 4 }, 3 }
           };
    }
}
