using System;
namespace assignment3
{
    class Number1
    {
        public static void patience1()
        {
            Console.Write("enter num1:");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("enter num2:");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                num1 = num1 + num2;
                num2 = num1 - num2;
                num1 = num1 - num2;
                Console.WriteLine(num1);
                Console.WriteLine(num2);
            }
            
        }
    }

}
