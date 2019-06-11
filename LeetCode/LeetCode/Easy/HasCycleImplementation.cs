using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    public static class HasCycleImplementation
    {
        public static bool HasCycle(ListNode head)
        {
            if (head == null || head.next == null)
                return false;

            ListNode slow = head;
            ListNode fast = head.next;

            while (slow.next != null && fast.next != null && fast.next.next != null)
            {
                if (slow == fast)
                    return true;

                slow = slow.next;
                fast = fast.next.next;
            }

            return false;
        }
    }
}
