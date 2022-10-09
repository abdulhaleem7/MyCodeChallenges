using System;
namespace assignment3
{
    class Number7
    {
        public static void patience7()
        {
            int max = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("enter next number:");
                int num = int.Parse(Console.ReadLine());
                if (num > max)
                {
                    max=num;
                }
               
            }
            Console.WriteLine(max);
        }
    }
}