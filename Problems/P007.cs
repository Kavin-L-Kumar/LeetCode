using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems.P007
{
    internal class P007
    {
        public class Solution
        {
            public int Reverse(int x)
            {
                long reversed = 0;
                while (x != 0)
                {
                    int digit = x % 10;
                    reversed = reversed * 10 + digit;
                    x /= 10;

                    if (reversed > Int32.MaxValue) return 0;
                }
                return (int)reversed;
            }

            public void RunTest()
            {
                int x = -153;
                int reversedInt = Reverse(x);
                Console.WriteLine(reversedInt);
            }
        }
    }
}
