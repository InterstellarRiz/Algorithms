using System;
using System.Collections.Generic;
using System.Linq;

namespace _1408._String_Matching_in_an_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] i = { "put", "stop", "got" };
            string[] o = { "pu", "top", "we" };

            StringMatching(i);
            StringMatching(o);
               

        }

        static IList<string> StringMatching(string[] words)
        {
            HashSet<string> subSet = new HashSet<string>();
            
                    //put = 3
            for (int i = 0; i < words.Length; i++)
            {
                for (int o = i + 1; o < words.Length; o++)
                {
                    if (words[i].Contains(words[o]))
                    {
                        subSet.Add(words[o]);
                        continue;
                    }
                    if (words[o].Contains(words[i]))
                    {
                        subSet.Add(words[i]);
                        continue;
                    }
                }
            }

            List<string> subSetToList = subSet.ToList();

            foreach (string item in subSetToList)
            {
                Console.WriteLine("{0}\t", item.ToString());
                Console.WriteLine();
            }

            
            return subSetToList;
        }
    }
}
