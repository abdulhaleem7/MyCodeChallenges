using System;
using System.Collections.Generic;
using System.Linq;
namespace LinqQuerry2
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        public static void example7()
        {
            List<Student> students = new List<Student>()
             {
                 new Student(){Id=1,FirstName="haleem",Age=18,Country="canada",Gender="male",Courses=new List<string>(){ "csharp","java","python"} },
                 new Student(){Id=2,FirstName="qayyum",Age=30,Country="nigeria",Gender="male",Courses=new List<string>(){ "csharp","agric","c++"} },
                 new Student(){Id=3,FirstName="aminat",Age=14,Country="usa",Gender="female",Courses=new List<string>(){ "math","eng","chemistry"} },
                 new Student(){Id=4,FirstName="maryam",Age=16,Country="india",Gender="female",Courses=new List<string>(){ "html","java","python"} }
             };
            //var a = students.OrderByDescending(x => x.FirstName).ThenBy(y=>y.Age);
            var a = from stu in students orderby stu.FirstName, stu.Age descending select stu.FirstName;

            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
        }
        public static void sixthExample()
        {
            List<int> newint1 = new List<int>() { 1, 2, 9, 4, 5, 6, };
            List<int> newint2 = new List<int>() { 1, 2, 3, 4, 5, 7, };
            List<int> newint3 = new List<int>() { 1, 19, 3, 4, 18, 7, };
            var testlist = newint1.Concat(newint2).Distinct().OrderBy(x => x);
            foreach (var item in testlist)
            {
                Console.Write(item + " ");
            }

        }
        public static void FifthExample()
        {
            List<Student> students = new List<Student>()
             {
                 new Student(){Id=1,FirstName="haleem",Age=18,Country="canada",Gender="male",Courses=new List<string>(){ "csharp","java","python"} },
                 new Student(){Id=2,FirstName="qayyum",Age=30,Country="nigeria",Gender="male",Courses=new List<string>(){ "csharp","agric","c++"} },
                 new Student(){Id=3,FirstName="aminat",Age=14,Country="usa",Gender="female",Courses=new List<string>(){ "math","eng","chemistry"} },
                 new Student(){Id=4,FirstName="maryam",Age=16,Country="india",Gender="female",Courses=new List<string>(){ "html","java","python"} }
             };
            List<Object> student = new List<object>() { "rr", 6, 4, 7, "tt", 5, 'u' };
            var a = from stu in student where stu is string select stu;
            var b = student.OfType<int>().Where(x => x > 4).Sum();
            Console.WriteLine(b);

            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
        }
        public static void FourthExample()
        {
            List<Student> students = new List<Student>()
          {
              new Student(){Id=1,FirstName="haleem",Age=18,Country="canada",Gender="male",Courses=new List<string>(){ "csharp","java","python"} },
              new Student(){Id=2,FirstName="qayyum",Age=30,Country="nigeria",Gender="male",Courses=new List<string>(){ "csharp","agric","c++"} },
              new Student(){Id=3,FirstName="aminat",Age=14,Country="usa",Gender="female",Courses=new List<string>(){ "math","eng","chemistry"} },
              new Student(){Id=4,FirstName="maryam",Age=16,Country="india",Gender="female",Courses=new List<string>(){ "html","java","python"} }
          };
            var allcourses = students.Where(g => g.Gender == "male").SelectMany(x => x.Courses).Distinct().Count();
            Console.WriteLine(allcourses);
            Console.WriteLine("reverse");
            var allcourse = students.Where(g => g.Gender == "male").SelectMany(x => x.Courses).Distinct().Reverse();
            foreach (var item in allcourse)
            {
                Console.WriteLine(item);
            }
            var x = (from student in students from course in student.Courses select course).Distinct();
            foreach (var item in x)
            {
                Console.WriteLine(item);
            }
            var y = (from student in students from course in student.Courses select course).Distinct().Count();
            Console.WriteLine(y);
            List<string> Stringlist = new List<string>() { "ade", "tolu", "adeolu" };
            var all = from str in Stringlist from letter in str select letter;
            foreach (var item in all)
            {
                Console.WriteLine(item);
            }
            var a = students.SelectMany(x => x.Courses).Distinct().SelectMany(s => s).Distinct().ToArray();
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }


        }
        public static void Example()
        {
            List<int> IntegerList = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            var greaterthan = from num in IntegerList where num > 3 || num % 2 == 0 select num * num;
            foreach (var r in greaterthan)
            {
                //Console.WriteLine(r);
            }
            var all = IntegerList.Where(num => num % 2 == 0).ToList();
            foreach (var item in all)
            {
                //Console.WriteLine(item*2);
            }
            Console.WriteLine();
            var summall = IntegerList.TakeWhile(num => num > 3);
            foreach (var item in summall)
            {
                Console.WriteLine(item);
            }
        }
        public static void SecondExample()
        {
            List<Student> students = new List<Student>()
          {
              new Student(){Id=1,FirstName="haleem",Age=18,Country="canada",Gender="male"},
              new Student(){Id=2,FirstName="qayyum",Age=30,Country="nigeria",Gender="male"},
              new Student(){Id=3,FirstName="aminat",Age=14,Country="usa",Gender="female"},
              new Student(){Id=4,FirstName="maryam",Age=16,Country="india",Gender="female"}
          };


            Console.WriteLine("all male average student age");
            var AllAverageMale = students.Where(a => a.Gender == "male").Sum(s => s.Age / 2);
            Console.WriteLine(AllAverageMale);
            Console.WriteLine("all age divide by 2");
            var AllVerageDevideByTwo = students.Sum(s => s.Age / 2);
            Console.WriteLine(AllVerageDevideByTwo);
            Console.WriteLine("all female");
            var AllFemale = from student in students where student.Gender == "female" select student;
            foreach (var item in AllFemale)
            {
                Console.WriteLine(item.FirstName);

            }
            Console.WriteLine();
            Console.WriteLine("all male");
            var AllMale = from student in students where student.Gender == "male" select student.FirstName;
            foreach (var item in AllMale)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("age greater than 14");
            var sumallagegreaterthan14 = (from stu in students where stu.Age > 14 && stu.Country == "nigeria" select stu.Age).Sum();
            Console.WriteLine(sumallagegreaterthan14);
            Console.WriteLine("contain a");
            var containA = from student in students where student.FirstName.StartsWith('a') select student;
            foreach (var item in containA)
            {
                Console.WriteLine(item.FirstName);
            }
        }
        public static void ThirdExample()
        {
            List<Student> students = new List<Student>()
          {
              new Student(){Id=1,FirstName="haleem",Age=18,Country="canada",Gender="male"},
              new Student(){Id=2,FirstName="qayyum",Age=30,Country="nigeria",Gender="male"},
              new Student(){Id=3,FirstName="aminat",Age=14,Country="usa",Gender="female"},
              new Student(){Id=4,FirstName="maryam",Age=16,Country="india",Gender="female"}
          };
            var newList = from student in students
                          select new Studentt()
                          {

                              Age = student.Age,
                              Name = student.FirstName,


                          };
            foreach (var item in newList)
            {
                //Console.WriteLine(item.Id);
            }
            var newstudent = students.Select(stu => new Studentt()
            {
                Name = stu.FirstName,
                Age = stu.Age,
                Country = stu.Country,
            });
            foreach (var item in newstudent)
            {
                Console.WriteLine(item.Name);
            }
            var Anounymous = students.Select(stu => new
            {
                FamilyName = stu.FirstName,
                UnderAge = stu.Age,
                YCountry = stu.Country,
            });
            foreach (var item in Anounymous)
            {
                Console.WriteLine(item.FamilyName);
            }
        }
    }
}
