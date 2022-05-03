using System;
using System.Linq;

namespace Massivs
{
    class Program
    {
        static void Main(string[] args)
        {

            /*string text = Console.ReadLine();
            int[] values = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < values.Length; i++)
            {
                values[i] = values[i] + 1;
                Console.WriteLine(values[i].ToString());
            }

            Console.ReadKey();*/

            string text = Console.ReadLine();
            int[] A = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < A.Length; i++)
            {
                A[i] = A[i] + 1;
                Console.WriteLine(A[i].ToString());
            }

            int n = A.Length;
            
            Console.WriteLine("Введите числа :");

            for (int i = 0; i < n; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
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
