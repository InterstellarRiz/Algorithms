using System;
using System.Collections.Generic;
using System.Linq;

namespace _136._Single_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNums = { 4, 1, 2, 1, 2 };
            SingleNumber(arrayOfNums);
        }
        public static int SingleNumber(int[] nums)
        {
            //go through the array and find out which index has a value used only once
            // foreach or for loop
            // store the previous value
            // use something that stores unique values "Hashset
            // example [4,1,2,1,2]
            
            HashSet<int> storeUniqueValue = new HashSet<int>();
            foreach (var indexNum in nums)
            {
                // if the value is repeated in the array then we wann
                if (storeUniqueValue.Contains(indexNum))
                {
                    storeUniqueValue.Remove(indexNum);
                }
                else
                {
                    storeUniqueValue.Add(indexNum);
                }
            }
            //foreach(int v in storeUniqueValue)
            //{
            //    Console.WriteLine(v);
            //}

            int[] holdReturnValue = storeUniqueValue.ToArray();
            int returnValue = holdReturnValue[0];

            return returnValue;
        }
    }
}
