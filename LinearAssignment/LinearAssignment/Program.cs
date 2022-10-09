
using System;
using System.Collections;
using System.Collections.Generic;

namespace LinearAssignment
{
    class Program
    {
        

        static void Main(string[] args)
        {

            AllNumber();
        }
        public static void AllNumber()
        {
            Console.WriteLine("1.Number1\n" + "2.Number2\n" + "3.Number3\n"+ "4.Number4\n" + "5.Number5\n" + "6.Number6\n" + "7.Number7\n" +
                 "8.Number8\n"+ "9.Number9\n" + "10.Number10\n");
            while (true)
            {
                Console.Write("Qustion: ");
                int respond = int.Parse(Console.ReadLine());
                if (respond == 1)
                {
                    Question1();
                }
                else if (respond == 2)
                {
                    Question2();
                }
                else if (respond == 3)
                {
                    Question3();
                }
                else if (respond == 4)
                {
                    Question4();
                }
                else if (respond == 5)
                {
                    Question5();
                }
                else if (respond == 6)
                {
                    Question6();
                }
                else if (respond == 7)
                {
                    Question7();
                }
                else if (respond == 8)
                {
                    Question8();
                }
                else if (respond == 9)
                {
                    Question9();
                }
                else if (respond == 10)
                {
                    Question10();
                }
                else 
                {
                    break;
                }
            }

        }
        public static void Question1()
        {
            List<int> num = new List<int>() { };
            double sum = 0;
            for (int i = 0; true; i++)
            {
                Console.Write("ENTER YOUR NUM:");
                string num1 = Console.ReadLine();
                if (num1 != " ")
                {
                    int num2 = int.Parse(num1);
                    num.Add(num2);
                    sum += num2;
                }
                else
                {
                    break;
                }


            }
            Console.WriteLine(sum);
            Console.WriteLine(sum / 2);
        }
        public static void Question2()
        {
            Stack<int> num1 = new Stack<int>() { };
            Console.Write("ENTER NUM TO CHECK: ");
            int num2 = int.Parse(Console.ReadLine());
            for (int i = 0; i < num2; i++)
            {
                Console.Write("ENTER NUMBER:");
                int num3 = int.Parse(Console.ReadLine());
                num1.Push(num3);
            }
            foreach (var item in num1)
            {
                Console.WriteLine(item);
            }
        }
        public static void Question3()
        {
            List<int> num = new List<int>() { };
            int temp;
            for (int i = 0; true; i++)
            {
                Console.Write("ENTER YOUR NUM:");
                string num1 = Console.ReadLine();
                if (num1 != " ")
                {
                    int num2 = int.Parse(num1);
                    num.Add(num2);
                }
                else
                {
                    break;
                }
            }
            for (int i = 0; i < num.Count; i++)
            {
                for (int j= i+1; j < num.Count; j++)
                {
                    if (num[i] > num[j])
                    {
                        temp = num[i];
                        num[i] = num[j];
                        num[j] = temp;
                    }
                }
            }
            foreach (var item in num)
            {
                Console.WriteLine(item);
            }
            
        }
        public static void Question4()
        {
            List<int> num = new List<int>() { 1, 1, 1, 2, 2, 2, 3, 5, 4, 3, 3, };
            int holder = 0;
            int maxcount = 0;
            int secondcount = 0;
            int count = 0;
            for (int i = 1; i <= num.Count-1; i++)
            {               
                if (num[i] == num[i - 1])
                {
                    count++;
                    secondcount = count;                   
                }
                else
                {
                   count = 0;
                }
                if (secondcount > maxcount)
                {
                    holder = num[i - 1];
                    maxcount = secondcount;
                    secondcount = 0;
                }
            }
            List<int> num4 = new List<int>() { };
            for (int i = 0; i <=maxcount; i++)
            {
                num4.Add(holder);
            }
            foreach (var item in num4)
            {
                Console.WriteLine(item);
            }
        }
        public static void Question5()
        {
            List<int> num = new List<int>() { };
            Console.Write("ENTER AMOUNT OF NUMBER: ");
            int num1 = int.Parse(Console.ReadLine());
            for (int i = 0; i < num1; i++)
            {
                Console.Write("enter num: ");
                int num3 = int.Parse(Console.ReadLine());
                if (num3 > 0)
                {
                    num.Add(num3);
                }
            }
            foreach (var item in num)
            {
                Console.WriteLine(item);
            }
        }
        public static void Question6()
        {
            Hashtable num = new Hashtable() { };
            List<int> num2 = new List<int>() { 1, 2, 3, 3, 2, 1, 4, 5, 6, };
            foreach (var item in num2)
            {
                if (num.ContainsKey(item))
                {
                    num[item] = (int)num[item] + 1;
                }
                else
                {
                    num.Add(item, 1);
                }
            }
            foreach (DictionaryEntry item in num)
            {
               if ((int)item.Value % 2 == 0)
               {
                    for (int i = 0; i < (int)item.Value; i++)
                    {
                        Console.WriteLine(item.Key);
                    }
               }
            }
        }
        public static void Question7()
        {
            Hashtable num = new Hashtable() { };
            List<int> num2 = new List<int>() { 1, 2, 3, 3, 2, 1, 4, 5, 6, };
            foreach (var item in num2)
            {
                if (num.ContainsKey(item))
                {
                    num[item] = (int)num[item] + 1;
                }
                else
                {
                    num.Add(item, 1);
                }
            }
            foreach (DictionaryEntry item in num)
            {
                Console.Write("num"+item.Key+" appaer"+item.Value);
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public static void Question8() 
            
        {

            Hashtable num = new Hashtable() { };
            List<int> num2 = new List<int>() { 2, 2, 3, 3, 2, 3, 4, 3, 3 };
            foreach (var item in num2)
            {
                if (num.ContainsKey(item))
                {
                    num[item] = (int)num[item] + 1;
                }
                else
                {
                    num.Add(item, 1);
                }
            }
            foreach (DictionaryEntry item in num)
            {
                if ((int)num2.Count / 2 + 1 == (int)item.Value)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }
        public static void Question9()
        {

            List<int> num = new List<int>() { };
            double end = 50;
            int s1 = 2;
            num.Add(s1);           
            for (int i = 1; i <end; i++)
            {
                if (num.Count > end)
                {
                    break;
                }
                else 
                {
                    int s2 = s1 + 1;
                    int s3 = 2 * s1 + 1;
                    int s4 = s1 + 2;
                    num.Add(s2);
                    num.Add(s3);
                    num.Add(s4);
                    s1 = num[i];                    
                }
            }
            Queue myqueue = new Queue() { };
            foreach (var item in num)
            {
                if (myqueue.Count == end)
                {
                    break;
                }
                else
                {
                    myqueue.Enqueue(item);
                }
            }
            foreach (var item in myqueue)
            {             
                Console.Write(item + ",");
            }         
        }
        public static void Question10() 
        {
            
            Queue<int> queue = new Queue<int>();
            int m = 16;
            int y = 5;
            
            queue.Enqueue(y);
            while (true)
            {
                int n = queue.Dequeue();
                if(!queue.Contains(y))
                {
                    queue.Enqueue(y);
                }
                if(((n + 2)<m)&& !queue.Contains(n +2))
                {
                    queue.Enqueue(n + 2);
                }
                if (((n * 2) < m) && !queue.Contains(n * 2))
                {
                    queue.Enqueue(n * 2);
                }

                if (((n + 1) < m) && !queue.Contains(n + 2))
                {
                    queue.Enqueue(n + 1);
                }
                else
                {
                    queue.Enqueue(m);
                    break;
                }            
            }          
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }
       /* public static void Question11()
        {
            DynamicList<int> alpha = new DynamicList<int>();
            alpha.Add(3);
            alpha.Add(3);
            alpha.Add(3);
            alpha.Add(3);
           
            

        }*/

    }
}
