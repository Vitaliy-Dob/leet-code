using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    public static class ClimbStairsImplementation
    {
        public static int ClimbStairs(int n)
        {
            var prev = 0;
            var current = 1;

            while(n != 0)
            {
                var temp = prev;
                prev = current;
                current = current + temp;
                n--;
            }

            return current;
        }
    }
}
