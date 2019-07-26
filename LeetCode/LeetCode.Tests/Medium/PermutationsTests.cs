using FluentAssertions;
using LeetCode.Medium;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Tests.Medium
{
    public class PermutationsTests
    {
        [Theory]
        [MemberData(nameof(TestData))]
        public void Should_Return_All_Permutations(int[] input, int[][] expectedResult)
        {
            var result = PermutationsImplementation.Permute(input);
            result.Count.Should().Equals(expectedResult.Length);
        }

        public static IEnumerable<object[]> TestData =>
            new List<object[]>
            {
                new object[]
                {
                    new int[] { 1, 2, 3},
                    new int[][] {new int[] { 1, 2, 3 }, new int[] { 1, 3, 2 } , new int[] { 2, 1, 3 } , new int[] { 2, 3, 1 } , new int[] { 3, 1, 2 } , new int[] { 3, 2, 1 } }
                }
            };
    }
}
