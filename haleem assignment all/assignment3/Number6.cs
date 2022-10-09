using System;
namespace assignment3
{
    class Number6
    {
        public static void patience6()
        {
            Console.Write("enter the co efficient of a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter co efficient of b");
            int b = int.Parse(Console.ReadLine());
            Console.Write("enter the co efficient of c");
            int c = int.Parse(Console.ReadLine());

            double discriminant = (b * b) - (4 * a * c);
            if (discriminant < 0)
            {
                Console.WriteLine("the quadratic equation as no real root");
            }
            else if (discriminant == 0)
            {
                double x12 = (-b / 2 * a);
                Console.WriteLine($"the two real number are of qudratic equation {x12}");
            }
            else if (discriminant > 0)
            {
                double w = ((-b + Math.Sqrt(discriminant)) / (2 * a));
                double y = ((-b - Math.Sqrt(discriminant)) / (2 * a));
                Console.WriteLine($"the first two real number is {w}");
                Console.WriteLine($"the second two real number is {y}");
            }

























        }
    }
}