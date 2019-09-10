using System;
using System.Collections.Generic;

namespace LeetCode.Medium
{
    public static class CombinationSumImplementation
    {
        public static IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            var result = new List<IList<int>>();
            Generate(result, new List<int>(), 0, candidates, target, 0);
            return result;
        }

        public static void Generate(IList<IList<int>> result, List<int> subResult, int sum, int[] candidates, int target, int counter)
        {
            if (sum == target)
                result.Add(subResult.ToArray());

            if (sum > target)
                return;

            for (var i = counter; i < candidates.Length; i++)
            {
                subResult.Add(candidates[i]);
                Generate(result, subResult, sum + candidates[i], candidates, target, i);
                subResult.RemoveAt(subResult.Count - 1);
            }
        }
    }
}