using System;
namespace assignment3
{
    class Number3
    {
        public static void patience3()
        {
            Console.Write("enter num1:");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("enter num2:");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("enter num3:");
            int num3 = int.Parse(Console.ReadLine());

            if(num1>num2 && num1 > num3)
            {
                Console.WriteLine($"the biggest is {num1 } between {num2 } and {num3} ");
            }
            if(num2>num1 && num2 > num3)
            {
                Console.WriteLine($"the biggest is {num2 } between {num1 } and {num3}");
            }
            if (num3 > num1 && num3 > num2)
            {
                Console.WriteLine($"the biggest is {num3 } between {num1 } and {num2}");
            }
        }
    }
}