using System;
namespace assignment3
{
    class Number8
    {
        public static void patience8()
        {
            Console.Write("enter 1 for name ,enter 2 for number and enter 3 for gp:");
            int digit = int.Parse(Console.ReadLine());
            switch (digit)
            {
                case 1:
                    Console.Write("write ur name:");
                    string name = Console.ReadLine();
                    Console.WriteLine($"{name}*");
                    break;

                case 2:
                    Console.Write("enter ur num:");
                    int num = int.Parse(Console.ReadLine());
                    Console.WriteLine(num + 1);
                    break;

                case 3:
                    Console.Write("enter your gp");
                    double gp = double.Parse(Console.ReadLine());
                    Console.WriteLine(gp + 1);
                    break;
            }
            

        }
    }
}