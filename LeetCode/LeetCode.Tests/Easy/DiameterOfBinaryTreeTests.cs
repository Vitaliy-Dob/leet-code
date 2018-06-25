using Common;
using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Tests.Easy
{
    public class DiameterOfBinaryTreeTests
    {
        [Fact]
        public void DiameterOfBinary_FromLeetCode_ShouldReturnDiameter()
        {
            var tree = new TreeNode(1);
            tree.left = new TreeNode(2);
            tree.left.left = new TreeNode(4);
            tree.left.right = new TreeNode(5);
            tree.right = new TreeNode(3);

            var result = DiameterOfBinaryTreeImplementation.DiameterOfBinaryTree(tree);

            Assert.Equal(3, result);
        }

        [Fact]
        public void DiameterOfBinary_RootTree_ShouldReturnDiameter()
        {
            var root = new TreeNode(5);

            var result = DiameterOfBinaryTreeImplementation.DiameterOfBinaryTree(root);

            Assert.Equal(0, result);
        }

        [Fact]
        public void DiameterOfBinary_CustomUseCase_ShouldReturnDiameter()
        {
            var tree = new TreeNode(1);
            tree.left = new TreeNode(2);
            tree.left.left = new TreeNode(4);
            tree.left.left.right = new TreeNode(8);
            tree.left.right = new TreeNode(5);
            tree.left.right.left = new TreeNode(9);

            var result = DiameterOfBinaryTreeImplementation.DiameterOfBinaryTree(tree);

            Assert.Equal(4, result);
        }
    }
}
