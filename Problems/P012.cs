using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems.P012
{
    internal class P012
    {
        public class Solution
        {

            public string IntToRoman(int num)
            {
                var romanMap = new (int value, string symbol)[] {
                    (1000, "M"), (900, "CM"), (500, "D"), (400, "CD"),
                    (100, "C"), (90, "XC"), (50, "L"), (40, "XL"),
                    (10, "X"), (9, "IX"), (5, "V"), (4, "IV"), (1, "I")
                     };

                var result = new StringBuilder();

                foreach (var (value, symbol) in romanMap)
                {
                    while (num >= value)
                    {
                        result.Append(symbol);
                        num -= value;
                    }
                }

                return result.ToString();
            }
            public void RunTest()
            {
                int num = 3749;
                var result = IntToRoman(num);
                Console.WriteLine(result);
            }
        }
    }
}
