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
            string k1;
            int[] Massive = { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };
            Massive[10] = -1;
            Random rand = new Random();
            Regex regex1 = new Regex(@"(?:2|4|6|8|0){3}");
            Console.WriteLine("Ваши числа(без четных 3 подряд) : ");
            while (Massive[10] == -1)
            {
                i++;
                n = rand.Next();
                k1 = n.ToString();
                if (regex1.IsMatch(k1));
                {
                    Massive[i] = n;
                    Console.WriteLine(k1);
                }
            }
            if (!regex1.IsMatch("2445678")) ;
            {
                Console.WriteLine("It works");
            }
            Console.WriteLine("Кол-во попыток : " + i);
            Console.ReadKey();   


        }
    }
}
