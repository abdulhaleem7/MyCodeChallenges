using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignment
{
    public class Student
    {
       
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
           
       
    }
    public static class Stringbuild
    {
        public static string Substrin(this string str, int index, int length)
        {
            return str.Substring(index, length);
        }
    }
    public static class Enumerab
    {
        public static int addition(this IEnumerable<int> num)
        {
            return num.Sum();
        }
        public static int Minimum(this IEnumerable<int> num)
        {
            return num.Min();
        }
        public static int Maximum(this IEnumerable<int> num)
        {
            return num.Max();
        }
        public static double Averag(this IEnumerable<int> num)
        {
            return num.Average();
        }
    }
    public static class Capital
    {
        public static string Capit(this string str)
        {
            return new CultureInfo("en-US", false).TextInfo.ToTitleCase(str);
        }
    }






}
