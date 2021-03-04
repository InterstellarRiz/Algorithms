using System;

namespace Leetcode_Solutions
{
    class Program
    {
        static void Main(string[] args)
        {
            // code to letters
            //words[array]

            // build an array containing the morse code
            // build a new array were we substitute a char for each int value
            string[] morseCode = new string[] {".-", "-...", "-.-.", "-..", "."
                , "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-."
                , "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--"
                , "-..-", "-.--", "--.."};
            string[] letters = new string[] {"a", "b", "c", "d", "e", "f","g","h","i","j","k",
            "l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"};

            // string is converted into individual char. "gin" -> 'g' 'i' 'n'
            // 'i' -> letters Array value 'i' -> letters[8] index position
            // letters[8] -> morseCode[8] -> ".."

            string[] words = new string[] { "gin" };

            foreach (string stringLetter in words)

            {
                Console.WriteLine(stringLetter);
                char[] wordtoChar = stringLetter.ToCharArray();
                Console.WriteLine(wordtoChar);
                foreach(char character in wordtoChar)
                {
                    Console.WriteLine(character);
                    int letterValue = Array.IndexOf(letters, stringLetter);
                    Console.WriteLine(letterValue);

                }
            }
        }
    }
}
