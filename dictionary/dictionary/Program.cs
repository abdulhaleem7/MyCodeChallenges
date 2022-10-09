using System;
using System.Collections.Generic;
using System.Linq;

namespace dictionary
{
    class Program
    {
       
        static void Main(string[] args)
        {
            //HackerRank hackerRank = new HackerRank();
            string s = "aabbbccc";
            Dictionary<char, int> charCollector = new Dictionary<char, int>();
            foreach (var item in s)
            {
                if (charCollector.ContainsKey(item))
                {
                    charCollector[item] = charCollector[item]+1;
                }
                else
                {
                    charCollector.Add(item, 1);
                }
            }


            charCollector.Values.Where(x => true).Max(x => x - 1);
            foreach (var item in charCollector)
            {
                Console.WriteLine(item.Key+","+item.Value);
            }
        }
    }
  
}
