using System;

namespace Контроша2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во строк : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите кол-во столбцов : ");
            int m = int.Parse(Console.ReadLine());
            float[,] A = new float[n, m];
            
            FillingX(A, n, m);
            FillingY(A, n, m);
            Filling(A, n, m);
            Console.WriteLine("Ваша матрица :");
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                    Console.Write("{0} ", A[i, j]);
                Console.WriteLine();
            }
            Console.WriteLine(A[n - 1, m - 1]);
        }
        static void FillingX(float[,] A, int n, int m)
        {
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    A[i, 0] = rand.Next(0, n);
            }
        }
        static void FillingY(float[,] A, int n, int m)
        {
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    A[0, j] = rand.Next(0, m);
            }
        }
        static void Filling(float[,] A, int n, int m)
        {
            Console.WriteLine();
            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < m; j++)
                {
                    float a = A[i, j - 1];
                    float b = A[i - 1, j];
                    float c = A[i - 1, j - 1];
                    if (a > b && a > c)
                        A[i, j] = a + 1;
                    else if (b > c)
                        A[i, j] = b + 1;
                    else
                        A[i, j] = c + 1;
                }
            }
            
        }
    }
}
