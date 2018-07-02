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
            if (root == null)
                return true;

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root.left);
            queue.Enqueue(root.right);

            while (queue.Count > 0)
            {
                var first = queue.Dequeue();
                var second = queue.Dequeue();

                if ((first != null && second == null) || (first == null && second != null))
                    return false;

                if (first == null && second == null)
                    continue;

                if (first.val != second.val)
                    return false;

                queue.Enqueue(first.left);
                queue.Enqueue(second.right);
                queue.Enqueue(first.right);
                queue.Enqueue(second.left);
            }

            return true;
        }
    }
}
