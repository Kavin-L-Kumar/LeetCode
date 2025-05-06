using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems.P009
{
    internal class P009
    {
        public class Solution
        {
            public bool IsPalindrome(int x)
            {
                int reverse = 0;
                int num = x;
                while (num > 0)
                {
                    int digit = num % 10;
                    reverse = reverse * 10 + digit;
                    num = num / 10;
                }
                return reverse == x;
            }
            public void RunTest()
            {
                int num = 121;
                var result = IsPalindrome((int)num);
                Console.WriteLine(result);
            }
        }
    }
}
