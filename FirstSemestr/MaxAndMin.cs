using System;
using System.Linq;

namespace maxandmin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во чисел : ");
            int n = int.Parse(Console.ReadLine());
            int[] A = new int[n];
            for (int i = 0; i < n; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
            }
            int max = A.Max();
            int min = A.Min();
            Console.WriteLine("Max = " + max + " " + "Min =  " + min);
            int sum = max + min;
            Console.WriteLine("Max+min = " + sum);
            Console.ReadKey();
        }
    }
}
