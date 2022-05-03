using System;

namespace перестановкаиподсчет
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во чисел : ");
            int n = int.Parse(Console.ReadLine());
            int[] A = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                A[i] = rnd.Next(0,9);
            }

            Random random = new Random();
            for (int a = A.Length - 1; a >= 0; a--)
            {
                int b = random.Next(a);
                int c = A[a];
                A[a] = A[b];
                A[b] = c;
            }

            Console.WriteLine("");
            int schet = 0;
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
                    schet++;
                }
            }
            Console.WriteLine("");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(A[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("Кол-во действий : " + schet);
        }
    }
}
