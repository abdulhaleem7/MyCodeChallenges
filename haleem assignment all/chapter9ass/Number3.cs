using System;

namespace chapter9ass
{
    class Number3
    {
        public static void English()
        {
            Console.Write("enter number;");
            int number = int.Parse(Console.ReadLine());

            Num(number);
        }
        public static void Num(int num)
        {
            int holder = 0;
            num = num % 10;
            holder = num;
            
            switch (holder)
            {
               
                case 1:
                    Console.WriteLine("one");
                   
                    break;
                case 2:
                    
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                case 4:
                    Console.WriteLine("four");
                    break;
                case 5:
                    Console.WriteLine("five");
                    break;
                case 6:
                    Console.WriteLine("six");
                    break;
                case 7:
                    Console.WriteLine("seven");
                    break;
                case 8:
                    Console.WriteLine("eight");
                    break;
                case 9:
                    Console.WriteLine("nine");
                    break;

                   
            }
        }










  } 
}