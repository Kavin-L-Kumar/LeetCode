using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems.P005
{
    internal class P005
    {
        public class Solution
        {
            public string LongestPalindrome(string s)
            {
                int start = 0, end = 0;

                for (int current = 0; current < s.Length; current++)
                {
                    var oddLen = GetPalinDrome(s, current, current);
                    var evenLen = GetPalinDrome(s, current, current + 1);

                    int maxLen = Math.Max(evenLen, oddLen);

                    if(maxLen > end-start)
                    {
                        start = current - (maxLen - 1) / 2;
                        end = current + maxLen / 2;
                    }
                }
                return s.Substring(start, end - start + 1);
            }

            private int GetPalinDrome( string s, int left, int right)
            {
                while(left >= 0  && right < s.Length && s[left] == s[right])
                {
                    left--;
                    right++;
                }

                return right - left - 1;
            }
            public void RunTest()
            {
                string s = "babad";
                var result = LongestPalindrome(s);
                Console.WriteLine(result);
            }
        }
    }
}
