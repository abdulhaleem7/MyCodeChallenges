using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeChallengeMarch25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Frequencies();
        }
        public static void nums()
        {

            string alpha = "This is a boy";
            var alp = alpha
        }
        public static void Frequencies()
        {
            string alpha = "a";
            Dictionary<char, int> num = new Dictionary<char, int>();
            foreach (var item in alpha)
            {
                if (num.ContainsKey(item))
                {
                    num[item] = num[item] + 1;
                }
                else
                {
                    num.Add(item, 1);
                }
            }
            List<int> num2 = new List<int>();
            foreach (var item in num)
            {
                num2.Add(item.Value);
            }
            int count = 0;
            bool valid = true;
            for (int i = 1; i < num2.Count; i++)
            {
                if (Math.Abs(num2[i] - num2[i - 1]) == 0 || num2[i] - 1 == num2[i - 1])
                {
                    valid = true;
                }
                else if(num2[i] == 1)
                {
                    count++;
                }
                else
                {
                    valid = false;
                    break;
                }
            }
            if (valid && count<2)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
 
}
