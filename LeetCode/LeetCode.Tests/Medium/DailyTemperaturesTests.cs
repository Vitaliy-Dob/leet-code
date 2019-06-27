using FluentAssertions;
using LeetCode.Medium;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Tests.Medium
{
    public class DailyTemperaturesTests
    {
        [Theory]
        [MemberData(nameof(TestData))]
        public void Should_Return_Day_Until_Warmer(int[] temperatures, int[] expectedResult)
        {
            var result = DailyTemperaturesImplementation.DailyTemperatures(temperatures);

            result.Should().BeEquivalentTo(expectedResult);
        }

        public static IEnumerable<object[]> TestData =>
           new List<object[]>
           {
                new object[] { new int[] { 73, 74, 75, 71, 69, 72, 76, 73 }, new int[] { 1, 1, 4, 2, 1, 1, 0, 0 } },
                new object[] { new int[] { 70 } , new int[] { 0 } }
           };
    }
}
