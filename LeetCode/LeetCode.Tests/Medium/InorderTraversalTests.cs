using Common;
using FluentAssertions;
using LeetCode.Medium;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Tests.Medium
{
    public class InorderTraversalTests
    {
        [Theory]
        [MemberData(nameof(TestData))]
        public void InorderTraversal_RegularTree_ShouldReturnInoderTraversal(int?[] vals, int[] expectedOutput)
        {
            var tree = TreeNode.CreateTree(vals);

            var result = InorderTraversalImplementation.InorderTraversal(tree);

            result.Should().Equal(expectedOutput);
        }

        public static IEnumerable<object[]> TestData => new List<object[]>
        {
            new object[] { new int?[] { 1, null, 2, 3}, new int[] { 1, 3, 2 } }
        };
    }
}
