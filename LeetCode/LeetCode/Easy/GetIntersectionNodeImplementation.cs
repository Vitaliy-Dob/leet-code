using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    public static class GetIntersectionNodeImplementation
    {
        public static ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            var lengthA = LinkedListLength(headA);
            var lengthB = LinkedListLength(headB);

            while (lengthA > lengthB)
            {
                lengthA--;
                headA = headA.next;
            }

            while (lengthB > lengthA)
            {
                lengthB--;
                headB = headB.next;
            }

            while (headA != null && headB != null)
            {
                if (headA == headB)
                    return headA;

                headA = headA.next;
                headB = headB.next;
            }

            return null;
        }

        private static int LinkedListLength(ListNode node)
        {
            var length = 0;

            while (node != null)
            {
                length++;
                node = node.next;
            }

            return length;
        }
    }
}
