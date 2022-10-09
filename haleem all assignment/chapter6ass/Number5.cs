using System;

namespace chapter6ass
{
    class Number5
    {
        public static void patience5()
        {
            Console.Write("enter num:");
            int num = int.Parse(Console.ReadLine());
            int a = -1;
            int b = 1;
            int c = 0;
            int sum = 0;

            for (int i = 0; i <= num; i++)
            {
                c = a + b;
                sum += c;
                Console.WriteLine(c);

                a = b;
                b = c;
            }
            Console.WriteLine(sum);
        }
    }
}
