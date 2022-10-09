using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace dictionary
{
    public class HackerRank
    {

        public void CountUpperCase()
        {
            string s = "oneTwoThree";
            string y = "";
            for (int i = 0; i < s.Length; i++)
            {
                y = char.ToUpper(s[0]) + s.Substring(1);
                break;
            }
            int count = 0;
            for (int i = 0; i < y.Length; i++)
            {
                if (char.IsUpper(y[i]))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
        public void SuperReduceString()
        {
            string s = "abba";
            List<char> alpha = new List<char>();
            foreach (var item in s)
            {
                alpha.Add(item);
            }
            int count = 1;
            while (count > 0)
            {
                if (alpha.Count == 0 || alpha.Count == 1)
                {
                    count = 0;
                    break;
                }
                for (int i = 0; i < alpha.Count - 1; i++)
                {
                    if (alpha[i] == alpha[i + 1])
                    {
                        alpha.RemoveRange(i, 2);

                        count = 1;
                        break;
                    }
                    else
                    {
                        count = 0;
                    }
                }
            }
            string final = "";
            foreach (var item in alpha)
            {
                final += item;
            }

            if (final == "")
            {
                Console.WriteLine("Empty String");
            }
            else
            {
                Console.WriteLine(final);
            }

        }
        public class AnagramEqualityComparer : IEqualityComparer<string>
        {
            public bool Equals(string x, string y) => getCanonicalString(x) == getCanonicalString(y);

            public int GetHashCode(string obj) => getCanonicalString(obj).GetHashCode();

            private string getCanonicalString(string word)
            {
                char[] wordChars = word.ToCharArray();
                Array.Sort<char>(wordChars);
                return new string(wordChars);
            }
        }
        public void MaximalSequence()
        {
            int[] nums = { 3, 2, 11, 1 };
            int[] removeQueries = { 3, 2, 1, 0 };
            int[] answer = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {

                nums[removeQueries[i]] = 0;
                int holder = 0;
                int firstHolder = 0;

                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[j] != 0)
                    {
                        holder += nums[j];
                    }

                }
                if (holder > firstHolder)
                {
                    firstHolder = holder;
                }
                answer[i] = firstHolder;
            }
            foreach (var item in answer)
            {
                Console.WriteLine(item);
            }

        }
        public void MaximalSegment2()
        {
            int[] nums = { 3, 2, 11, 1 };
            int[] removeQueries = { 3, 2, 1, 0 };
            var mp = new Dictionary<int, (long, int)>();
            var cur = 0L;
            var res = new List<long>();

            foreach (var q in removeQueries[1..].Reverse())
            {
                mp.Add(q, (nums[q], 1));

                (long rv, int rLen) = mp.TryGetValue(q + 1, out var value) ? value : (0, 0);
                (long lv, int lLen) = mp.TryGetValue(q - 1, out value) ? value : (0, 0);

                var total = nums[q] + rv + lv;
                mp[q + rLen] = (total, lLen + rLen + 1);
                mp[q - lLen] = (total, lLen + rLen + 1);

                cur = Math.Max(cur, total);
                res.Add(cur);
            }

            res.Reverse();
            res.Add(0);

            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
        }
        public void Richest()
        {
            int[][] richest = {
            new int[ ] {10, 20, 30},
            new int[ ] {11, 22},
            new int[ ] {88, 99}
            };
            List<int> highet = new List<int>();
            for (int i = 0; i < richest.Length; i++)
            {
                int c = richest[i].Sum();
                highet.Add(c);
            }

        }
        public  void Steps()
        {
            int num = 14;
            bool isTrue = true;
            int count = 0;
            while (isTrue)
            {
                if (num == 0)
                {
                    isTrue = false;
                }
                else
                {
                    if (num % 2 == 0)
                    {
                        num /= 2;
                        count++;
                    }
                    else if (num % 2 != 0)
                    {
                        num -= 1;
                        count += 1;
                    }
                }
            }
            Console.WriteLine(count);
        }
        public void TargetAgain()
        {
            int target = 19;
            int maxDoubles = 2;
            int count = 0;

            while (target > 1)
            {
                if (target % 2 == 0)
                {
                    if (maxDoubles != 0)
                    {
                        maxDoubles--;
                        count++;
                        target /= 2;
                    }
                    else
                    {
                        target--;
                        count += target;
                        break;
                    }
                }

                else
                {
                    target--;
                    count++;
                }
            }
            Console.WriteLine(count);
        }
        public void CodeChallenge()
        {


            List<int> rows = new List<int> { 2, 0, 3, 1 };
            int FormalCount = 0;
            int count = 0;
            for (int i = 1; i < rows.Count; i++)
            {
                int minus = Math.Abs(rows[i] - rows[i - 1]);
                if (minus > 1)
                {
                    count++;
                    if (count >= 2)
                    {
                        FormalCount++;
                        count = 0;
                    }

                }
            }
            Console.WriteLine(count);
        }
        public void AppleAndOrange()
        {
            int s = 7;
            int t = 9;
            int a = 4;
            int b = 12;
            List<int> apples = new List<int>() { 2, 3, -4 };
            List<int> oranges = new List<int>() { 3, -2, -4 };



            var apple = new List<int>();
            var orange = new List<int>();
            for (int i = 0; i < apples.Count; i++)
            {
                apple.Add(apples[i] + a);
            }

            int appleCount = apple.Where(x => x >= s && x <= t).Count();

            for (int i = 0; i < oranges.Count; i++)
            {
                orange.Add(orange[i] + b);
            }
            int orangeCount = orange.Where(x => x <= t && x >= s).Count();
            Console.WriteLine(appleCount);
            Console.WriteLine(orangeCount);
        }
        public void HackerRankIsAString()
        {
            string s="golakjkjsjkks";
            string hackerrank = "hackerrank";
            var chars = new List<char>() { 'h', 'a', 'c', 'k', 'e', 'r', 'r', 'a', 'n', 'k' };      
            var given = s.ToList();
            string empty = "";
            for (int i = 0; i < chars.Count; i++)
            {
                for (int j = 0; j < given.Count; j++)
                {
                    if (chars[i] == given[j])
                    {
                        empty += given[j];
                        given.RemoveRange(0, j + 1);
                        break;
                    }
                }
            }
            if (hackerrank == empty)
            {
                Console.WriteLine("YES"); 
            }
            else
            {
                Console.WriteLine("NO"); 
            }
        }
        public void Pangram()
        {
            string s = "ABCDE FGHIJk LMNOPQRSTUVWXYZ";
            List<char> alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower().ToCharArray().ToList();
            var given = s.ToLower().ToList();
            bool istrue = true;
            foreach (var item in alpha)
            {
                if (!given.Contains(item))
                {
                    istrue = false;
                    break;
                }
            }
            if (istrue)
            {
                Console.WriteLine("pangram");
            }
            else
            {
                Console.WriteLine("not pangram");
            }
        }
        public void FunnyString()
        {
            string s = "acxz";
            List<int> list = new List<int>();
            foreach (var item in s)
            {
                list.Add((int)item);
            }
            bool isFunny = true;
            List<int> first = new List<int>();
            for (int i = 0; i < list.Count - 1; i++)
            {
                first.Add(Math.Abs(list[i] - list[i + 1]));
            }
            List<int> second = new List<int>();
            for (int i = list.Count - 1; i > 0; i--)
            {
                second.Add(Math.Abs(list[i] - list[i - 1]));
            }
            for (int i = 0; i < second.Count; i++)
            {
                if (second[i] != first[i])
                {
                    isFunny = false;
                    break;
                }
            }
            if (isFunny)
            {
                Console.WriteLine("Funny");
            }
            else
            {
                Console.WriteLine("not funny");
            }
        }
        public void PickingNumbers()
        {
            int n = 1012;
            int f = n;
            var x = f.ToString();
            int count = 0;
            foreach (var item in x)
            {
                int t = int.Parse(item.ToString());
                if (t != 0)
                {
                    if ((n) % t == 0)
                    {
                        count++;
                    }
                }

            }

            Console.WriteLine(count);
        }
        public void SortBigInteger()
        {
            List<string> unsorted = new List<string>() { "23", "65255267827", "526554542442", "31415926535897932384626433832795" };

            List<string> x = unsorted.OrderBy(x => BigInteger.Parse(x)).ToList();
            foreach (var str in x)
            {
                Console.WriteLine(str);
            }
        }
        public void BetweenTwoArray()
        {
            List<int> a = new List<int>() { 3, 9, 6 };
            List<int> b = new List<int>() { 36, 72 };

            List<int> c = new List<int>();
            for (int i = a[a.Count - 1]; i <= b[0]; i++)
            {
                c.Add(i);
            }
            var f = b.Concat(a).ToList();

            int count = 0;
            int count2 = 0;
            for (int i = 0; i < c.Count; i++)
            {
                for (int j = 0; j < f.Count; j++)
                {
                    if (f[j] < c[i])
                    {
                        if (c[i] % f[j] == 0)
                        {
                            count++;
                        }
                    }
                    else
                    {
                        if (f[j] % c[i] == 0)
                        {
                            count++;
                        }
                    }

                }
                if (count == f.Count)
                {
                    count2++;

                }
                count = 0;
            }
            Console.WriteLine(count2);

        }
    }

}
