using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Two_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[] {2, 7, 11, 15 };
            List<int> nums = intArray.ToList();
            
            int target = 9;

            for (int i = 0; i < intArray.Length; i++)
            {
                for (int j = i + 1; j < intArray.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        int[] sumValues = new int[] { i, j };
                        Console.WriteLine(sumValues.ToString());
                    }
                }
            }
            throw new Exception("Not found");
        }

        public int[] TWOSum(int[] nums, int target)
        {
            Dictionary<int, int> twoSumInput = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (twoSumInput.ContainsKey(complement))
                {
                    return new int[] {twoSumInput[complement], i };

                }
                else
                {
                    twoSumInput[nums[i]] = i;
                }
            }
        }throw new Exception("Why");
    }
}

