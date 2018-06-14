using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace HammingDistance.Tests
{
    public class HammingDistanceTests
    {
        [Theory]
        [InlineData(1, 4, 2)]
        [InlineData(4, 1028, 1)]
        [InlineData(1, 1, 0)]
        [InlineData(15, 4, 3)]
        [InlineData(4, 4, 0)]
        public void HammingDistance_Theory_ShouldFindHammingDistance(int x, int y, int expectedResult)
        {
            var result = HammingDistanceImplementation.HammingDistance(x, y);
            Assert.Equal(expectedResult, result);
        }
    }
}
