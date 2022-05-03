using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace домашка
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            double cosab; double cosac; double coscb;
            Console.WriteLine("Введите стороны треугольника");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("Треугольник Существует");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Треугольник Не Существует");
                Console.ReadKey();
            }
            double a1, a2, a3;
            cosab = (a * a + b * b - c * c);
            cosab = cosab / (2 * a * b);
            cosac = (a * a + c * c - b * b);
            cosac = cosac / (2 * a * c);
            coscb = (c * c + b * b - a * a);
            coscb = coscb / (2 * c * b);
            a1 = (Math.Acos(cosab)) * 180 / Math.PI;
            a2 = (Math.Acos(cosac)) * 180 / Math.PI;
            a3 = (Math.Acos(coscb)) * 180 / Math.PI;
            Console.WriteLine("Углы :" + a1 + " " + a2 + " " + a3);
            Console.ReadKey();
            double S, p, r;
            p = (a + b + c) * 0.5;
            r = (p - a) * (p - b) * (p - c);
            r = r / p;
            r = Math.Sqrt(r);
            S = r * (a + b + c);
            S = S / 2;
            Console.WriteLine("Площадь" + S);
            Console.ReadKey();
            double h, h1, h2, h3, big;
            p = (a + b + c) * 0.5;
            h = p * (p - a) * (p - b) * (p - c);
            h = 2 * Math.Sqrt(h);
            h1 = h / a;
            h2 = h / b;
            h3 = h / c;
            big = h1;
            if ((h1 > h2) && (h1 > h3))
            big = h1;
            else if((h2 > h1) && (h2 > h3))
            big = h2;
            else if((h3 > h1) && (h3 > h2))
            big = h3;
            Console.WriteLine("Высота " + big);
            Console.ReadKey();
            double S1,r1,p1;
            p1 = (a + b + c) * 0.5;
            r1 = (p1 - a) * (p1 - b) * (p1 - c);
            r1 = r1 / p;
            r1 = Math.Sqrt(r1);
            S1 = Math.PI * r1 * r1;
            Console.WriteLine("Площадб вписанного круга " + S1);
            Console.ReadKey();
        }
        
    }
}