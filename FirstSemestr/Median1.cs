using System;
using System.Collections.Generic;

namespace _07._10__5_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во чисел : ");
            int n = int.Parse(Console.ReadLine());
            int[] A = new int[n];
            int k;
            double k1;
            for (int i = 0; i < n; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
            }
            int temp;
            for (int i = 0; i < A.Length - 1; i++)
            {
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (A[i] > A[j])
                    {
                        temp = A[i];
                        A[i] = A[j];
                        A[j] = temp;
                    }
                }
            }
            Console.WriteLine("Медиана : ");
            if (n % 2 == 0)
            {
                Console.WriteLine("Четная последовательность");
                k = n / 2;
                if ((A[k]%2 == 0 && A[k - 1]%2 != 0) || (A[k - 1]%2 == 0 && A[k]%2 != 0))
                {
                    Console.WriteLine("slychai 1");
                    k1 = (A[k] + A[k - 1]) / 2 + 0.5;
                    Console.WriteLine(k1);
                }
                else
                {
                    Console.WriteLine("slychai2");
                    k1 = (A[k] + A[k - 1]) / 2 ;
                    Console.WriteLine(k1);
                }
             }
            else
            {
                k = n / 2;
                Console.WriteLine(A[k]);
            }
            Console.ReadKey();
        }
    }
}
