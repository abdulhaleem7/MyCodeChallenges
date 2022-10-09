using System;
namespace assignment3
{
    class Number2
    {
        public static void patience2()
        {
            Console.Write("enter num1:");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("enter num2:");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("enter num3:");
            int num3 = int.Parse(Console.ReadLine());

            if (num1 < 0 && num2 < 0 && num3 > 0)
            {
                Console.WriteLine("+");
            }
            else if (num1 < 0 && num2 > 0 && num3 < 0)
            {
                Console.WriteLine("+");
            }
            else if (num1 > 0 && num2 < 0 && num3 < 0)
            {
                Console.WriteLine("+");
            }
            else if (num1 > 0 && num2 < 0 && num3 < 0)
            {
                Console.WriteLine("+");
            }
            else if (num1 > 0 && num2 > 0 && num3 > 0)
            {
                Console.WriteLine("+");
            }
            else if (num1 < 0 && num2 > 0 && num3 > 0)
            {
                Console.WriteLine("-");
            }
            else if (num1 > 0 && num2 > 0 && num3 < 0)
            {
                Console.WriteLine("-");
            }
            else if (num1 < 0 && num2 < 0 && num3 < 0)
            {
                Console.WriteLine("-");
            }
            else if(num1<=0 && num2 <= 0 && num3 < 0)
            {
                Console.WriteLine("+");
            }



















































        }
        
    }
}
