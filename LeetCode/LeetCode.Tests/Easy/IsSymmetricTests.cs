using Common;
using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Tests.Easy
{
    public class IsSymmetricTests
    {
        [Fact]
        public void IsSymmetricIterative_FromLeetCode_ShouldReturnTrue()
        {
            var tree = TreeNode.CreateTree(new int?[] { 1, 2, 2, 3, 4, 4, 3 });

            var result = IsSymmetricImplementation.IsSymmetricIterative(tree);

            Assert.True(result);
        }

        [Fact]
        public void IsSymmetricRecursive_FromLeetCode_ShouldReturnTrue()
        {
            var tree = TreeNode.CreateTree(new int?[] { 1, 2, 2, 3, 4, 4, 3 });

            var result = IsSymmetricImplementation.IsSymmetricRecursive(tree);

            Assert.True(result);
        }

        [Fact]
        public void IsSymmetricIterative_FromLeetCode_ShouldReturnFalse()
        {
            var tree = TreeNode.CreateTree(new int?[] { 1, 2, 2, null, 3, null, 3 });

            var result = IsSymmetricImplementation.IsSymmetricIterative(tree);

            Assert.False(result);
        }

        [Fact]
        public void IsSymmetricRecursive_FromLeetCode_ShouldReturnFalse()
        {
            var tree = TreeNode.CreateTree(new int?[] { 1, 2, 2, null, 3, null, 3 });

            var result = IsSymmetricImplementation.IsSymmetricRecursive(tree);

            Assert.False(result);
        }

        [Fact]
        public void IsSymmetricIterative_EmptyTree_ShouldReturnTrue()
        {
            TreeNode tree = null;

            var result = IsSymmetricImplementation.IsSymmetricIterative(tree);

            Assert.True(result);
        }

        [Fact]
        public void IsSymmetricRecursive_EmptyTree_ShouldReturnTrue()
        {
            TreeNode tree = null;

            var result = IsSymmetricImplementation.IsSymmetricRecursive(tree);

            Assert.True(result);
        }

        [Fact]
        public void IsSymmetricIterative_RootTree_ShouldReturnTrue()
        {
            TreeNode tree = new TreeNode(5);

            var result = IsSymmetricImplementation.IsSymmetricIterative(tree);

            Assert.True(result);
        }

        [Fact]
        public void IsSymmetricRecursive_RootTree_ShouldReturnTrue()
        {
            TreeNode tree = new TreeNode(5);

            var result = IsSymmetricImplementation.IsSymmetricRecursive(tree);

            Assert.True(result);
        }
    }
}
