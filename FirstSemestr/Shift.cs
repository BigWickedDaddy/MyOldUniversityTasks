using System;

namespace sdvig
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
            k = A[0];
            for (int i = 0; i < n-1; i++)
            {
                A[i] =A[i+1] ;
            }
            A[n-1] = k;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(A[i]);
            }
            Console.ReadKey();
        }
    }
}
