using System;

namespace Second
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = 0;
            Console.WriteLine("Введите слова через пробел: "); 
            string str = Console.ReadLine();
            Console.WriteLine("Введите число: "); 
            n = Convert.ToInt32(Console.ReadLine());
            string[] a = str.Split(' ');
            Console.WriteLine("Слова больше чем ваше число:");
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].Length > n) Console.Write($" {a[i]}");
            }
            Console.WriteLine();
        }
    }
}
