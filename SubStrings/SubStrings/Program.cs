using System;
using System.Collections.Generic;

namespace SubStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //be able to take a work and be able to print out how many letters each provide
            //Dictionary ... will have a key (letter) and the value (number of times letter appears in word)
            // tennesse ... 
            // for each character in my array i want to see if the character is contained in the array ... 
            // if the character is contained in the array I want to increase the number for that specific character
            // 
            string word = "tennesee";
            int counter = 0;
            Dictionary<char, int> letterToLetterCountMap = new Dictionary<char, int>();

            foreach (char character in word) //going through each character 
            {
                if (!letterToLetterCountMap.ContainsKey(character)) // if the dictionary contains letter'key' increase the number of reps
                {
                    letterToLetterCountMap.Add(character, counter);
                }
            }
            foreach(char letterKey in word)
            {
                if (letterToLetterCountMap.ContainsKey(letterKey))
                {
                    letterToLetterCountMap[letterKey] += 1;
                }
            }
            foreach (KeyValuePair<char, int> letterCount in letterToLetterCountMap)
            {
                Console.WriteLine("Key = {0}, Value = {1}", letterCount.Key, letterCount.Value);
            }  
        }
    }
}
