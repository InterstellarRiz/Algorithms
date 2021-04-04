using System;

namespace _1512._Number_Of_Good_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] identicalPairs = { 1, 2, 3, 1, 1, 3 };
            GoodPairs(identicalPairs);
        }

        static int GoodPairs(int[] nums)
        {
            int goodPairs = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j] && i < j)
                    {
                        //if (i < j)
                        //{
                        goodPairs++;
                        //}
                    }


                }

            }
            return goodPairs;
        }
    }
}
