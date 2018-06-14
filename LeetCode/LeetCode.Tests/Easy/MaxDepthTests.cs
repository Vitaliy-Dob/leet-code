using Common;
using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Tests.Easy
{
    public class MaxDepthTests
    {
        [Fact]
        public void MaxDepth_FromLeetCode_ShouldFindMaxDepth()
        {
            var tree = new TreeNode(3);
            tree.left = new TreeNode(9);
            tree.right = new TreeNode(20);
            tree.right.left = new TreeNode(15);
            tree.right.right = new TreeNode(7);

            var result = MaxDepthImplementation.MaxDepth(tree);

            Assert.Equal(3, result);
        }

        [Fact]
        public void MaxDepth_EmptyTree_ShouldReturnZero()
        {
            TreeNode tree = null;

            var result = MaxDepthImplementation.MaxDepth(tree);

            Assert.Equal(0, result);
        }

        [Fact]
        public void MaxDepth_RootTree_ShouldReturnOne()
        {
            TreeNode root = new TreeNode(3);

            var result = MaxDepthImplementation.MaxDepth(root);

            Assert.Equal(1, result);
        }
    }
}
