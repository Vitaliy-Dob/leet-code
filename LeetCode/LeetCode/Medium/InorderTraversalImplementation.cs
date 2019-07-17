using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Medium
{
    public static class InorderTraversalImplementation
    {
        public static IList<int> InorderTraversal(TreeNode root)
        {
            var result = new List<int>();
            if (root != null)
                InOrder(result, root);

            return result;
        }

        private static void InOrder(List<int> result, TreeNode root)
        {
            if (root.left != null)
                InOrder(result, root.left);

            result.Add(root.val);

            if (root.right != null)
                InOrder(result, root.right);
        }
    }
}
