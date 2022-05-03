using System;

namespace makloren
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число ");
            double a = double.Parse(Console.ReadLine());
            double ac = Math.Pow(10, -10);
            Console.WriteLine(Xs(a, ac));
        }
        static double Xs(double b, double ac)
        {
            double c = 1;
            int k = 0;
            while (true)
            {
                if (c < ac)
                {
                    break;
                }
                int ans = 1;
                for (int i = k; i > 1; i--)
                {
                    ans = ans * i;
                }
                double p = Math.Pow(b, k);
                c = c + p / ans;
                k++;
            }
            return c;
        }
    }
}
