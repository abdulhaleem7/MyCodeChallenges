using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DictionaryAss
{
    class Program
    {
        static void Main(string[] args)
        {

            Print();
        }
        public static void Question1()
        {
            Dictionary<int, int> num = new Dictionary<int, int>();
            int[] num2= { 1, 2, 3, 3, 2, 1, 4, 5, 6, };
            foreach (var item in num2)
            {
                if (num.ContainsKey(item))
                {
                    num[item] =num[item] + 1;
                }
                else
                {
                    num.Add(item, 1);
                }
            }
            foreach (var item in num)
            {
                Console.Write("num" + item.Key + " appaer" + item.Value);
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public static void Question2()
        {
            Dictionary<int,int> num = new Dictionary<int, int>();
            List<int> num2 = new List<int>() { 1, 2, 3, 3, 2, 1, 4, 5, 6, };
            foreach (var item in num2)
            {
                if (num.ContainsKey(item))
                {
                    num[item] = num[item] + 1;
                }
                else
                {
                    num.Add(item, 1);
                }
            }
            foreach (var item in num)
            {
                if ((int)item.Value % 2 == 0)
                {
                    for (int i = 0; i < (int)item.Value; i++)
                    {
                        Console.Write(item.Key+" , ");
                    }
                }
            }
        }
        public static void Question3()
        {
            string text = "This is the TEXT. Text, text, text - THIS TEXT! Is this the text?";
            var sign = text.Split('.', ' ', ',', '-', '?', '!');
            Dictionary<string, int> words = new Dictionary<string, int>();
            foreach (var item in sign)
            {
                if (item != "")
                {
                    string s = item.ToLower();
                    if (words.ContainsKey(s))
                    {
                        words[s] = words[s] + 1;
                    }
                    else
                    {
                        words.Add(s, 1);
                    }
                }
                
            }
            var result = words.OrderBy(x =>x.Value);
            foreach (var item in result)
            {
                Console.WriteLine($"word:{item.Key} appears:{item.Value} times");
            }
            
        }
        public static int IntReverse(int num)
        {
            
            int holder = 0;
            int normalhold = 0;
            
                while (Math.Abs(num)  > 0)
                {
                    normalhold = num % 10;
                    num = num / 10;
                    holder = holder * 10+normalhold;
                }
               
           
            return holder;
        }
        public static int Number(string alpha)
        {
            List<int> num = new List<int> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            int num2 = 0;
            int hold = 0;
            for(int i = 0; i <alpha.Length; i++)
            {
                for(int j = 0; j < num.Count; j++)
                {
                    if (alpha[i] == num[j])
                    {
                        hold = j;
                        num2 = num2 * 10 + hold;
                    }
                }
            }
            return num2;
        }
        public static void Print()
        {
            int hold = 0;
            List<int> num2 = new List<int>() {1,2,1,2,1,2,3,1,4 };
            Dictionary<int, int> num = new Dictionary<int, int>();
            foreach (var item in num2)
            {
                if (num.ContainsKey(item))
                {
                    num[item] = num[item] + 1;
                }
                else
                {
                    num.Add(item, 1);
                }
            }
            foreach (var item in num)
            {
               int add =  item.Value / 2 ;
                hold += add;
            }
            Console.WriteLine(hold);
        }
    }
}
