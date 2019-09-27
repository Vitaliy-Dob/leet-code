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
            var queue = new Queue<(int, TreeNode)>();
            var currentLevel = 1;
            queue.Enqueue((currentLevel, root));
            var level = new List<int>();

            while (queue.Any())
            {
                var node = queue.Dequeue();
                if (node.Item1 != currentLevel)
                {
                    result.Add(level);
                    level = new List<int>();
                    currentLevel = currentLevel + 1;
                }

                level.Add(node.Item2.val);

                if (node.Item2.left != null)
                    queue.Enqueue((currentLevel + 1, node.Item2.left));
                if (node.Item2.right != null)
                    queue.Enqueue((currentLevel + 1, node.Item2.right));
            }

            result.Add(level);

            return result;
        }
    }

}