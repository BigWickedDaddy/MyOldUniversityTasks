using System;
using System.Linq;

namespace modul
{
    class Program
    {
        static void Main(string[] args)
        {
            int maximum = 0;
            int k = 0;

            Console.WriteLine("Введите количество чисел :");
            int n = int.Parse(Console.ReadLine());
            int[] A = new int[n];
            Console.WriteLine("Введите числа :");

            for (int i = 0; i < n; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Числа по модулю больше максимального :");
            maximum = A.Max();

            for (int i = 0; i < n; i++)
            {
                if (Math.Abs(A[i]) > maximum)
                {
                    k++;
                    Console.WriteLine(A[i]);
                }
            }

            Console.WriteLine("Кол-во элементов,которые больше максимального по модулю :" + k);
        }
    }
}