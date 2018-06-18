using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    public static class ConvertBSTImplementation
    {
        //Reverse Morris In-order Traversal
        public static TreeNode ConvertBST(TreeNode root)
        {
            var node = root;
            int sum = 0;

            while (node != null)
            {
                if (node.right == null)
                {
                    node.val += sum;
                    sum = node.val;
                    node = node.left;
                }
                else
                {
                    var successor = getSuccessor(node);

                    if (successor.left == null)
                    {
                        successor.left = node;
                        node = node.right;
                    }
                    else
                    {
                        successor.left = null;
                        node.val += sum;
                        sum = node.val;
                        node = node.left;
                    }
                }
            }

            return root;
        }

        private static TreeNode getSuccessor(TreeNode node)
        {
            var n = node.right;

            while (n.left != null && n.left != node)
            {
                n = n.left;
            }

            return n;
        }
    }
}
