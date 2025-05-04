using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems.P008
{
    internal class P008
    {
        public class Solution
        {
            public int MyAtoi(string s)
            {
                if (string.IsNullOrEmpty(s)) return 0;

                if (s.Length == 0) return 0;
                string input = s.Trim();
                int index = 0, result = 0;

                int isNegative = input[0] == '-' ? -1 : 1;
                if (isNegative < 0) index++;
                while(index < input.Length && char.IsDigit(input[index]))
                {
                    int digit = s[index] - '0';
                    if (result > (int.MaxValue - digit) / 10)
                    {
                        return isNegative == 1 ? int.MaxValue : int.MinValue;
                    }
                    result = result * 10 + digit;
                    index++;
                }
                return (int)(isNegative * result);

            }

            public void RunTest()
            {
                string s = "   -042";
                int atoi = MyAtoi(s);
                Console.WriteLine(atoi);
            }
        }
    }
}
