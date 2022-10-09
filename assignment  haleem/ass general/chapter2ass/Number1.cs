using System;
namespace chapter2ass
{
    class Number1
    {
        public static void patieence1()
        {
            Console.Write("enter a number:");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
    }
}