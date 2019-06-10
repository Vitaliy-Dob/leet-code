using FluentAssertions;
using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Tests.Easy
{
    public class FindAnagramTest
    {
        [Theory]
        [InlineData(new int[] { 0, 6 }, "cbaebabacd", "abc")]
        [InlineData(new int[] { 0, 1, 2 }, "abab", "ab")]
        [InlineData(new int[] { 0 }, "aaabaa", "aaa")]
        [InlineData(new int[] { }, "aaa", "bb")]
        public void FindAnagram_LeetCode(int[] expectedResult, string s, string p)
        {
            var result = FindAnagramImplementation.FindAnagrams(s, p);
            result.Should().Equal(expectedResult);
        }
    }
}
