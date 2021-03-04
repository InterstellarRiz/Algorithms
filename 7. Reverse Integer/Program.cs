using System;

namespace _7._Reverse_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = -123;

            if (x < 0) // -123 < 0
            {
                x *= -1; // 123
                int reverse = Reverse(x);
                reverse *= -1; // 321 * -1
                Console.WriteLine(reverse);
                
            }
            else if (x == 0)
            {
                Console.WriteLine(x);
            }
            else
            {
                int reverse = Reverse(x);
                Console.WriteLine(reverse);
            }
                 
        }

        static int Reverse(int x) // 123
        {
            // establish a variable and turn it into a string
            string intToString = x.ToString(); // "123"
            // Console.WriteLine(intToString);
            // 
            // turn the string into a char[]
            char[] stringToChar = intToString.ToCharArray(); //'1', '2', '3'
            Array.Reverse(stringToChar); // '3', '2' '1'
            // TEST: Console.WriteLine(stringToChar);
            string charToString = new string(stringToChar); // "321"
            if (int.TryParse(charToString, out int reverse)) // true 
                return reverse; // 321
            else
            {
                return 0;
            }
        }
    }

}


// TryParse (true or false)