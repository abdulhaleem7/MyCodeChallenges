using System;

namespace chapter6ass
{
    class Number7
    {
        public static void patience7()
        {
            Console.Write("enter num1:");
            int n = int.Parse(Console.ReadLine());
            Console.Write("enter num2:");
            int k = int.Parse(Console.ReadLine());
            int NminusK = n - k;
            
            for (int i = n-1; i > 0; i--)
            {
                n*= i;
               
            }
           
            for (int j = k -1; j > 0; j--)
            {

                k *= j;
               
            }
           
            
            for (int i = NminusK -1;i > 0; i -- )
            {
                NminusK *= i;
            }
            Console.WriteLine("The result is " + n * k / NminusK);


        }
    }
}
