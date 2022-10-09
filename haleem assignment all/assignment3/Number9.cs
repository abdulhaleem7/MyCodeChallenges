using System;
namespace assignment3
{
    class Number9
    {
        public static void patience9()
        {
            Console.Write("enter num1:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("enter num2:");
            int b = int.Parse(Console.ReadLine());
            Console.Write("enter num3:");
            int c = int.Parse(Console.ReadLine());
            Console.Write("enter num4:");
            int d = int.Parse(Console.ReadLine());
            Console.Write("enter num5:");
            int e = int.Parse(Console.ReadLine());

            if (a + b == 0)
            {
                Console.WriteLine($"the subset is {a} and {b}");
            }
            if (a + c == 0)
            {
                Console.WriteLine($"the subset is {a} and {c}");
            }
            if (a + d==0)
            {
                Console.WriteLine($"the subset is {a} and {d}");
            }
            if (a + e == 0)
            {
                Console.WriteLine($"the subset is {a} and {e}");
            }
            if (b + c == 0)
            {
                Console.WriteLine($"the subset is {b} and {c}");
            }
            if (b + d == 0)
            {
                Console.WriteLine($"the subset is {b} and {d}");
            }
            if (b + e == 0)
            {
                Console.WriteLine($"the subset is {b} and {e}");
            }
            if (c + d == 0)
            {
                Console.WriteLine($"the subset is {c} and {d}");
            }
            if (c + e == 0)
            {
                Console.WriteLine($"the subset is {c} and {e}");
            }
            if (d + e == 0)
            {
                Console.WriteLine($"the subset is {d} and {e}");
            }
            if (a + b + c == 0)
            {
                Console.WriteLine($"the subset is {a} , {b} and {c}");
            }
            if (a + b + d == 0)
            {
                Console.WriteLine($"the subset is {a} , {b} and {d}");
            }
            if (a + b + e == 0)
            {
                Console.WriteLine($"the subset is {a} , {b} and {e}");
            }
            if (b + c + d == 0)
            {
                Console.WriteLine($"the subset is {b} , {c} and {d}");
            }
            if (b + c + e == 0)
            {
                Console.WriteLine($"the subset is {b} ,{c} and {e}");
            }
            if (c + d + e == 0)
            {
                Console.WriteLine($"the subset is {c} , {d} and {e}");
            }


        }
    }
}