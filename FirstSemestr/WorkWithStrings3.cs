using System;
using System.Linq;

namespace Seventh
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int[] A = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int k;
            /*Console.WriteLine("Введите кол-во чисел : ");
            int n = int.Parse(Console.ReadLine());
            int k;
            int[] A = new int[n];
            for (int i = 0; i < n; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
            }*/
            k = A[0];
            for (int i = 0; i < A.Length - 1; i++)
            {
                A[i] = A[i + 1];
            }
            A[A.Length - 1] = k;
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i]+" ");
            }
            Console.ReadKey();
        }
    }
}
