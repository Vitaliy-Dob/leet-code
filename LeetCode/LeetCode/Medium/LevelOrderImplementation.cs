using System;
using System.Collections.Generic;
using System.Linq;
using Common;

namespace LeetCode.Medium
{
    public static class LevelOrderImplementation
    {
        public static IList<IList<int>> LevelOrder(TreeNode root)
        {
            var result = new List<IList<int>>();
            if (root == null)
                return result;
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Any())
            {
                var queueLength = queue.Count;
                var level = new List<int>();

                for (var i = 0; i < queueLength; i++)
                {
                    var node = queue.Dequeue();
                    if (node.left != null)
                        queue.Enqueue(node.left);
                    if (node.right != null)
                        queue.Enqueue(node.right);
                    level.Add(node.val);
                }

                result.Add(level);
            }

            return result;
        }
    }

}