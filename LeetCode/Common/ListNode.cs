using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }

        public override bool Equals(object obj)
        {
            var node = (ListNode)obj;

            if (node == null)
            {
                return false;
            }

            return val == node.val && ((next == null && node.next == null) || (next != null && next.Equals(node.next)));
        }
    }
}
