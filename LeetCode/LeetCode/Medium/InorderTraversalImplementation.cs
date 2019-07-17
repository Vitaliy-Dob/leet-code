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
            bool bottomDirection = true;

            while (stack.Any())
            {
                if (bottomDirection)
                {
                    var node = stack.Peek();
                    if (node.left != null)
                    {
                        stack.Push(node.left);
                        bottomDirection = true;
                        continue;
                    }

                    bottomDirection = false;
                    continue;
                }
                else
                {
                    var node = stack.Pop();
                    result.Add(node.val);
                    if (node.right != null)
                    {
                        stack.Push(node.right);
                        bottomDirection = true;
                    }
                }
            }

            return result;
        }
    }
}
