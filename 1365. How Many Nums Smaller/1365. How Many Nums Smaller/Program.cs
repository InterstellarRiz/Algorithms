using System;
using System.Collections.Generic;

namespace _1365._How_Many_Nums_Smaller
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 8, 1, 2, 2, 3 };
            SmallerNumbersThanCurrent(numbers);
        }

        public static int[] SmallerNumbersThanCurrent(int[] nums)
        {
            List<int> smallCount = new List<int>();
            int counter = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                counter = 0;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        counter++;
                    }
                }
                smallCount.Add(counter);
            }
            int[] smallArray = smallCount.ToArray();
            return smallArray;
        }
    }
}
