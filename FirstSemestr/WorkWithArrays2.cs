using System;
using System.Reflection.Emit;

namespace контольная_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите a ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите b ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите шаг(Расстояние) ");
            double n = double.Parse(Console.ReadLine());
            Xs(a, b, n);
        }

        static void Xs(double a, double b, double n)
        {
            double x;
            double fa;
            double fb;
            fb = 0;
            double h = (b - a) / n;
            Console.WriteLine("Шаг " + h);
            for (int i = 0; i <= n; i++)
            {
                x = a + (i - 1) * h + h;
                fa = x * x;
                fb += fa;
            }
            x = a + (n - 1 - 1) * h + h;
            x = x * x;
            fb = fb - x;
            double otvet = fb * h;
            Console.WriteLine(otvet);
            Console.ReadKey();
        }
        }
    }

