using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTester
{
    class Program
    {
        static void Main(string[] args)
        {
            //var input = new string[]{ "eat", "tea", "tan", "ate", "nat", "bat"};

            S2_LinedList3.ListNode voidTail = new S2_LinedList3.ListNode(0);
            S2_LinedList3.ListNode cur = voidTail;
            int[] input = new int[] { 2, 1, 3, 5, 6, 4, 7 };
            foreach (var k in input)
            {
                cur.next = new S2_LinedList3.ListNode(k);
                cur = cur.next;
            }
            cur = voidTail.next;
            while (cur != null)
            {
                Console.Write(cur.val + " ");
                cur = cur.next;
            }
            Console.WriteLine();

            //var ans = Array6.IncreasingTriplet(new int[] { 1, 2, 3, 4, 5 });
            var ans = S2_LinedList3.GetIntersectionNode(voidTail.next, voidTail.next);

            while (ans != null)
            {
                Console.WriteLine(ans.val);
                ans = ans.next;
            }
            Console.ReadKey();
        }
    }
}
