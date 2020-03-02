using System.Collections.Generic;

namespace LeetCode.Easy
{
    public static class IsSubsequenceImp
    {
        public static bool IsSubsequence(string s, string t)
        {
            if (s.Length == 0) return true;
            int indexS = 0, indexT = 0;
            while (indexT < t.Length)
            {
                if (s[indexS] == t[indexT])
                    indexS++;

                if (indexS == s.Length) return true;
                indexT++;
            }

            return false;
        }
    }
}