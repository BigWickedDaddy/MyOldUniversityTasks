using System;

namespace krestiki
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите n1 n2 n3 через ENTER : ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Xs( a,  b, c);
        }
        static void Xs(int a,int c ,int b )
        {
            if ((a == 1 || b == 1 || c == 1) && (a == 2 || b == 2 || c == 2) && (a == 3 || b == 3 || c == 3))
                Console.WriteLine("Win");
            else if ((a == 4 || b == 4 || c == 4) && (a == 5 || b == 5 || c == 5) && (a == 6 || b == 6 || c == 6))
                Console.WriteLine("Win2");
            else if ((a == 7 || b == 7 || c == 7) && (a == 8 || b == 8 || c == 8) && (a == 9 || b == 9 || c == 9))
                Console.WriteLine("Win3");
            else if ((a == 1 || b == 1 || c == 1) && (a == 4 || b == 4 || c == 4) && (a == 7 || b == 7 || c == 7))
                Console.WriteLine("Win3");
            else if ((a == 2 || b == 2 || c == 2) && (a == 5 || b == 5 || c == 5 )&& (a == 8 || b == 8 || c == 8))
                Console.WriteLine("Win4");
            else if ((a == 3 || b == 3 || c == 3) && (a == 6 || b == 6 || c == 6) && (a == 9 || b == 9 || c == 9))
                Console.WriteLine("Win5");
            else if ((a == 1 || b == 1 || c == 1) &&( a == 5 || b == 5 || c == 5 )&& (a == 9 || b == 9 || c == 9))
                Console.WriteLine("Win6");
            else if ((a == 7 || b == 7 || c == 7) && (a == 5 || b == 5 || c == 5 )&& (a == 3 || b == 3 || c == 3))
                Console.WriteLine("Win7");
            else Console.WriteLine(" Lost ");
            Console.ReadKey();
        }
    }
}
