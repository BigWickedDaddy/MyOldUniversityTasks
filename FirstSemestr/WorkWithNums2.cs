using System;
using System.Runtime.ExceptionServices;

namespace FibonachiNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = string.Empty;
            var b = 0.0;

            do
            {
                Console.Write("Введите число  ");
                a = Console.ReadLine();
            }
            while (!double.TryParse(a, out b) || b < 0);

            int first = 1;
            int first1 = first;
            int  second = 1;
            int second1 = second;
            int summa = 0;
            int summa1=0;

            Console.Write($"\n{first} {second} ");

            while (b >= summa)
            {
                summa = first + second; 
                summa1 = first1 + second1 + summa;
                summa1 += summa;
                Console.Write($"{summa} ");
                first = second;
                second = summa;
            }
            Console.WriteLine(summa1);
            Console.ReadKey();
        }
    }
}


