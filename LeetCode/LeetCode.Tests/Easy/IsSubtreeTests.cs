using Common;
using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Tests.Easy
{
    public class IsSubtreeTests
    {
        [Fact]
        public void IsSubtree_UseCaseFromLeetCode_ShouldReturnTrue()
        {
            var parentTree = TreeNode.CreateTree(new int?[] { 3, 4, 5, 1, 2 });
            var childTree = TreeNode.CreateTree(new int?[] { 4, 1, 2 });

            var result = IsSubtreeImplementation.IsSubtree(parentTree, childTree);

            Assert.True(result);
        }

        [Fact]
        public void IsSubtree_UseCaseFromLeetCode_ShouldReturnFalse()
        {
            var parentTree = TreeNode.CreateTree(new int?[] { 3, 4, 5, 1, 2, null, null, null, null, 0 });
            var childTree = TreeNode.CreateTree(new int?[] { 4, 1, 2 });

            var result = IsSubtreeImplementation.IsSubtree(parentTree, childTree);

            Assert.False(result);
        }
    }
}
