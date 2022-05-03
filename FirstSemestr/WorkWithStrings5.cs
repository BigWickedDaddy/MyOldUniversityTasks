using System;

namespace zadacha
{
    class Program 
    {
        static void Main(string[] args)
        {
            Xs(Console.ReadLine());
        }

        static string Xs(string vvod)
        {
            string a = vvod[0].ToString();
            string b = "";
            for (int i = 0; i < vvod.Length - 1; i++)
            {
                if ((vvod[i].ToString()) == (vvod[i + 1].ToString()))
                {
                    a = a + vvod[i + 1].ToString();
                }
                else
                {
                    if (a.Length >= b.Length)
                    {
                        b = a;
                        a = vvod[i + 1].ToString();
                    }
                    else
                    {
                        a = vvod[i + 1].ToString();
                    }
                }
            }
            if (b.Length <= a.Length)
            {
                b = a;
            }
            Console.WriteLine(b);
            return " ";
        }
    }
}