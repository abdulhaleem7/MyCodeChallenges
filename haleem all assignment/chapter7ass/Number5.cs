using System;
namespace chapter7ass
{
    class number5
    {
        public static void patience5()
        { 
            int[] numbers = { 3,4,5,6,7, 2, 3, 4, 2, 2, 4,5,6,7,3 };
            string number = "";
            int maximumCount = 0;
            int currentCount = 1;
            string num = "";
            for (int x = 0; x < numbers.Length - 1; x++)
            {
                if (numbers[x] - numbers[x + 1] == -1)
                {
                    currentCount++;
                    number += numbers[x];
                }
                else
                {

                    if (currentCount > maximumCount)
                    {
                        maximumCount = currentCount;
                        number += numbers[x];
                        num = number;
                    }
                    number = "";
                    currentCount = 1;
                }
                if(numbers.Length-2 == x)
                {
                    if (currentCount > maximumCount)
                    {

                        maximumCount = currentCount;
                        number += numbers[x+1];
                        num = number;
                    }
                }
            }
            Console.WriteLine(num);
        }
    }
}
