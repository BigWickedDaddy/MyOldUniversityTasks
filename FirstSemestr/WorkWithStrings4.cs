using System;

namespace _07._10__2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во слов : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите длину слова : ");
            int k = int.Parse(Console.ReadLine());
            string[] A = new string[n];
            Console.WriteLine("Введите слова через ENTER : ");
            for (int i = 0; i < n; i++)
            {
                A[i] = Console.ReadLine();
            }
            Console.WriteLine("Ваш ответ(не длиннее):");
            for (int i = 0; i < n; i++)
            {
                if (A[i].Length<k)
                Console.WriteLine(A[i]);

            }
            Console.WriteLine("Ваш ответ(не короче):");
            for (int i = 0; i < n; i++)
            {
                if (A[i].Length > k)
                    Console.WriteLine(A[i]);
            }
            Console.ReadKey();
        }
    }
}
