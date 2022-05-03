using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Nomer2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int i=0;
            int k=0;
            string k1;
            int[] Massive = new int[10];
            Massive[9] = -1;
            Random rand = new Random();
            Regex regex1 = new Regex(@"\d{0,}(?:2|4|6|8|0){3}\d{0,}");
            Console.WriteLine("Ваши числа(без четных 3 подряд) : ");
            while (Massive[9] == -1)
            {
                n = rand.Next();
                k1 = n.ToString();
                if (regex1.IsMatch(k1));
                {
                    Massive[i] = n;
                    Console.WriteLine(k1);
                    i++;
                }
                k++;
            }
            if (regex1.IsMatch("224555"));
            {
                Console.WriteLine("It Works!");
            }
            Console.WriteLine("Кол-во попыток : " + k);
            Console.ReadKey();   


        }
    }
}
