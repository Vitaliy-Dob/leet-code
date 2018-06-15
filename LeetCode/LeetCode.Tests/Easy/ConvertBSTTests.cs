using Common;
using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Tests.Easy
{
    public class ConvertBSTTests
    {
        [Fact]
        public void ConvertBST_FromLeetCode_ShouldConvertToGreaterTree()
        {
            var tree = new TreeNode(5);
            tree.left = new TreeNode(2);
            tree.right = new TreeNode(13);
            var expectedResult = new TreeNode(18);
            expectedResult.left = new TreeNode(20);
            expectedResult.right = new TreeNode(13);

            var result = ConvertBSTImplementation.ConvertBST(tree);

            Assert.True(expectedResult.Equals(result) && result.Equals(expectedResult));
        }

        [Fact]
        public void ConverBST_EmptyTree_ShouldReturnNull()
        {
            TreeNode tree = null;

            var result = ConvertBSTImplementation.ConvertBST(tree);

            Assert.Null(result);
        }

        [Fact]
        public void ConverBST_RootTree_ShouldReturnRootTree()
        {
            TreeNode tree = new TreeNode(5);

            var result = ConvertBSTImplementation.ConvertBST(tree);

            Assert.Null(result.left);
            Assert.Null(result.right);
            Assert.Equal(5, tree.val);
        }

        [Fact]
        public void ConverBST_WithOneLeaf_ShouldConvertToGreaterTree()
        {
            var tree = new TreeNode(5);
            tree.left = new TreeNode(2);
            tree.left.left = new TreeNode(1);
            tree.right = new TreeNode(13);
            var expectedResult = new TreeNode(18);
            expectedResult.left = new TreeNode(20);
            expectedResult.right = new TreeNode(13);
            expectedResult.left.left = new TreeNode(21);

            var result = ConvertBSTImplementation.ConvertBST(tree);

            Assert.True(result.Equals(expectedResult) && expectedResult.Equals(result));
        }

        [Fact]
        public void ConvertBST_FailedUseCase_ShouldConvertToGreaterTree()
        {
            var tree = new TreeNode(2);
            tree.left = new TreeNode(0);
            tree.left.left = new TreeNode(-4);
            tree.left.right = new TreeNode(1);
            tree.right = new TreeNode(3);
            var expectedResult = new TreeNode(5);
            expectedResult.left = new TreeNode(6);
            expectedResult.left.left = new TreeNode(2);
            expectedResult.left.right = new TreeNode(6);
            expectedResult.right = new TreeNode(3);

            var result = ConvertBSTImplementation.ConvertBST(tree);

            Assert.True(result.Equals(expectedResult) && expectedResult.Equals(result));
        }
    }
}
