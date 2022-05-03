using System;

namespace BinSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите ваш массив : ");
            double[] massiv = new double[n];
            for(int i=0; i < massiv.Length; i++)
            {
                massiv[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            int k = massiv.Length / 4;
            Console.WriteLine(massiv[k]);
            Console.ReadLine();
        }
    }
}
