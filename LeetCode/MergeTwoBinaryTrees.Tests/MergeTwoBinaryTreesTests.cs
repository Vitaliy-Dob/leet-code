using Common;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MergeTwoBinaryTrees.Tests
{
    public class MergeTwoBinaryTreesTests
    {
        [Fact]
        public void MergeTwoBinaryTrees_FromLeetCode_Merge()
        {
            var tree1 = new TreeNode(1);
            tree1.left = new TreeNode(3);
            tree1.right = new TreeNode(2);
            tree1.left.left = new TreeNode(5);
            var tree2 = new TreeNode(2);
            tree2.left = new TreeNode(1);
            tree2.left.right = new TreeNode(4);
            tree2.right = new TreeNode(3);
            tree2.right.right = new TreeNode(7);

            var result = MergeTwoBinaryTreesImplementation.MergeTrees(tree1, tree2);

            var expectedResult = new TreeNode(3);
            expectedResult.left = new TreeNode(4);
            expectedResult.right = new TreeNode(5);
            expectedResult.left.left = new TreeNode(5);
            expectedResult.left.right = new TreeNode(4);
            expectedResult.right.right = new TreeNode(7);

            Assert.True(expectedResult.Equals(result) && result.Equals(expectedResult));
        }

        [Fact]
        public void MergeTwoBinaryTrees_EmptyTrees_ReturnEmptyTree()
        {
            TreeNode tree1 = null;
            TreeNode tree2 = null;

            var result = MergeTwoBinaryTreesImplementation.MergeTrees(tree1, tree2);

            Assert.Null(result);
        }
    }
}
