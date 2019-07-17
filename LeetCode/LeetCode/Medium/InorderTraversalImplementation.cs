using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Medium
{
    public static class InorderTraversalImplementation
    {
        public static IList<int> InorderTraversal(TreeNode root)
        {
            var result = new List<int>();

            if (root == null)
                return result;

            var stack = new Stack<TreeNode>();
            stack.Push(root);

            while (stack.Any())
            {
                while (root.left != null)
                {
                    stack.Push(root.left);
                    root = root.left;
                }

                var node = stack.Pop();
                result.Add(node.val);

                if (node.right != null)
                {
                    stack.Push(node.right);
                    root = node.right;
                }
            }

            return result;
        }
    }
}
