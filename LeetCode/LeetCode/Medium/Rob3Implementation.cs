using System;
using System.Collections.Generic;
using System.Linq;
using Common;

namespace LeetCode.Medium
{
    public static class Rob3Implementation
    {
        public static int Rob3(TreeNode root)
        {
            if (root == null)
                return 0;

            var result = RobTree(root);
            return Math.Max(result.robbed, result.notrobbed);
        }

        public static (int robbed, int notrobbed) RobTree(TreeNode node)
        {
            if (node.left == null && node.right == null)
                return (node.val, 0);

            (int robbed, int notrobbed) right = (0, 0);
            (int robbed, int notrobbed) left = (0, 0);

            if (node.left != null)
                left = RobTree(node.left);

            if (node.right != null)
                right = RobTree(node.right);

            return (node.val + left.notrobbed + right.notrobbed, Math.Max(left.notrobbed, left.robbed) + Math.Max(right.notrobbed, right.robbed));
        }
    }
}