using System;
using System.Collections.Generic;

namespace _1108.Defanging_an_IP_Address
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public string DefangIPaddr(string address)
        {
            // conver the string to a char
            char[] stringToCharArray = address.ToCharArray();
            // must add 3 char characters to replace '.' --- look at using a list to add input
            List<char> defangedIP = new List<char>();
            // we need to look at each vharacter in the first array -- for or foreach

            foreach (var character in stringToCharArray)
            {
                if (character == '.')
                {
                    defangedIP.Add('[');
                    defangedIP.Add('.');
                    defangedIP.Add(']');
                }
                else
                {
                    defangedIP.Add(character);
                }
            }


            stringToCharArray = defangedIP.ToArray();
            string answer = new string(stringToCharArray);
            return answer;
        }

    }

}
