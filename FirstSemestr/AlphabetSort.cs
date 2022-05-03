using System;

namespace AlphabetSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во слов : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите слова через ENTER : ");
            string[] arr = new string[n];
            for(int i = 0; i < n; i++)
            {
                arr[i] = Console.ReadLine();
            }
            Console.WriteLine();
            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);
            Console.ReadKey();
        }
    }
}
