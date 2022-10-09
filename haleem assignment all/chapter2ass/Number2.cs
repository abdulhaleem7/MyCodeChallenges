using System;
namespace chapter2ass
{
    class Number2
    {
        public static void Patience2()
        {
            Console.Write("enter a number:");
            int num = int.Parse(Console.ReadLine());
            bool not = true;

            if(num%5==0 && num % 7 == 0)
            {
                Console.WriteLine(not);
            }
            else
            {
                Console.WriteLine(not==false);
            }

        }
    }
}