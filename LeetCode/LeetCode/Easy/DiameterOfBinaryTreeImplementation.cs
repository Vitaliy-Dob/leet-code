using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    public static class DiameterOfBinaryTreeImplementation
    {
        public static int DiameterOfBinaryTree(TreeNode root)
        {
            if (root == null)
                return 0;

            int diameter = DFS(root.left) + DFS(root.right);
            return Math.Max(diameter, Math.Max(DiameterOfBinaryTree(root.left), DiameterOfBinaryTree(root.right)));
        }

        private static int DFS(TreeNode root)
        {
            if (root == null)
                return 0;

            return 1 + Math.Max(DFS(root.left), DFS(root.right));
        }
    }
}
