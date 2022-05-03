using System;
using System.Security.Cryptography;

namespace _4_функции
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите число : ");
            float n = float.Parse(Console.ReadLine());

            var a = Math.Tan(n);
            string a1 = a.ToString();
            
            var b = Math.Tan(n);
            string b1 = b.ToString();
            
            var c = n*n*n;
            string c1 = c.ToString();
            
            var d = Math.Sqrt(n);
            string d1 = d.ToString();

            string[,] A = new string[5, 5];
            A[0, 1] = "Тангенс";
            A[0, 2] = "Котангенс";
            A[0, 3] = "Куб";
            A[0, 4] = "Корень";
            A[1, 0] = a1;
            A[1, 1] = b1;
            A[1, 2] = c1;
            A[1, 3] = d1;

            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                    Console.Write("{0} ", A[i, j]);
                Console.WriteLine();
            }
        }
    }
}
