using Common;
using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Tests.Easy
{
    public class InvertTreeTests
    {
        [Fact]
        public void InvertTree_FromLeetCode_ShouldInvertTree()
        {
            var tree = new TreeNode(4);
            tree.left = new TreeNode(2);
            tree.right = new TreeNode(7);
            tree.left.left = new TreeNode(1);
            tree.left.right = new TreeNode(3);
            tree.right.left = new TreeNode(6);
            tree.right.right = new TreeNode(9);

            var result = InvertTreeImplementation.InvertTree(tree);

            var expectedTree = new TreeNode(4);
            expectedTree.left = new TreeNode(7);
            expectedTree.right = new TreeNode(2);
            expectedTree.left.left = new TreeNode(9);
            expectedTree.left.right = new TreeNode(6);
            expectedTree.right.left = new TreeNode(3);
            expectedTree.right.right = new TreeNode(1);

            Assert.True(result.Equals(expectedTree) && expectedTree.Equals(result));
        }

        [Fact]
        public void InvertTree_WithEmptyLeaf_ShouldInvertTree()
        {
            var tree = new TreeNode(4);
            tree.left = new TreeNode(2);
            tree.right = new TreeNode(7);
            tree.left.left = new TreeNode(1);
            tree.left.right = new TreeNode(3);
            tree.right.left = new TreeNode(6);

            var result = InvertTreeImplementation.InvertTree(tree);

            var expectedTree = new TreeNode(4);
            expectedTree.left = new TreeNode(7);
            expectedTree.right = new TreeNode(2);
            expectedTree.left.right = new TreeNode(6);
            expectedTree.right.left = new TreeNode(3);
            expectedTree.right.right = new TreeNode(1);

            Assert.True(result.Equals(expectedTree) && expectedTree.Equals(result));
        }

        [Fact]
        public void InvertTree_EmptyTree_ShouldReturnEmptyTree()
        {
            TreeNode tree = null;

            var result = InvertTreeImplementation.InvertTree(tree);

            Assert.Null(result);
        }

        [Fact]
        public void InvertTree_RootTree_ShouldReturnRootTree()
        {
            TreeNode tree = new TreeNode(21);

            var result = InvertTreeImplementation.InvertTree(tree);

            var expectedResult = new TreeNode(21);
            Assert.True(tree.Equals(expectedResult) && expectedResult.Equals(tree));
        }
    }
}
