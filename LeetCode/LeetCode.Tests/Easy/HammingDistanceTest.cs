using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace HammingDistance.Tests
{
    public class HammingDistanceTest
    {
        [Theory]
        [InlineData(1, 4, 2)]
        [InlineData(4, 1028, 1)]
        [InlineData(1, 1, 0)]
        [InlineData(15, 4, 3)]
        [InlineData(4, 4, 0)]
        public void HammingDistance_PositiveNumbers_FindHammingDistance(int x, int y, int expectedResult)
        {
            var result = HammingDistanceImplementation.HammingDistance(x, y);
            Assert.Equal(result, expectedResult);
        }
    }
}
