using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    public class InvertTreeImplementation
    {
        public static TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
                return root;

            TreeNode temp = root.left;
            root.left = root.right;
            root.right = temp;

            root.left = InvertTree(root.left);
            root.right = InvertTree(root.right);

            return root;
        }
    }
}
