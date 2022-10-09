using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqAssignment
{
    class Program
    {
       

        static void Main(string[] args)
        {
            AllNumber();
        }
        public static void AllNumber()
        {
            Console.WriteLine("1.Number1\n" + "2.Number2\n" + "3.Number3\n" + "4.Number4\n" + "5.Number5\n" + "6.Number6\n" + "7.Number7\n");
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
                
                else
                {
                    break;
                }
            }

        }
        public static void Question1()
        {
            string word = "hello";
           var decl= word.Substrin( 1, 1);
            Console.WriteLine(decl);

        }
        public static void Question2()
        {
            List<int> num = new List<int>() { 1, 2, 3, 4 };
            Console.WriteLine("summation!!!");
            var number = num.addition();
            Console.WriteLine(number);
            Console.WriteLine("minimum!!!");
            var mini = num.Minimum();
            Console.WriteLine(mini);
            Console.WriteLine("maximum!!!");
            var maxi = num.Maximum();
            Console.WriteLine(maxi);
            Console.WriteLine("average!!!");
            var avera = num.Averag();
            Console.WriteLine(avera);
        }
        public static void Question3()
        {
            List<Student> students = new List<Student>()
            {
                new Student(){FirstName="ayomide",LastName="haleem",Age=16},
                new Student(){FirstName="oLaitan",LastName="Remi",Age =15,},
                new Student(){FirstName="wale",LastName="patience",Age =20,},
                new Student(){FirstName="qudus",LastName="gbolahan",Age =39,}
            };
            var cp = from stu in students where stu.FirstName.CompareTo(stu.LastName) >0 select stu;
            foreach (var item in cp)
            {
                Console.WriteLine(item.FirstName+"  "+item.LastName);
            }


        }
        public static void Question4()
        {
            List<Student> students = new List<Student>()
            {
                new Student(){FirstName="ayomide",LastName="haleem",Age=16},
                new Student(){FirstName="oLaitan",LastName="Remi",Age =21,},
                new Student(){FirstName="wale",LastName="patience",Age =20,},
                new Student(){FirstName="qudus",LastName="gbolahan",Age =39,}
            };
            var st = students.Where(s => s.Age > 18 && s.Age < 24);
            foreach (var item in st)
            {
                Console.WriteLine("Firstname: "+item.FirstName+" Lastname:  "+item.LastName);
            }
        }
        public static void Question5()
        {
            List<Student> students = new List<Student>()
            {
                new Student(){FirstName="ayomide",LastName="haleem",Age=16},
                new Student(){FirstName="oLaitan",LastName="Remi",Age =21,},
                new Student(){FirstName="wale",LastName="patience",Age =20,},
                new Student(){FirstName="qudus",LastName="gbolahan",Age =39,}
            };
            var stu = students.OrderBy(x => x.FirstName).ThenBy(x => x.LastName);
            foreach (var item in stu)
            {
                Console.WriteLine(item.FirstName+" "+item.LastName);
            }
            Console.WriteLine();
            var ex = from st in students orderby st.FirstName orderby st.LastName select st;
            foreach (var item in ex)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName );
            }
        }
        public static void Question6()
        {
            List<int> num = new List<int>() { 23, 21, 42 };
            var div = num.Where(x => x % 7 == 0 && x % 3 == 0);
            foreach (var item in div)
            {
                Console.WriteLine(item);
            }
            var ano = from n in num where n % 7 == 0 && n % 3 == 0 select n;
            foreach (var item in ano)
            {
                Console.WriteLine(item);
            }
        }
        public static void Question7()
        {
            string alpha = "this is a boy";
            var alp = alpha.Capit();
            Console.WriteLine(alp);
        }

       
    }
}
