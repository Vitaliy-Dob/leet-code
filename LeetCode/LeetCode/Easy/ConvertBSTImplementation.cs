using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    public static class ConvertBSTImplementation
    {
        public static TreeNode ConvertBST(TreeNode root)
        {
            Convert(root, 0);
            return root;
        }

        public static void Convert(TreeNode root, int sum)
        {
            if (root == null)
                return;

            root.val += sum + Sum(root.right);
            Convert(root.left, root.val);
            Convert(root.right, sum);
        }

        private static int Sum(TreeNode leaf)
        {
            if (leaf == null)
                return 0;

            return leaf.val + Sum(leaf.left) + Sum(leaf.right);
        }
    }
}
