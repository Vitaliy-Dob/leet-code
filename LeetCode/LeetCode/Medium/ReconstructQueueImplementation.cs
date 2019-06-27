using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Medium
{
    public static class ReconstructQueueImplementation
    {
        public static int[][] ReconstructQueue(int[][] people)
        {
            var list = new List<int[]>();
            Array.Sort(people, new Comparator());
            for (var i = 0; i < people.Length; i++)
            {
                list.Insert(people[i][1], people[i]);
            }
            return list.ToArray();

        }

        private class Comparator : IComparer<int[]>
        {
            public int Compare(int[] x, int[] y)
            {
                return x[0] != y[0] ? y[0] - x[0] : x[1] - y[1];
            }
        }
    }
}
