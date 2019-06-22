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

        public static ListNode CreateList(int[] vals)
        {
            if (vals == null)
                return null;

            var root = new ListNode(vals[0]);
            var current = root;

            for (var i = 1; i < vals.Length; i++)
            {
                current.next = new ListNode(vals[i]);
                current = current.next;
            }

            return root;
        }

        public override int GetHashCode()
        {
            var hashCode = -903652156;
            hashCode = hashCode * -1521134295 + val.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<ListNode>.Default.GetHashCode(next);
            return hashCode;
        }
    }
}
