using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.LeetCode
{
    public class ListNode
    {
      public int val;
      public ListNode next;
     public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
                 }
  }

    public class AddTwoNumbers
    {
        public ListNode AddTwoNumbs(ListNode l1, ListNode l2)
        {
            ListNode next1 = l1;
            ListNode next2 = l2;
            ListNode result = new ListNode();
            ListNode next = result;


            int reminder = 0;
            while (next1 != null || next2 != null)
            {
                int rr = 0;
                if (next1 != null && next2 != null)
                {
                    rr = add(next1.val, next2.val, ref reminder);
                }
                if (next1 == null && next2 != null)
                {
                    rr = add(0, next2.val, ref reminder);
                }
                if (next1 != null && next2 == null)
                {
                    rr = add(next1.val, 0, ref reminder);
                }
                next.next = new ListNode(rr);
                next = next.next;
                next1 = next1 != null ? next1.next : null;
                next2 = next2 != null ? next2.next : null;
            }

            if(reminder != 0)
            {
                next.next = new ListNode(reminder);
            }

            return result.next;
        }


        private int add(int a, int b, ref int r)
        {
            int res = a + b + r;
            if (res % 10 != res)
            {
                res = res % 10;
                r = 1;
            }
            else
            {
                r = 0;
            }
            return res;
        }
    }
}
