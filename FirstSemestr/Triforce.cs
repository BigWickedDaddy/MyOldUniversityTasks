using System;

namespace SoloLearn
{
    class Program
    {
        static void Xs(int a, char b = ' ', char c = '*')
        {
            for (int i = 1; i < a + 1; i++)
            {
                Console.Write(new string(b, a * 2 - i));
                Console.Write(new string(c, i * 2 - 1));
                Console.WriteLine(new string(b, a * 2 - i));
            }
            for (int i = 1; i < a + 1; i++)
            {
                Console.Write(new string(b, a - i));
                Console.Write(new string(c, i * 2 - 1));
                Console.Write(new string(b, (a - i) * 2 + 1));
                Console.Write(new string(c, i * 2 - 1));
                Console.WriteLine(new string(b, a - i));
            }
        }
        static void Main(string[] args)
        {
            int n  = int.Parse(Console.ReadLine());
            Xs(n);   
        }
    }
}