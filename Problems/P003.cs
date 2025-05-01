using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems.P003
{
    internal class P003
    {
        public class Solution
        {
            public int LengthOfLongestSubstring(string s)
            {
                int rightPoint = 0;
                int leftPoint = 0;
                int maxLength = 0;
                HashSet<char> chars = new();

                while (rightPoint < s.Length)
                {
                    if (!chars.Contains(s[rightPoint]))
                    {
                        chars.Add(s[rightPoint]);
                        rightPoint++;
                        maxLength = Math.Max(maxLength, rightPoint - leftPoint);
                    }
                    else
                    {
                        chars.Remove(s[leftPoint]);
                        leftPoint++;
                    }
                }
                return maxLength;
                
            }
            public void RunTest()
            {
                string s = "pwwkew";
                var result = LengthOfLongestSubstring(s);
                Console.WriteLine(result);
            }
        }
    }
}
