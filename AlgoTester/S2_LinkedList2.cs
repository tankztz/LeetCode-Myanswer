using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTester
{
    class S2_LinedList2
    {
         public class ListNode
         {
              public int val;
              public ListNode next;
              public ListNode(int x) { val = x; }
         }

        public static ListNode OddEvenList(ListNode head)
        {
            ListNode i1 = head;
            ListNode oddTail = head;
            bool i1NextIsOdd = false;
            while ((i1 != null) && (i1.next != null))
            {
                if (i1NextIsOdd)
                {
                    ListNode toInsert = i1.next;
                    i1.next = toInsert.next;
                    toInsert.next = oddTail.next;
                    oddTail.next = toInsert;
                    oddTail = oddTail.next;
                }
                else
                {
                    i1 = i1.next;
                }
                i1NextIsOdd = !i1NextIsOdd;
            }
            
            return head;
        }
    }
}
