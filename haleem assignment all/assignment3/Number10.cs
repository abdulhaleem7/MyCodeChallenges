using System;
namespace assignment3
{
    class Number10
    {
        public static void patience10()
        {

            Console.Write("input digit from 0 to 9 :");
            int num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine(num * 10);
                    break;

                case 4:
                case 5:
                case 6:
                    Console.WriteLine(num * 100);
                    break;

                case 7:
                case 8:
                case 9:
                    Console.WriteLine(num * 1000);
                    break;
            }
        }
    }
}