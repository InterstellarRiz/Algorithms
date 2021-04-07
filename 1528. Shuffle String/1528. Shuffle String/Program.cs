using System;

namespace _1528._Shuffle_String
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] order = new int[8];
            ShuffleString("codeleet", order);
        }

        static string ShuffleString(string s, int[] indices)
        {
            // string and the array length are the same length
            // attach the letters of an array to the represented array index ... 
            // ex/ arr[0] = a ... arr[1] == b ...
            char[] shuffleString = new char[s.Length];
            for (int i = 0; i < indices.Length; i++)
            {
                shuffleString[indices[i]] = s[i];
            }
            return new string(shuffleString);
        }
    }
}
