using System;

namespace _24._09
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1, y1, x2, y2, x3, y3, x4, y4;
            Console.WriteLine("Введите координаты первой вершины:");
            x1 = int.Parse(Console.ReadLine());
            y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координаты второй вершины:");
            x2 = int.Parse(Console.ReadLine());
            y2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координаты третий вершины:");
            x3 = int.Parse(Console.ReadLine());
            y3 = int.Parse(Console.ReadLine());
            bool b = false;
            x4 = 0; y4 = 0;
            if ((x2 - x1) * (x3 - x1) + (y2 - y1) * (y3 - y1) == 0)
            {
                x4 = x3 + x2 - x1;
                y4 = y3 + y2 - y1;
            }
            else if ((x1 - x2) * (x3 - x2) + (y1 - y2) * (y3 - y2) == 0)
            {
                x4 = x3 + x1 - x2;
                y4 = y3 + y1 - y2;
            }
            else if ((x1 - x3) * (x2 - x3) + (y1 - y3) * (y2 - y3) == 0)
            {
                x4 = x2 + x1 - x3;
                y4 = y2 + y1 - y3;
            }
            else b = true;
            if (b == false) Console.WriteLine(" " + x4 + " " + y4);
            else
                Console.WriteLine("Это не квадрат");
            Console.ReadKey();
        }
    }
}