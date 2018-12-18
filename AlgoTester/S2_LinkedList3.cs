using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTester
{
    class S2_LinedList3
    {
         public class ListNode
         {
              public int val;
              public ListNode next;
              public ListNode(int x) { val = x; }
         }

        public static ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            ListNode ia = headA, ib = headB;
            if ((ia == null) || (ib == null)) return null;
            int aCount = 0;
            while (aCount < 2)
            {
                if (ia == ib) return ia;
                if (ia.next != null)
                {
                    ia = ia.next;
                }
                else
                {
                    ia = headB;
                    aCount++;
                }
                if (ib.next != null)
                {
                    ib = ib.next;
                }
                else
                {
                    ib = headA;
                }
            }
            
            return null;
        }
    }
}
