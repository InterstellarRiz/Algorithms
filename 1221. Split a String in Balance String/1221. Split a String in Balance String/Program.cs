using System;
using System.Collections.Generic;
using System.Linq;

namespace _1221._Split_a_String_in_Balance_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "RLRRLLRLRL";
            BalancedStringSplit(str);
        }

        public static int BalancedStringSplit(string s)
        {
            char[] stringSplit = s.ToCharArray();
            List<char> r = new List<char>();
            List<char> l = new List<char>();



            int counter = 0;
            //[RL..RRLLRLRL]
            for (int i = 0; i < stringSplit.Length; i++)
            {
                if (stringSplit[i] == 'R')
                {
                    r.Add(stringSplit[i]);
                }
                if (stringSplit[i] == 'L')
                {
                    l.Add(stringSplit[i]);
                }
                if (r.Count() == l.Count())
                {
                    counter++;
                }
            }

            return counter;
        }

    }
}
