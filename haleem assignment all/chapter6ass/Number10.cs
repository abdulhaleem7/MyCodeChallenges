using System;

namespace chapter6ass
{
    class Number10
    {
        public static void patience10()
        {
           
            Console.Write("Enter Num1: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= i; j++)
                {
                    Console.Write(" "+ j);
                }
                Console.WriteLine();
            }


        }
    }
}
