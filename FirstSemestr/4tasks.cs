using System;
using System.Text.RegularExpressions;

namespace _4Tsks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число для задания 1 ");
            string text1 = Console.ReadLine();
            Regex regex1 = new Regex(@"^(.)\1{1}");

            if (regex1.IsMatch(text1))
            {
                Console.WriteLine("Входное слово начиннается на два одинаковых символа ");
            }
            //-----------------------------
            Console.WriteLine("Введите число для задания 2 ");

            string text2 = Console.ReadLine();
            
            Regex regex2 = new Regex(@"00$");

            if (regex2.IsMatch(text2))
            {
                Console.WriteLine("Входное слово заканчивается  на два 0 ");
            }
            //-----------------------
            Console.WriteLine("Введите число для задания 3 ");
            
            string text3 = Console.ReadLine();

            Regex regex3 = new Regex(@"(.)\1{1}$");

            if (!regex3.IsMatch(text3))
            {
                Console.WriteLine("Входное слово заканчивается  на два разных символа ");
            }

            Console.WriteLine("Введите число для задания 4 ");

            string text4 = Console.ReadLine();

            Regex regex4 = new Regex(@"^(.)\1{1}.+");

            if (regex4.IsMatch(text4) && !regex3.IsMatch(text4))
            {
                Console.WriteLine("Входное слово заканчивается  на два разных символа и начинается на 2 одинаковых");
            }
        }
    }
}
