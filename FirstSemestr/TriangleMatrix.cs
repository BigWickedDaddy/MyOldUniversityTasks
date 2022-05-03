using System;

namespace Треугольный_вид
{
    class Program
    {
        static void Triangle(double[,] matrix)
        {
            double n = matrix.GetLength(0);
            for (int i = 0; i < n - 1; i++)
                for (int j = i + 1; j < n; j++)
                {
                    double koef = matrix[j, i] / matrix[i, i];
                    for (int k = i; k < n; k++)
                        matrix[j, k] -= matrix[i, k] * koef;
                }
        }
        static void Print(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                    Console.Write("{0:0.0}\t", matrix[i, j]);
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void Main()
        {
            double[,] matrix = new double[3, 3];

            var random = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(0); j++)
                    matrix[i, j] = random.Next(1, 9);

            Print(matrix);
            Triangle(matrix);
            Print(matrix);
            Console.ReadKey();
        }
    }
}
