using FluentAssertions;
using LeetCode.Medium;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Tests.Medium
{
    public class CountSubstringsTests
    {
        [Theory]
        [MemberData(nameof(TestData))]
        public void CountSubstrings_InputFromLeetCode_ShouldCalculateSubstrings(string input, int expectedResult)
        {
            var result = CountSubstringsImplementation.CountSubstrings(input);

            result.Should().Equals(expectedResult);
        }

        public static IEnumerable<object[]> TestData => new List<object[]>
        {
            new object[] { "abc", 3 },
            new object[] { "aaa", 6 },
            new object[] { "aaaaa", 12 }
        };
    }
}
