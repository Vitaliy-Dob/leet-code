using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Medium
{
    public static class GenerateParenthesisImplementation
    {
        public static IList<string> GenerateParenthesis(int n)
        {
            var result = new List<string>();
            Generate("(", n - 1, n, result);
            return result;
        }

        public static void Generate(string p, int openedCount, int closedCount, IList<string> result)
        {
            if (openedCount == 0 && closedCount == 0)
                result.Add(p);

            if (openedCount != 0)
                Generate(p + "(", openedCount - 1, closedCount, result);

            if (openedCount == closedCount)
                return;

            Generate(p + ")", openedCount, closedCount - 1, result);
        }
    }
}