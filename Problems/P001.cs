using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems.P001
{
    internal class P001
    {
        public class Solution
        {
            public int[] TwoSum(int[] nums, int target)
            {
                for (int i = 0;i<nums.Length;i++)
                {
                    for (int j = i+1; j < nums.Length; j++)
                    {
                        if (nums[i] + nums[j] == target)
                        {
                            return new int[] {i,j};
                        }
                    }
                }
                throw new ArgumentException("no data");
            }

            public void RunTest()
            {
                int[] nums = { 2, 7, 11, 15 };
                int target = 9;
                var result = TwoSum(nums, target);
                Console.WriteLine($"Result: [{result[0]}, {result[1]}]");
            }
        }
         /* Uses the dictionary for the O(n)*/

            //public int[] TwoSum(int[] nums, int target)
            //{
            //    Dictionary<int, int> map = new Dictionary<int, int>();
            //    for (int i = 0; i < nums.Length; i++)
            //    {
            //        int complement = target - nums[i];

            //        if (map.ContainsKey(complement))
            //            return new int[] { map[complement], i };
            //        if (!map.ContainsKey(nums[i]))
            //            map[nums[i]] = i;
            //    }
    }
}
