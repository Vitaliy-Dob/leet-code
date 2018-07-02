using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    public static class IsSymmetricImplementation
    {
        public static bool IsSymmetricRecursive(TreeNode root)
        {
            if (root == null)
                return true;

            return IsSymmetric(root.left, root.right);
        }

        private static bool IsSymmetric(TreeNode left, TreeNode right)
        {
            if ((left == null && right != null) || (left != null && right == null))
                return false;

            if (left == null && right == null)
                return true;

            return left.val == right.val && IsSymmetric(left.left, right.right) && IsSymmetric(left.right, right.left);
        }

        public static bool IsSymmetricIterative(TreeNode root)
        {
            throw new NotImplementedException();
        }
    }
}
