using System;
namespace chapter2ass
{
    class Number6
    {
        public static void Patience6()
        {
            Console.Write("ENTER SIDE OF A RECTANGLE:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("ENTER HEIGHT OF A RECTANGLE: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double area = (a * b);
            double perimeter = 2 * (a + b);
            Console.WriteLine($"the area of a rectangle is " + area + "and the perimeter of a rectangle is " + perimeter);
        }
    }
}