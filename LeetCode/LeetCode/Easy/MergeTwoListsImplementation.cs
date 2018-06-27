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
            ListNode result = null;
            ListNode currentResult = null;
            var current1 = l1;
            var current2 = l2;

            while (current1 != null || current2 != null)
            {
                if ((current2 == null && current1 != null) || (current1 != null && current1.val <= current2.val))
                {
                    if (currentResult == null)
                    {
                        result = new ListNode(current1.val);
                        currentResult = result;
                    }
                    else
                    {
                        currentResult.next = new ListNode(current1.val);
                        currentResult = currentResult.next;
                    }

                    current1 = current1.next;
                    continue;
                }

                if ((current1 == null && current2 != null) || (current2 != null && current2.val < current1.val))
                {
                    if (currentResult == null)
                    {
                        result = new ListNode(current2.val);
                        currentResult = result;
                    }
                    else
                    {
                        currentResult.next = new ListNode(current2.val);
                        currentResult = currentResult.next;
                    }

                    current2 = current2.next;
                }
            }

            return result;
        }
    }
}
