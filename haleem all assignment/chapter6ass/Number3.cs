using System;

namespace chapter6ass
{
    class Number3
    {
        public static void patience3()
        {
            Console.Write("enter number of digit you want to check:");
            int num = int.Parse(Console.ReadLine());
            int min = 0;
            int max = 0;
            int ans;

            for (int i = 0; i <= num; i++)
            {
                Console.Write("enter you digit:");
                int num1 = int.Parse(Console.ReadLine());
                if (num1 == 0)
                {

                    if (num1 < min)
                    {
                        Console.WriteLine(min = ans);
                    }

                    else
                    {
                        Console.WriteLine(max = ans);
                    }
                }
                Console.WriteLine(ans);
            }
        }
    }
}
