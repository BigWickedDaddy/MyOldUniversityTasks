using System;
using System.Linq;


namespace Fourth
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите числа :");

            string text = Console.ReadLine();
            int[] A = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            float max = 0;
            int a = 0;
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A.Length; j++)
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
