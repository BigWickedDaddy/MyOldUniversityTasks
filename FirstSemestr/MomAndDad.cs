using System;
using System.Text.RegularExpressions;

namespace Mom_Dad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите text  для задания mom-dad  : ");
            string text1 = Console.ReadLine();
            Regex regex1 = new Regex(@"mom");
            text1 = new Regex(@"mom").Replace(text1, @"dad");
            Console.WriteLine(text1);
            Console.ReadKey();
        }
    }
}
