using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTester
{
    class S2_LinedList1
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode i1 = l1, i2 = l2;
            int takeValue = 0;
            ListNode voidTail = new ListNode(0);
            ListNode cur = voidTail;
            while ((i1 != null) && (i2 != null))
            {
                ListNode curNext = new ListNode(0);
                cur.next = curNext;
                cur = curNext;

                cur.val = (i1.val + i2.val + takeValue) % 10;
                takeValue = (i1.val + i2.val + takeValue) / 10;

                i1 = i1.next; i2 = i2.next;
            }

            while (i1 != null)
            {
                ListNode curNext = new ListNode(0);
                cur.next = curNext;
                cur = curNext;

                cur.val = (i1.val + takeValue) % 10;
                takeValue = (i1.val + takeValue) / 10;

                i1 = i1.next;
            }

            while (i2 != null)
            {
                ListNode curNext = new ListNode(0);
                cur.next = curNext;
                cur = curNext;

                cur.val = (i2.val + takeValue) % 10;
                takeValue = (i2.val + takeValue) / 10;

                i2 = i2.next;
            }

            if (takeValue != 0) cur.next = new ListNode(takeValue);

            return voidTail.next;
        }
    }
}
