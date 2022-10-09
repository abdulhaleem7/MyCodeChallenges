using System;
namespace chapter2ass
{
    class Number10
    {
        public static void Patience10()
        {

            Console.Write("enter digit:");
            int num = int.Parse(Console.ReadLine());


            int a = num % 10;
            int b = (num / 10) % 10;
            int c = (num / 100) % 10;
            int d = (num / 1000) % 10;

            Console.WriteLine(a + b + c + d);
            Console.WriteLine($"{a } {b } {c } {d }");
            Console.WriteLine($"{a } {d } {c } {b }");
            Console.WriteLine($"{d } {b } {c } {a }");
        }
    }
}