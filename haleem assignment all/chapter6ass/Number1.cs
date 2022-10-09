using System;

namespace chapter6ass
{
    class Number1
    {
       public  static void patience1()
        {
            Console.Write("ENTER A NUMBER:");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
