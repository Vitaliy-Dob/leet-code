using FluentAssertions;
using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Tests.Easy
{
    public class ValidParenthesesTests
    {
        [Theory]
        [InlineData("()", true)]
        [InlineData("()[]{}", true)]
        [InlineData("(]", false)]
        [InlineData("([)]", false)]
        public void ValidParentheses_FromLeetCode(string input, bool expected)
        {
            var result = ValidParentheses.IsValid(input);

            result.Should().Equals(expected);
        }
    }
}
