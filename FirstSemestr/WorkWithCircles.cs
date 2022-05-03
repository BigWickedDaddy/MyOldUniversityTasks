using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int R = int.Parse(Console.ReadLine());
            for (int i = 1; i <= R * R; i++)
            {
                for (double j = 1; j <= 2 * R; j++)
                {
                    double y1 = R + Math.Sqrt(R * R - Math.Pow((R - j), 2));
                    double y2 = R - Math.Sqrt(R * R - Math.Pow((R - j), 2));
                    if (i > y2 && i < y1) Console.Write("00");
                    else Console.Write("  ");
                }
                Console.Write("\n");
            }
            Console.ReadKey();

        }
    }
}

