using System;
namespace chapter7ass
{
    class number2
    {
        public static void patience2()
        {
            Console.Write("enter array num1: ");
            int array1 = int.Parse(Console.ReadLine());
            Console.Write("entter array num2: ");
            int array2 = int.Parse(Console.ReadLine());

            int[] num1 = new int[array1];
            int[] num2 = new int[array2];
            Console.WriteLine("enter your index 1: ");
            for(int i = 0; i < num1.Length; i++)
            {

                num1[i] = int.Parse(Console.ReadLine());
                
            }
            Console.WriteLine("enter your index 2: ");
            for(int j = 0; j < num2.Length; j++)
            {
                num2[j] = int.Parse(Console.ReadLine());
                
            }
            int found = 0;
            int notFound = 0;
            if (num1.Length == num2.Length)
            {
                for(int w = 0; w < num1.Length; w++)
                {
                    if (num1[w] == num2[w])
                    {
                        found++;
                    }
                    else
                    {
                        notFound++;
                    }
                }
                if (found == num1.Length)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
           
        }
        
    }
}
