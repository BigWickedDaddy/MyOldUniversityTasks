using System;

namespace delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Example first = Length;
            Example second = Square;
            Example third = Volume;
            Console.ReadKey();
        }

        static double Length(double r)
        {
            return 2 * Math.PI * r;
        }
        static double Square(double r)
        {
            return 2 * Math.PI * r * r;
        }
        static double Volume(double r)
        {
            return 4 / 3 * Math.PI * r * r * r;
        }
    }

    public delegate double Example(double r);


}