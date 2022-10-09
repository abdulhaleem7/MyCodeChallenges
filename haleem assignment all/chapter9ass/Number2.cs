using System;

namespace chapter9ass
{
    class Number2
    {
        public static void maxnum()
        {
            Console.WriteLine("enter 3 number: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int firstmax = maxmax(a, b);
            Console.WriteLine(maxmax(firstmax, c));

        }
        public static int maxmax(int a,int b)
        {
            int ans;
            if (a > b)
            {
                ans = a;
            }
            else
            {
                ans = b;
            }
            return ans;
        }
    }
}