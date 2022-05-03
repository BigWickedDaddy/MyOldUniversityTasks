using System;

namespace chastiyelement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов в массиве :");
            int n = int.Parse(Console.ReadLine());
            float[] A = new float[n];
            Console.WriteLine("Введите числа :");

            for (int i = 0; i < n; i++)
            {
                A[i] =int.Parse( Console.ReadLine());
            }
            float max = 0;
            int a = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (A[i] == A[j]) a++;
                }
                if (a > max) max = A[i];
                a = 0;
            }

            Console.WriteLine("Самое распространенное число :" + max);
        }
    }
}