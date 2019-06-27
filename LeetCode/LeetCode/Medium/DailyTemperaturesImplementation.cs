using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Medium
{
    public static class DailyTemperaturesImplementation
    {
        public static int[] DailyTemperatures(int[] T)
        {
            var result = new int[T.Length];
            for (var i = T.Length - 2; i >= 0; i--)
            {
                var next = i + 1;

                while (true)
                {
                    if (T[i] >= T[next] && result[next] == 0)
                    {
                        result[i] = 0;
                        break;
                    }

                    if (T[i] < T[next])
                    {
                        result[i] = next - i;
                        break;
                    }

                    if (T[i] >= T[next])
                    {
                        next += result[next];
                    }
                }
            }

            return result;
        }
    }
}
