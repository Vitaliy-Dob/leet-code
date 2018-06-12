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

            if (left != null && right != null)
                return left.Equals(treeToCompare.left) && right.Equals(treeToCompare.right);

            if (left != null)
                return left.Equals(treeToCompare.left);

            if (right != null)
                return right.Equals(treeToCompare.right);

            return true;
        }
    }
}
