using System;
using System.Collections.Generic;

namespace Ch10Decompression
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] original = new int[] { 5, 5, 5, 5, 10, 10, 10, 10, 5, 5 };
            int[] neworiginal = RLE(original);
            
        }

        static int[] RLE(int[] original)
        {
            // counts the number of rep. of a certain either char'' or integer
            // if value is the same add 1 to rep
            // if value is not the same add [index value] and reset rep value
            List<int> reduction = new List<int>(); // 0
            
            
            int rep = 0;
            int focus = original[0];
            int counter = 0;

            foreach(int value in original)
            {
                counter++;
                if  (focus == value)
                {
                    rep++;
                    if(counter == original.Length)
                    {
                        reduction.Add(rep);
                        reduction.Add(focus);
                    }
                }
                else if(focus != value)
                {
                    reduction.Add(rep); 
                    rep = 1;
                    reduction.Add(focus);
                    focus = value;

                }

                
            }
            foreach(int value in reduction)
            {
                Console.WriteLine(value);
            }
            
            int[] neworiginal = reduction.ToArray();
            return neworiginal;
        }
    }
}
