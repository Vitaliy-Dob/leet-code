using Common;
using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Tests.Easy
{
    public class IsSameTreeTests
    {
        [Fact]
        public void IsSameTree_TreesAreTheSame_ShouldReturnTrue()
        {
            var tree = new TreeNode(5);
            tree.left = new TreeNode(3);
            tree.right = new TreeNode(9);
            var second_tree = new TreeNode(5);
            second_tree.left = new TreeNode(3);
            second_tree.right = new TreeNode(9);

            var result = IsSameTreeImplementation.IsSameTree(tree, second_tree);

            Assert.True(result);
        }

        [Fact]
        public void IsSameTree_OneTreeIsNull_ShouldReturnFalse()
        {
            var tree = new TreeNode(5);
            tree.left = new TreeNode(3);
            tree.right = new TreeNode(9);
            TreeNode second_tree = null;            

            var result = IsSameTreeImplementation.IsSameTree(tree, second_tree);

            Assert.False(result);
        }

        [Fact]
        public void IsSameTree_BothNull_ShouldReturnTrue()
        {
            TreeNode tree = null;
            TreeNode second_tree = null;

            var result = IsSameTreeImplementation.IsSameTree(tree, second_tree);

            Assert.True(result);
        }

        [Fact]
        public void IsSameTree_TreesAreDifferent_ShouldReturnFalse()
        {
            var tree = new TreeNode(5);
            tree.left = new TreeNode(3);
            tree.right = new TreeNode(9);
            var second_tree = new TreeNode(5);
            second_tree.left = new TreeNode(9);
            second_tree.right = new TreeNode(3);

            var result = IsSameTreeImplementation.IsSameTree(tree, second_tree);

            Assert.False(result);
        }
    }
}
