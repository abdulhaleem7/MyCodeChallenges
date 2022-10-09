using System;
using System.Collections;
using System.Collections.Generic;

namespace CodingChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question1duplicate();
            // Question3missingnumber();
            //Question2stone();
            // Question4Palindrom();
            //BayoQuestion();
            // addition();
            // pal();
            //question();
            //longest();
            //addlong();
            //addition();
            //  division();
            //contigious();
            //Palindrom();
            // addition();
            //division1();
            // contigious();
            // palindrum1();
            //  common();
            // Duplicate();
            // harmonious();
            //anotrher();
            //commonalpha();
            Permutation();
        }

        static void Question1duplicate()
        {
            int[] numbers = { 1, 0, 2, 3, 4, 1, 0, 9 };




            int count = 0;
            string newnum = "";
            for (int i = 0; i < numbers.Length; i++)
            {
                newnum += numbers[i];
                if (numbers[i] == 0)
                {
                    count++;
                    newnum += numbers[i];

                }

            }
            string newAlpha = newnum.Substring(0, (newnum.Length - count));
            Console.WriteLine(newAlpha);
        }
        static void Question3missingnumber()
        {
            int[] number = { 2, 4 };
            int temp;
            string holder = " ";

            // int newnum = int.Parse(holder);
            for (int i = 0; i < number.Length; i++)
            {
                for (int j = i + 1; j < number.Length; j++)
                {
                    if (number[i] > number[j])
                    {
                        temp = number[i];
                        number[i] = number[j];
                        number[j] = temp;
                    }
                }
            }

            //12345679
            for (int i = 1; i < number.Length - 1; i++)
            {

                if (number[i + 1] - number[i] != 1)
                {
                    holder = (number[i + 1] - 1).ToString();

                    Console.WriteLine(holder);

                }



            }
            if (number.Length - number[number.Length - 1] == 1)
            {
                Console.WriteLine(number[number.Length - 1] + 1);
            }




        }
        static void Question2stone()
        {
            int[] number = { 18, 10, 8, 6, 4, 2 };
            int temp;
            for (int i = 0; i < number.Length; i++)
            {
                for (int j = i + 1; j < number.Length; j++)
                {
                    if (number[i] < number[j])
                    {
                        temp = number[i];
                        number[i] = number[j];
                        number[j] = temp;
                    }
                }
            }

            string replace = "";

            for (int i = 0; i < number.Length - 1; i++)
            {

                int add = number[i + 1];
                if (number[i] > number[i + 1])
                {
                    replace = (number[i] - number[i + 1]).ToString();
                    add = number[i] - number[i + 1];

                }

            }
            if (number.Length == 1)
            {
                Console.WriteLine(number[0]);
            }

            Console.WriteLine(replace);

        }
        static void Question4Palindrom()
        {
            string alpha = "bcbb";
            char[] newAlpha = alpha.ToCharArray();
            char temp;
            for (int i = 0; i < newAlpha.Length; i++)
            {
                for (int j = i + 1; j < newAlpha.Length; j++)
                {
                    if (newAlpha[i] > newAlpha[j])
                    {
                        temp = newAlpha[i];
                        newAlpha[i] = newAlpha[j];
                        (newAlpha[j]) = temp;
                    }
                }
            }
            int count = 1;
            for (int i = 1; i < newAlpha.Length; i++)
            {

                if (newAlpha[i] == newAlpha[i - 1])
                {
                    count++;
                }


            }

            Console.WriteLine(count);

        }
        static void BayoQuestion()
        {
            string name = "bayo";
            for (int i = name.Length - 1; i >= 0; i--)
            {
                Console.Write(name[i]);
            }

        }
        static void pal()
        {
            string alpha = "aba";
            char[] newalpha = alpha.ToCharArray();
            for (int i = 0; i < newalpha.Length; i++)
            {
                if (newalpha[i] == newalpha[newalpha.Length - i])
                {
                    Console.WriteLine(newalpha[i]);
                }
            }
        }
        static void longest()
        {

            int coin = 6;
            int s = 1;
            while (s <= coin)
            {
                coin -= s;
                s++;
            }
            Console.WriteLine(s - 1);
        }
        static void question()
        {
            List<int> num = new List<int>() { 1, 2, 2, 5, 3, 2, 3, 7 };
            SortedList<int, int> sort = new SortedList<int, int>();
            foreach (var x in num)
            {
                if (sort.ContainsKey(x))
                {
                    sort[x] = sort[x] + 1;
                }
                else
                {
                    sort.Add(x, 1);
                }
            }

            int count = 0;
            SortedList<int, int> number = new SortedList<int, int>();
            for (int i = 1; i < sort.Count - 1; i++)
            {
                if ((sort.Keys[i]) - (sort.Keys[i] - 1) == 1)
                {
                    if (sort.Values[i - 1] > count)
                    {
                        number.Add(sort.Keys[i - 1], 1);
                    }
                }
            }
            int result = 0;
            int secondcount = 0;
            int firstcount = 0;
            for (int i = 0; i < number.Count; i++)
            {
                firstcount = number.Keys[i];

            }
            if (firstcount > secondcount)
            {
                secondcount = firstcount;

            }
            if (secondcount > result)
            {
                result = secondcount;

            }
            Console.WriteLine(result);
            Console.WriteLine(secondcount);
        }
        static void addlong()
        {
            int[] num = { 1, 5, 3, 4, 2 };
            int temp;
            for (int i = 0; i <num.Length; i++)
            {
                for (int j =i+1 ; j < num.Length; j++)
                {
                    if (num[i] > num[j])
                    {
                        temp = num[i];
                        num[i] = num[j];
                        num[j] = temp;
                    }

                }
            }
            int minimum = 0;
            int maximum = 0;
            int count = 0;
            for (int i = 0; i < 5; i++)
            {
                count++;
                if (count == 5)
                    break;
                minimum +=num[i];
                maximum += num[i + 1];
            }
            Console.WriteLine("longest minimum");
            Console.WriteLine(minimum);
            Console.WriteLine("longest maximum");
            Console.WriteLine(maximum);
        }
        static void addlong2()
        {
            List<int> arr = new List<int>() { 2, 3, 4, 5, 6 };
            int temp;
            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = i + 1; j < arr.Count; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }

                }
            }
            long minimum = 0;
            long maximum = 0;
            for (int i = 0; i < 5 - 1; i++)
            {

                minimum += arr[i];

            }
            for (int j = 1; j < 5; j++)
            {
                maximum += arr[j];
            }
            Console.WriteLine($"{minimum} {maximum}");


        }
    
        static void addition()
        {
            int[] num = { 10, 2, 5, 3 };

            bool isdivisor = false;
            for (int i = 0; i < num.Length; i++)
            {

                for (int j = 0; j < num.Length; j++)
                {
                    if (num[i] == num[j] * 2)
                    {
                        isdivisor = true;
                    }


                }

            }
            Console.WriteLine(isdivisor);
        }
        static void division()
        {
            int num = 21;
            int div = 0;
            int sum = 0;
            bool iseqaul = true;
            for (int divider = 1; divider <= num / 2; divider++)
            {
                if (num % divider == 0)
                {
                    div = divider;
                    sum += divider;

                    // Console.Write(div+ " ");

                }

            }
            if (sum == num)
            {

            }
            else
            {
                iseqaul = false;
            }
            Console.WriteLine(iseqaul);

        }
        static void contigious()
        {



            int[] num = { 1, 12, -5, -6, 50, 3 };
            //int max;
            int k = 4;
            double y = 0;
            int sum = 0;
            for (int i = 0; i <= num.Length - k; i++)
            {


                // int sum = 0;
                sum = 0;
                for (int j = i; j < k + i; j++)
                {

                    sum += num[j];

                }
                if (sum > y)
                {
                    y = sum;
                }


            }
            Console.WriteLine(y / k);

        }
        public static void Palindrom()
        {
            var s = "levvelt";
            if (Ispalindrome(s))
            {
                Console.WriteLine(true);
                return;
            }
            for (int i = 0; i < s.Length; i++)
            {
                var newstring = s.Remove(i, 1);
                if (Ispalindrome(newstring))
                {
                    Console.WriteLine(true);
                    return;
                }
            }
            Console.WriteLine(false);
        }
        static bool Ispalindrome(string s)
        {


            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - 1 - i])
                {
                    return false;
                }

            }
            return true;
        }
        static void addition1()
        {
            int[] num = { 10, 0, 7, 3 };

            bool isdivisor = false;
            for (int i = 0; i < num.Length; i++)
            {

                for (int j = 0; j < num.Length; j++)
                {
                    if (num[i] == num[j] * 2)
                    {
                        isdivisor = true;
                    }


                }

            }
            Console.WriteLine(isdivisor);
            /* var c =int.TryParse("na",out int message);
            Console.WriteLine(c);*/
            //Console.Write("enter num: ");
            /* string age = Console.ReadLine();
             var num = int.TryParse(age, out int value);
             while (num==false)
             {
                 Console.Write("enter num: ");
                 age = Console.ReadLine();
                 num = int.TryParse(age, out value);
             }*/

        }

        static void division2()
        {
            int num = 21;
            int div = 0;
            int sum = 0;
            bool iseqaul = true;
            for (int divider = 1; divider <= num / 2; divider++)
            {
                if (num % divider == 0)
                {
                    div = divider;
                    sum += divider;

                    // Console.Write(div+ " ");

                }

            }
            if (sum == num)
            {

            }
            else
            {
                iseqaul = false;
            }
            Console.WriteLine(iseqaul);

        }
        static void contigious1()
        {



            int[] num = { 1, 12, -5, -6, 50, 3 };
            //int max;
            int k = 4;
            double y = 0;
            int sum = 0;
            for (int i = 0; i <= num.Length - k; i++)
            {


                // int sum = 0;
                sum = 0;
                for (int j = i; j < k + i; j++)
                {

                    sum += num[j];

                }
                if (sum > y)
                {
                    y = sum;
                }


            }
            Console.WriteLine(y / k);

        }
        static void palindrum()
        {
            Hashtable table = new Hashtable();
            string text = "leal";
            foreach (var c in text)
            {
                if (table.ContainsKey(c))
                {
                    table[c] = (int)table[c] + 1;
                }
                else
                {
                    table.Add(c, 1);
                }
            }
            int max = 0;
            bool isvalid = true;
            foreach (DictionaryEntry entry in table)
            {
                if ((int)entry.Value % 2 == 0)
                {
                    continue;

                }
                else
                {
                    max++;
                }
                if (max > 1)
                {
                    isvalid = false;
                    break;
                }

            }
            Console.WriteLine(isvalid ? "form palindrom" : "not pallindrom");
        }
        static void common()
        {
            Hashtable table = new Hashtable();
            int[] num = { 1, 2, 3, 1 };

            var isvalid = false;
            foreach (var c in num)
            {
                if (table.ContainsKey(c))
                {
                    isvalid = true;
                    break;
                }
                table.Add(c, 1);
            }

            Console.WriteLine(isvalid);

        }
        static void Eatery()
        {
            var list1 = new string[] { "bat", "express", "buger", "kfc" };
            var list2 = new string[] { "bat", "honda", "buger", "yun" };

        }
        static void Duplicate()
        {

            List<int> num = new List<int>() { 4, 1, 1, 6, 1, 2, 4, 6 };
            SortedList<int, int> sort = new SortedList<int, int>();
            foreach (var x in num)
            {
                if (sort.ContainsKey(x))
                {
                    sort[x] = sort[x] + 1;
                }
                else
                {
                    sort.Add(x, 1);
                }
            }
            foreach (var number in sort)
            {
                if (number.Value > 1)
                {
                    Console.WriteLine($"number..{number.Key}  appears..{number.Value} times");
                }
            }






            /* List<int> num = new List<int>() { 4, 1, 1, 6, 1, 2, 4, 6 };
             Hashtable table = new Hashtable();

             foreach (var nums in num)
             {
                 if (table.ContainsKey(nums))
                 {
                     table[nums] = (int)table[nums] + 1;
                 }
                 else
                 {
                     table.Add(nums, 1);
                 }
             }


                 foreach (DictionaryEntry tab in table)
                 {
                     if ((int)tab.Value > 1)
                     {

                         Console.WriteLine($"value..{tab.Key} appear..{tab.Value}");
                     }
                 }*/





            /* List<int> num = new List<int>() { 4, 1, 1, 6, 1, 2, 4,6 };
             SortedList<int, int> num1 = new SortedList<int, int>();
             foreach (var item in num)
             {
                 if (num1.ContainsKey(item))
                 {
                     num1[item] = num[item] + 1;
                 }
                 else
                 {
                     num1.Add(item, 1);
                 }
             }
             foreach (var k in num1)
             {
                 Console.Write(k.Key);
             }
             Console.WriteLine();
             foreach (var v in num1)
             {
                 Console.Write(v.Value);
             }
 */

        }
        static void commonalpha()
        {
            int c = 5;
            int s = 1;
            while (s <= c)
            {
                c -= s;
                s++;
            }
            Console.WriteLine(s - 1);
        }
        static void harmonious()
        {


            List<int> num = new List<int>() { 1, 2, 2, 5, 3, 2, 3, 7 };
            SortedList<int, int> sort = new SortedList<int, int>();
            foreach (var x in num)
            {
                if (sort.ContainsKey(x))
                {
                    sort[x] = sort[x] + 1;
                }
                else
                {
                    sort.Add(x, 1);
                }
            }

            int h = 0;
            int hold = 0;
            int count = 0;
            for (int i = 1; i < sort.Count - 1; i++)
            {
                if ((sort.Keys[i]) - (sort.Keys[i] - 1) == 1)
                {
                    if (sort.Values[i] - 1 > count)
                    {
                        count = sort.Values[i] - 1;
                    }

                }
            }
            if (count > hold)
            {
                hold = count;
                //count = 0;
            }
            if (hold > h)
            {
                h = hold;
                hold = count;
            }
            Console.WriteLine(h + hold);




        }
        static void anotrher()
        {
            int[] number = { 1, 3, 2, 2, 5, 2, 3, 7 };
            int temp;
            for (int i = 0; i < number.Length; i++)
            {
                for (int j = i + 1; j < number.Length; j++)
                {
                    if (number[i] > number[j])
                    {
                        temp = number[i];
                        number[i] = number[j];
                        number[j] = temp;
                    }
                }
            }
            //int maximumCount = 1;
            int currentCount = 1;
            //int num = 0;
            for (int x = 1; x < number.Length - 1; x++)
            {
                if (number[x] - number[x - 1] == 1 || number[x] == number[x + 1])
                {
                    currentCount++;
                }

            }
            Console.WriteLine(currentCount);
        }
        public static void HackkerRank()
        {
            List<int> num = new List<int>() { 1, 2, 2, 5, 3, 2, 3, 7, 7 };
            SortedList<int, int> sort = new SortedList<int, int>();
            foreach (var x in num)
            {
                if (sort.ContainsKey(x))
                {
                    sort[x] = sort[x] + 1;
                }
                else
                {
                    sort.Add(x, 1);
                }
            }
            Console.WriteLine(sort.Values[sort.Count - 1]);
        }
        public static void HackerRank2()
        {

            int[] num = { 1, 3, 2, 6, 1, 2 };
            int count = 0;
            for (int i = 0; i < num.Length; i++)
            {
                for (int j = 0; j < num.Length; j++)
                {
                    if (i != j)
                    {
                        if ((num[i] + num[j]) % 3 == 0)
                        {
                            count++;


                        }
                    }
                }
            }
            Console.WriteLine(count / 2);
        }
        public static void HackerRank3()
        {
            int[] num = { 2, 4 };
            int[] num1 = { 16, 32, 96 };

        }
        public static void Permutation()
        {
            /*string s1 = "ab";
            string s2 = "aidbabooo";
            string s3 = s1;
            var cont = s2.Contains(s3);
            Console.WriteLine(cont);*/

            
        }

    }
}