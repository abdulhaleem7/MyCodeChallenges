using System;

namespace chapter6ass
{
    class Number6
    {
        public static void patience6()
        {
            Console.Write("enter num1:");
            int n = int.Parse(Console.ReadLine());
            Console.Write("enter num2:");
            int k = int.Parse(Console.ReadLine());
            int fac1 = 1;
            int fac2 = 1;
            int a = 0;
            int b = 0;
            for (int i = 1; i <= n; i++)
            {
                fac1 *= i;
                a = fac1;
            }
            Console.WriteLine(a);
            for (int j = 1; j<=k; j++)
            {

                 fac2 *= j;
                b = fac2;
            }
            Console.WriteLine(b);
            Console.WriteLine(a/ b);
        }
           
    }
}
