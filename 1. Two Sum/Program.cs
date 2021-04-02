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
        }

        public int[] TwoSum(int[] nums, int target)
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

            // another way
        //    public class Solution
        //{
        //    public int[] TwoSum(int[] nums, int target)
        //    {
        //        for (var i = 1; i < nums.Length; i++)
        //        {
        //            for (var j = 0; j < i; j++)
        //            {
        //                if (target == nums[i] + nums[j]) return new[] { j, i };
        //            }
        //        }

        //        throw new ArgumentException("Invalid collection", nameof(nums));
        //    }
        //}
    }throw new Exception("Why");
    }
}

