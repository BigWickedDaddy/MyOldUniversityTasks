using System;

namespace _27N
{
    class Program 
    {
        static void Main(string[] args)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            Xs(x);
            Console.ReadKey();
        }

        static void Xs(double x)
        {
            int sum = 0;
            int S = 0;
            
            for (int i = 100; i <= 999; i++)
            {
                sum = int.Parse(i.ToString()[0].ToString()) + int.Parse(i.ToString()[1].ToString()) + int.Parse(i.ToString()[2].ToString());
                if (sum >= 1 && sum <= x)
                {
                    S += 1;
                }
               
            }
            Console.WriteLine(S);
        }
    }
}
