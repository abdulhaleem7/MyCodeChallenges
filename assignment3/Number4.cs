using System;
namespace assignment3
{
    class Number4
    {
        public static void patience4()
        {
            Console.Write("enter num1:");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("enter num2:");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("enter num3:");
            int num3 = int.Parse(Console.ReadLine());

            if (num1 > num3 )
            {
                num1 = num1 + num3;
                num3 = num1 - num3;
                num1 = num1 - num3;
              
            }
             if (num1 > num2)
            {
                num1 = num1 + num2;
                num2 = num1 - num2;
                num1 = num1 - num2;
              
            }

             if (num2 > num3)
            {
                num2 = num2 + num3;
                num3 = num2 - num3;
                num2 = num2 - num3;
                
          
            }
            Console.WriteLine($"the descending is {num1 } {num2 } {num3}");




        }
    }
}