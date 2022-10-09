using System;
namespace chapter7ass
{
    class number4
    {
        public static void patience4()
        {
            Console.Write("Enter the lenght of the array : ");
            int count = int.Parse(Console.ReadLine());
            int[] numbers = new int[count];


            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Enter number: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int maximumCount = 1;
            int currentCount = 1;
            int num = 0;
            for (int x = 0; x < numbers.Length - 1; x++)
            {
                if (numbers[x] == numbers[x + 1])
                {
                    currentCount++;
                }
                else
                {
                    currentCount = 1;
                }
                if (currentCount > maximumCount)
                {
                    maximumCount = currentCount;
                    num = numbers[x];
                }
            }
            for (int x = 0; x < maximumCount; x++)
            {
                Console.Write(num);
            }

        }
    }
}