
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите a b c :");
                double a, b, c;
                Console.WriteLine("Введите a:");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите b:");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите c :");
                c = double.Parse(Console.ReadLine());
                Xs(a, b, c);
            }
            catch
            {
                Console.WriteLine("сломался");
            }
        }
        static void Xs(double a, double b, double c)
        {
            double D = b * b - 4 * a * c;
            if (D > 0)
            {
                double x1 = ((-b + Math.Sqrt(D)) / 2 * a);
                double x2 = ((-b - Math.Sqrt(D)) / 2 * a);
                Console.WriteLine("х1= " + x1 + " " + " х2= " + x2);
                Console.ReadKey();
            }
            else if (D == 0) {
                double x1 = (-b / 2 * a);
                Console.WriteLine("х= " + x1);
                Console.ReadKey();

           }

            else {
                Console.WriteLine("х=ничего" );
                Console.ReadKey(); }

        }


    }
}
