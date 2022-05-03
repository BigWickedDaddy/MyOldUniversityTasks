using System;

namespace контрольнгая
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число в КМ");
            double k = double.Parse(Console.ReadLine());
            Xs(k);
        }
        static void Xs(double k )
        {
            double a;
            double b;
            double milya=0.621371;
            double liga = 3;
            a = k * milya;// 1км=0,621371 миля
            Console.WriteLine("Км в мили = " + a + " миль");
            b = a / liga;// 1 миля = 0.33... лиг
            Console.WriteLine("Мили в лиги = " + b + " лиг");
            Console.WriteLine(k+ "км");
            Console.ReadKey();
        }
    }
}
