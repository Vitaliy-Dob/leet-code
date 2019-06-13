using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    public static class IsPalindromeImplementation
    {
        public static bool IsPalindrome(ListNode head)
        {
            var list = new List<int>();

            while (head != null)
            {
                list.Add(head.val);
                head = head.next;
            }

            for (var i = 0; i < list.Count / 2; i++)
            {
                if (list[i] != list[list.Count - i - 1])
                    return false;
            }

            return true;
        }
    }
}
