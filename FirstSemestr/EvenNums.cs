using System;
using System.Linq;

namespace _07._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите цифры через пробел : ");
            string text = Console.ReadLine();
            int[] A = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine("Положительные четные числа : ");
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0 && A[i] % 2 == 0)
                    Console.WriteLine(A[i]);
            }
            Console.ReadKey();

        }
    }
}