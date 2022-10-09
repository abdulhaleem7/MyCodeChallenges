using System;
namespace chapter7ass
{
    class number1
    {
        public static void patience1()
        { 

            int[] arr = new int[20];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i *5;
                Console.WriteLine(arr[i]);

            } 
        
        }
    }
}
