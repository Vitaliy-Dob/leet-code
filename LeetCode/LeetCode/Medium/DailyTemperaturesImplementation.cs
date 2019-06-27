using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Medium
{
    public static class DailyTemperaturesImplementation
    {
        public static int[] DailyTemperatures(int[] T)
        {
            var result = new int[T.Length];
            var stack = new Stack<int>();

            for (var i = 0; i < T.Length; i++)
            {
                while (stack.Any() && T[i] > T[stack.Peek()])
                {
                    var s = stack.Pop();
                    result[s] = i - s;
                }
                stack.Push(i);
            }

            return result;
        }
    }
}
