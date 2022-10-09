using System;
namespace chapter1ass
{
    class Number13
    {
        public static void Patience13()
        {
            int a = 5;
            int b = 10;
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}