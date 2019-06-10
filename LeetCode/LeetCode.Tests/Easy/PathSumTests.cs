using Common;
using FluentAssertions;
using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Tests.Easy
{
    public class PathSumTests
    {
        [Fact]
        public void PathSum_FromLeetCode()
        {
            var treeArr = new int?[] { 10, 5, -3, 3, 2, null, 11, 3, -2, null, 1 };
            var tree = TreeNode.CreateTree(treeArr);
            var result = PathSumImplementation.PathSum(tree, 8);

            result.Should().Be(3);
        }

        [Fact]
        public void PathSum_SingleNodeTree()
        {
            var treeArr = new int?[] { 1 };
            var tree = TreeNode.CreateTree(treeArr);
            var result = PathSumImplementation.PathSum(tree, 1);

            result.Should().Be(1);
        }
    }
}
