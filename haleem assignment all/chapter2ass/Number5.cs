using System;
namespace chapter2ass
{
    class Number5
    {
        public static void Patience5()
        {
            Console.Write("enter side:");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("enter another side:");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("enter a height:");
            int num3 = int.Parse(Console.ReadLine());

            int trapeziod = (num1 + num2) * num3 / 2;
            Console.WriteLine(trapeziod);
        }
    }
}