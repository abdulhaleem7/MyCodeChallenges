using System;
namespace chapter2ass
{
    class Number8
    {
        public static void Patience8()
        {
            Console.Write("enter first number");
            int x = int.Parse(Console.ReadLine());
            Console.Write("enter second number:");
            int y = int.Parse(Console.ReadLine());
            bool check = true;

            if ((x * x) + (y * y) <= (5 * 5))
            {
                Console.WriteLine(true);
            }
            else if ((x * x) + (y * y) >= (5 * 5))
            {
                Console.WriteLine(check==false);
            }
        }
    }
}