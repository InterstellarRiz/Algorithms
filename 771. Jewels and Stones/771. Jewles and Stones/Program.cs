using System;
using System.Collections.Generic;
using System.Linq;

namespace _771._Jewles_and_Stones
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(NumJewelsInStones("aAa", "aAaaaAabC")); 
            
        }

        static int NumJewelsInStones(string jewels, string stones)
        {
            //return stones.Count(stone => jewels.Contains(stone)); // using LInQ
            //how many stones are actual jewels
            // we are looking at each individual character within the string ...
            // we want to look at setting up some type of collection
            // find out if the collection contains the the string "jewels
            //HashSet is distinct values
            //initialize

            HashSet<char> jewelsHash = new HashSet<char>();
            int jewelsInStones = 0;
            foreach(var item in jewels)
            {
                jewelsHash.Add(item);
            }
            for (int i = 0; i < stones.Length; i++)
            {
                if(jewelsHash.Contains(stones[i]))
                {
                    jewelsInStones++;
                }
            }
            return jewelsInStones;
        }
    }
}
