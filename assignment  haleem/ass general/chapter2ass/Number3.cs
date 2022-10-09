using System;
namespace chapter2ass
{
    class Number3
    {
        public static void Patience3()
        {
            Console.Write("enter your digits:");
            int num = int.Parse(Console.ReadLine());
            bool door = true;

            if ((num / 100) % 10 == 7)
            {
                Console.WriteLine(door);
            }
            else
            {
                Console.WriteLine(door == false);
            }

        }
    }
}