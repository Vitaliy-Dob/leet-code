using FluentAssertions;
using LeetCode.Medium;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Tests.Medium
{
    public class ReconstructQueueTests
    {
        [Theory]
        [MemberData(nameof(TestData))]
        public void Should_Reconstruct_The_Queue(int[][] input, int[][] expectedResult)
        {
            var result = ReconstructQueueImplementation.ReconstructQueue(input);

            result.Should().BeEquivalentTo(expectedResult, options => options.WithStrictOrdering());
        }

        public static IEnumerable<object[]> TestData =>
           new List<object[]>
           {
                new object[] {
                    new int[][] { new int[] { 7, 0 }, new int[] { 4, 4 }, new int[] { 7, 1 }, new int[] { 5, 0 }, new int[] { 6, 1 }, new int[] { 5, 2 } },
                    new int[][] { new int[] { 5, 0 }, new int[] { 7, 0 }, new int[] { 5, 2 }, new int[] { 6, 1 }, new int[] { 4, 4 }, new int[] { 7, 1 } }
                },
                new object[]
                {
                    new int[][] { new int[] { 9, 0 }, new int[] { 7, 0 }, new int[] { 1, 9 }, new int[] { 3, 0 }, new int[] { 2, 7 }, new int[] { 5, 3 }, new int[] { 6, 0 }, new int[] { 3, 4 }, new int[] { 6, 2 }, new int[] { 5, 2 } },
                    new int[][] { new int[] { 3, 0 }, new int[] { 6, 0 }, new int[] { 7, 0 }, new int[] { 5, 2 }, new int[] { 3, 4 }, new int[] { 5, 3 }, new int[] { 6, 2 }, new int[] { 2, 7 }, new int[] { 9, 0 }, new int[] { 1, 9 } }
                }
           };
    }
}
