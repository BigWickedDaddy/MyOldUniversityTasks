using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {

                int k;

                    Console.Write("Введите основание системы счисления: ");
                    k = int.Parse(Console.ReadLine());

                int n;
                do
                {
                    Console.Write("Введите 10 - ное число(n > 0): ");
                    n = int.Parse(Console.ReadLine());
                }
                while (n <= 0);

                string a = "";

                while (n != 0)
                {
                    int b = n % k;
                    n = n / k;
                    if (b > 9)
                    {
                        b = b + ((int)'A' - 10);
                        a = (char)b + a;
                    }
                    else
                        a = b.ToString() + a;

                }
                Console.WriteLine("\n Ответ:{0}", a);
                
                Console.Write("Введите основание системы счисления: ");
                k = int.Parse(Console.ReadLine());
                string s;              
                Console.Write("Введите число в системе по основанию {0} (n > 0): ", k);
                s = Console.ReadLine();
                int l = 0;  
                int j = 0;
                for (int i = s.Length - 1; i >= 0; i--)
                {
                    if (s[i] >= 'A' && s[i] <= 'F')
                    l = (int)(l + ((int)s[i] - 55) * Math.Pow(k, j));
                    else
                    l = (int)(l + ((int)s[i] - (int)'0') * Math.Pow(k, j));
                j++;
            }
            Console.WriteLine("\n Ответ :{0}", l);
            Console.ReadKey();
        }
        }
}

