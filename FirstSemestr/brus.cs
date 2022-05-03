using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Брус
{
    class Program
    {
        static void Xs(double a, double b, double x, double y, double z)
        {
            if (x <= a && y <= b) Console.WriteLine("Da");
            else if (y <= a && x <= b) Console.WriteLine("Da");
            else if (x <= a && z <= b) Console.WriteLine("Da");
            else if (z <= a && x <= b) Console.WriteLine("Da");
            else if (y <= a && z <= b) Console.WriteLine("Da");
            else if (z <= a && y <= b) Console.WriteLine("Da");
            else Console.WriteLine("Net");

            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны a и b");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите стороны x y z ");
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());
            Xs(a, b, x, y, z);
        }

    }
}
