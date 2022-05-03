using System;

namespace Арифметическая
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во чисел : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите шаг : ");
            float k = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите начальное число : ");
            int l = int.Parse(Console.ReadLine());
            float[] A = new float[n];
            for (int i = 0; i < n; i++)
            {
                A[i] =l+k*i;
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(A[i]+" ");
            }
            Console.ReadKey();
        }
    }
}
