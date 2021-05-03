using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _557.Reverse_Words_in_a_String_III
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Let's take LeetCode contest";
            Console.WriteLine(reverseString(s));
        }

        static string reverseString(string input)
        {
            //we are wanting to reverse each word in the string
            // the only thing that is seperating each word is the space in between
            // the space is our identifier and and we will go through the word and reverse
            // we will need to build a new string (possible string builder) 
            // parse each work and send it in another method to reverse it and add it to the main string

            //initalize a new string 
            StringBuilder reverseInput = new StringBuilder();

            // i want split the string 

            string[] substringSplit = input.Split(' ');
            char tempCharacter;
            
            //{[Lets], [
            foreach(var substring in substringSplit)
            {
                // we have the words seperated into different words
                // now we need to go through each word and look at the character
                Console.WriteLine($"Substring:{substring}");
                string returnReverseWord = reverseWord(substring);
                reverseInput.Append(returnReverseWord);
               
                reverseInput.Append(" ");
                
            }
            
            string reverseString = reverseInput.ToString().Trim();
            
            //reverseString.Trim();
            
            return reverseString;
        }
        static string reverseWord(string sub)
        {
            char tempCharacter;
            StringBuilder reWord = new StringBuilder();
            for (int i = sub.Length - 1; i >= 0; i--)
            {
                reWord.Append(sub[i]);
            }
            string reWordToString = reWord.ToString();
            Console.WriteLine(reWordToString);
            
            return reWordToString;
        }
    }
}
