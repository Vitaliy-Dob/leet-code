using Common;
using System;
using System.Collections.Generic;

namespace MergeTwoBinaryTrees.Tests
{
    public class MergeTwoBinaryTreesImplementation
    {
        public static TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        {
            if (t2 == null)
            {
                return t1;
            }
            if (t1 == null)
            {
                return t2;
            }

            var result = new TreeNode(t1.val + t2.val);
            result.left = MergeTrees(t1.left, t2.left);
            result.right = MergeTrees(t1.right, t2.right);

            return result;
        }
    }
}
