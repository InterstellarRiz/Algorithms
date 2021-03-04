using System;
using System.Collections.Generic;

namespace _1304._Find_N_Unique_Integers_Sum_up_to_Zero
{
    class Program
    {
        static void Main(string[] args)
        {
            SumZero(5);
        }
        static int[] SumZero(int n)
        {
            // take n amount of indexes in an int[]
            // determine the values of the sum of int[] == 0
            // create the values in int[n]

            HashSet<int> equalZero = new HashSet<int>();
                
            int[] equalZero = new int[n];
            int total = 0;
            bool keepGoing = false;
            Random randNum = new Random();
            while (keepGoing == false)
            {

                for (int i = 0; i < equalZero.Length; i++)
                {
                    equalZero[i] = randNum.Next(-1000, 1000);
                    for (int j = 0; j < equalZero.Length; j++)
                    {
                        total += equalZero[j];
                    }  
                    
                }
                if (total == 0)
                {
                    foreach (int value in equalZero)
                    {
                        Console.WriteLine(value);
                        keepGoing = true;
                    }
                }

            }
            return equalZero;
        }
    }
}
