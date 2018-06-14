using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    public static class MaxDepthImplementation
    {
        public static int MaxDepth(TreeNode root)
        {
            if (root == null)
                return 0;

            return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
        }
    }
}
