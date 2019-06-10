using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    public static class PathSumImplementation
    {
        public static int PathSum(TreeNode root, int sum)
        {
            if (root == null)
                return 0;

            return PathSumFrom(root, sum) + PathSum(root.left, sum) + PathSum(root.right, sum);
        }

        public static int PathSumFrom(TreeNode node, int sum)
        {
            if (node == null)
                return 0;

            return (sum == node.val ? 1 : 0) + PathSumFrom(node.left, sum - node.val) + PathSumFrom(node.right, sum - node.val);
        }
    }
}
