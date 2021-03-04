using System;
using System.Collections.Generic;

namespace _1431._Kids_With_the_Greatest_Number_of_Candies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] _candieAmount = new int[] { 2, 3, 5, 1, 3 };
            int _extraCandies = 3;
            IList<bool> list = KidsWithCandies(_candieAmount, _extraCandies);
            foreach (bool value in list)
            {
                Console.WriteLine(value);
            }
        }
        static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            // we are creating a list that we will need to add true of 
            // we will need to add the extra candies to each index. Can that index be higher than all the others
            // returning a list of boolean values
            // a way to add correct values to the list
            IList<bool> answer = new List<bool>();
            bool answerInput = false;
            int[] candiesPlusExtra = new int[candies.Length];
            int j = 0;
            // we need to go through the array and which value is the max
            for (int i = 0; i < candies.Length; i++)
            {
                if(candies[i] > j) // we are going through the array and finding the max value. Kind of like a double Math.Max()
                {
                    j = candies[i];
                }
                //need a way to add the extraCandies to each index value.
            }
            // we need to compare the values to the max
            for (int i = 0; i < candies.Length; i++)
            {
                int maxCandies = candies[i] + extraCandies;
                if(maxCandies >= j) // greater or greater and equal  ?
                {
                    answerInput = true;
                    answer.Add(answerInput); // could just add true now that I think about it 
                }
                else
                {
                    answerInput = false;
                    answer.Add(answerInput);
                }

            }
            return answer;
        }
    }
}
