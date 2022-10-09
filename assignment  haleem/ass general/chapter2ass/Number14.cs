using System;
namespace chapter2ass
{
    class Number14
    {
        public static void Patience14()
        {

            Console.Write("enter you number:");
            int num = int.Parse(Console.ReadLine());

            for (int i = 2; i < num; i++)
            {
                for(int d=2; d < i / 2; d++)
                {
                    if(i%d==0)
                    {
                        Console.WriteLine("prime");
                    }
                    else if(i%d!=0)
                    {
                        Console.WriteLine("not prime");
                    }
                }
            }


            
        }
    }
}