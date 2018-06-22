using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    public static class ReverseListImplementation
    {
        public static ListNode ReverseList(ListNode head)
        {
            if (head == null)
                return head;

            ListNode current = null;

            while (head != null)
            {
                var temp = head.next;
                head.next = current;
                current = head;
                head = temp;
            }

            return current;
        }
    }
}
