using System;

namespace _344_Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a sample array
            char[] s = { 'h', 'e', 'l', 'l', 'o' };
            reverseString(s);
        }
        public static void reverseString(char[] reverseS)
        {
            // easy MVP product
            //Array.Reverse(reverseS);

            // another method 
            // initialize 
            char[] reverseString = new char[reverseS.Length];
            int counter = 0;
            //loop -- reverse the loop and add the counter
            for (int i = reverseS.Length - 1; i >= 0; i--)
            {
                reverseString[counter] = reverseS[i];
                counter++;
            }
            Array.Copy(reverseString, reverseS, reverseS.Length);

            //compare


        }
    }
}
