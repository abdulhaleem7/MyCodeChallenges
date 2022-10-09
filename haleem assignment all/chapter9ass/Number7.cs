using System;

namespace chapter9ass
{
    class Number7
    {
        public static void reverse()
        {
            Console.Write("enter number");
            int number = int.Parse(Console.ReadLine());

           Console.WriteLine(Verse(number));
        }
        public static string Verse(int num)
        {
            
            int rem = 0;
            
           for(; ; )
            {
                int lastNumber = num % 10;
                num = num / 10;
                rem = (rem * 10) + lastNumber;
           
                if (num == 0)
                {
                    break;
                }

            }

            return $"{rem}";
        }
    }
}