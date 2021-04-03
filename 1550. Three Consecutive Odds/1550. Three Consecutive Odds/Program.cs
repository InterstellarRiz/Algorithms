using System;

namespace _1550._Three_Consecutive_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 34, 3, 4, 5, 7, 23, 12 };
            ThreeConsecutiveOdds(arr);
        }
            
        static bool ThreeConsecutiveOdds(int[] arr)
        {
            //[1,2,34,3,4,5,7,23,12]
            //look for odd numbers 
            // some number % != 0 
            // three consective odd ... back to back to back ... check each index value if its odd
            // return true or false 

            // initializing

            bool isThereThreeOdds = false;
            // counter for consecutive odds .. if it equals 3 at anytime jump out and its true 
            int counter = 0;
            // looping 
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0) //1, 0, 0, 1, 0, 1, 2, 3
                {
                    counter++; // we are add an odd ... then iterating through

                    if (counter == 3)
                    {
                        isThereThreeOdds = true;
                        return isThereThreeOdds;
                    }
                }
                // arr has a lot more odds than evens ... what now
                else if (arr[i] % 2 == 0) // 0, -1, 0, -1, 0, 1, 2, 
                {
                    counter = 0; // if we grab an even subtract 
                }
                // comparing
            }
            return isThereThreeOdds;
        }
    }
}
