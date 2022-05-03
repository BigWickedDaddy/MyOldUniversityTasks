using System;
using System.Globalization;
using System.Linq.Expressions;

namespace Контроша
{
    class Program
    {
        static void Main(string[] args)
        {
            //Первая задача
            Console.WriteLine("Введите кол-во чисел : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение k : ");
            int k = int.Parse(Console.ReadLine());
            int k1 = k * 3;
            int[] mass = new int[n];
            Filling(mass, k, k1);
            YourMassiv(mass, k);
            Answer(mass, k);
            Console.ReadKey();

        }
        static void Filling(int[] mass, int k,int k1)
        {
            Random rand = new Random();
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = rand.Next(-k1, k1);
            }
            int j = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] == mass[j] || mass[i] == -mass[j])
                    mass[i] = rand.Next(-k1 + 1, k1 - 1);
                j++;
            }
        }
        static void YourMassiv(int[] mass, int k)
        {
            Console.WriteLine("Ваш массив : ");
            for (int i = 0; i < mass.Length; i++)
                Console.Write(mass[i] + " ");
        }
        static void Answer(int[] mass,int k)
        {
            Console.WriteLine();
            Console.WriteLine("Ваш ответ :");
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] % k != 0)
                    Console.Write(mass[i] + " ");
            }
        }
    }
}
