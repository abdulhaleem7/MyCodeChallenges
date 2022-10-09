using System;

namespace chapter6ass
{
    class Number17
    {
        public static void patience17()
        {
            Console.Write("Enter first number: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = Int32.Parse(Console.ReadLine());

            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a %= b;
                }
                else
                {
                    b %= a;
                }
            }

            if (a == 0)
            {
                Console.WriteLine(b);
            }

            else
            {
                Console.WriteLine(a);
            }
        }
    }
}
