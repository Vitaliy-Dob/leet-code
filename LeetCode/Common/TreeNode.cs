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
    }
}
