using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }

        public override bool Equals(object obj)
        {
            var treeToCompare = (TreeNode)obj;

            if (treeToCompare == null)
                return false;

            return (val == treeToCompare.val)
                && ((left == null && treeToCompare.left == null) || (left != null && left.Equals(treeToCompare.left)))
                && ((right == null && treeToCompare.right == null) || (right != null && right.Equals(treeToCompare.right)));
        }

        public static TreeNode CreateTree(int?[] vals)
        {
            try
            {
                var tree = new TreeNode(vals[0].Value);
                var queue = new Queue<TreeNode>();
                queue.Enqueue(tree);
                var counter = 1;

                while (queue.Count > 0)
                {
                    var node = queue.Dequeue();

                    if (counter < vals.Length && vals[counter] != null)
                    {
                        node.left = new TreeNode(vals[counter].Value);
                        queue.Enqueue(node.left);
                    }

                    counter++;

                    if (counter < vals.Length && vals[counter] != null)
                    {
                        node.right = new TreeNode(vals[counter].Value);
                        queue.Enqueue(node.right);
                    }

                    counter++;
                }

                return tree;
            }
            catch
            {
                throw new ArgumentException("invalid tree declaration");
            }
        }
    }
}
