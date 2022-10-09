using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            Pallindrome();
        }

        static string PrintPattern()
        {

            return "";
           
        }
        public static void Num2()
        {
            int[] nums = { 3, 2, 3 };
            int test = 6;
            List<int> number = new List<int>();
            for (int i =0; i < nums.Length; i++)
            {
                for (int j = i; j < nums.Length; j++)
                {
                    if (i != j)
                    {
                        if (nums[i] + nums[j] == test)
                        {
                            number.Add(i);
                            number.Add(j);
                        }
                    }
                    
                }
            }
           
        }
        public static void Num1()
        {
            int num = 120;
            string a = num.ToString();
            char[] r = a.ToCharArray();

            int count = 0;
            for (int i = 0; i < r.Length; i++)
            {

                int b = int.Parse(r[i].ToString());
                if (b != 0)
                {
                    if (num % b == 0 && b != 0)
                    {
                        count++;
                    }
                }

            }
            
            Console.WriteLine(count);
        }
        public static bool Pallindrome()
        {
            int x = 121;
            bool istrue = false;
            if(x < 0)
            {
                istrue = false;
            }
            else
            {
                string y = new String(x.ToString().ToCharArray().Reverse().ToArray());



                

                int num = int.Parse(y);
                if (num == x)
                {
                    istrue = true;
                }
                else
                {
                    istrue = false;
                }
            }
            return istrue;
        }
    }
}
