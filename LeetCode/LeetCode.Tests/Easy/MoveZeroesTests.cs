using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace LeetCode.Tests.Easy
{
    public class MoveZeroesTests
    {
        [Theory]
        [InlineData(new int[] { 0, 1, 0, 3, 12 }, new int[] { 1, 3, 12, 0, 0 })]
        [InlineData(new int[] { 0, 0, 0 }, new int[] { 0, 0, 0 })]
        [InlineData(new int[] { 0 }, new int[] { 0 })]
        [InlineData(new int[] { 1 }, new int[] { 1 })]
        [InlineData(new int[] { 1, 13, 4 }, new int[] { 1, 13, 4 })]
        [InlineData(new int[] { 4, 0, 5, 0, 1, 0, 3, 12 }, new int[] { 4, 5, 1, 3, 12, 0, 0, 0 })]
        [InlineData(new int[] { 0, 0, 0, 1 }, new int[] { 1, 0, 0, 0 })]
        public void MoveZeroes_Theory_ShouldMoveZeroes(int[] input, int[] excpected)
        {
            MoveZeroesImplementation.MoveZeroes(input);

            Assert.True(Enumerable.SequenceEqual(input, excpected));
        }
    }
}
