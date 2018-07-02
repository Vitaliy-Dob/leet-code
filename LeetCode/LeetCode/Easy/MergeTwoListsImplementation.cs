using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    public static class MergeTwoListsImplementation
    {
        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null)
                return l2;
            if (l2 == null)
                return l1;
            if (l1.val < l2.val)
            {
                l1.next = MergeTwoLists(l1.next, l2);
                return l1;
            }
            if (l1.val >= l2.val)
            {
                l2.next = MergeTwoLists(l1, l2.next);
                return l2;
            }

            return null;
        }
    }
}
