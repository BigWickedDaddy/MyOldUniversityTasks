using System;
using System.Globalization;

namespace CapitalLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слова через пробел(в ответе будет кол-во заглавных букв): ");
            string stroka = Console.ReadLine();
            stroka = stroka + " ";
            int j=0;
            for(int i=0;i<stroka.Length;i++)
            {
                try
                {
                    if (stroka[i] == stroka.ToUpper()[i] )
                    {
                        while (stroka[i].ToString() != " ")
                        {
                                Console.Write(stroka[i]);
                                i++;
                            if (stroka[i].ToString() == " ")
                                j++;
                        }
                        Console.WriteLine("");
                    }
                }
                catch { }
            }
            Console.WriteLine(j);
            Console.ReadKey();
        }
    }
}
