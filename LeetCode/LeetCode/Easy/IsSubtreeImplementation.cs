using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    public static class IsSubtreeImplementation
    {
        public static bool IsSubtree(TreeNode s, TreeNode t)
        {
            return Equals(s, t) || (s.left != null && IsSubtree(s.left, t)) || (s.right != null && IsSubtree(s.right, t));
        }

        private static bool Equals(TreeNode p, TreeNode t)
        {
            if (p == null && t == null)
                return true;
            if ((p == null) || (t == null))
                return false;

            return p.val == t.val && Equals(p.left, t.left) && Equals(p.right, t.right);
        }
    }
}
