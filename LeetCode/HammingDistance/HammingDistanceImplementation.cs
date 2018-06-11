using System;
using System.Collections.Generic;
using System.Text;

namespace HammingDistance
{
    public static class HammingDistanceImplementation
    {
        public static int HammingDistance(int x, int y)
        {
            var exclusiveOr = x ^ y;          
            var count = 0;

            while ((exclusiveOr | 0) != 0)
            {                
                if ((exclusiveOr & 1) == 1)
                {
                    count++;
                }
                exclusiveOr = exclusiveOr >> 1;
            }

            return count;
        }
    }
}
