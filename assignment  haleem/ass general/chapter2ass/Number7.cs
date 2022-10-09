using System;
namespace chapter2ass
{
    class Number7
    {
        public static void Patience7()
        {
            Console.Write("weight of man on EARTH: ");
            float moon = float.Parse(Console.ReadLine());

            double weight = (0.17) * moon;
            Console.WriteLine($"THE WEIGHT OF MAN ON MOON = " + weight);
        }
    }
}