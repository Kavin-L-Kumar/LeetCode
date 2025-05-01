using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems.P002
{
    internal class P002
    {
        public class ListNode
        {
            public int val;
            public ListNode pointer;
            public ListNode(int val = 0, ListNode pointer = null)
            {
                this.val = val;
                this.pointer = pointer;
            }
        }
        public class Solution
        {
            public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
            {
                ListNode dummyHead = new();
                ListNode current = dummyHead;
                int sum = 0;
                
                while(l1 != null || l2 != null || sum != 0)
                {
                    if(l1 != null)
                    {
                        sum += l1.val;
                        l1 = l1.pointer;
                    }
                    if(l2 != null)
                    {
                        sum += l2.val;
                        l2 = l2.pointer;
                    }
                    dummyHead.pointer = new ListNode(sum%10);
                    sum /= 10;
                    dummyHead = dummyHead.pointer;
                }
                return current.pointer;

            }
            public void RunTest()
            {
                ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3)));

                ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4, new ListNode(3))));
                var result = AddTwoNumbers(l1, l2);

                while (result != null)
                {
                    Console.Write(result.val);
                    if (result.pointer != null)
                        Console.Write(", ");
                    result = result.pointer;
                }
                Console.WriteLine("]");
            }

        }
    }
}
