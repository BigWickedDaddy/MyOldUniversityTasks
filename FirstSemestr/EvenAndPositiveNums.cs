using System;

namespace _07._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во чисел : ");
            int n = int.Parse(Console.ReadLine());
            int k;
            int[] A = new int[n];
            for (int i = 0; i < n; i++)
            {
                    A[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Положительные четные числа : ");
            for (int i = 0; i < n; i++)
            {
                if (A[i] > 0 && A[i] % 2 == 0)
                    Console.WriteLine(A[i]);
            }
            Console.ReadKey();
            
        }
    }
}
