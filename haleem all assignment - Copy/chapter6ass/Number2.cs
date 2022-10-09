using System;

namespace chapter6ass
{
    class Number2
    {
        public static void patience2()
        {
            Console.WriteLine("enter a number:");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i <= num; i++)
            {
                if (i % 7 != 0 && i % 3 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
