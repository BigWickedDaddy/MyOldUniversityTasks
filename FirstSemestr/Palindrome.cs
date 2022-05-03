using System;

namespace Контроша3
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Replace(text);//Не знаю почему не удаляет эти символы
            //,так и не получилось за отведенное время решить это.Но полиндром слова ищет.
            Check(text);
        }
        static void Check(string text)
        {
            int len=text.Length;
            char[] ar = text.ToCharArray();
            int check1=1;
            for(int i = 0; i < len / 2; ++i)
            {
                if (ar[i] != ar[len - i - 1])
                    check1 = 0;
                else check1 = 1;
            }
            
            Console.WriteLine(text);
            if (check1 == 1)
                Console.WriteLine("Da,polindrom");
            else Console.WriteLine("Net,ne polindrom");
        }
        static void Replace(string text)
        {
            text =text.Replace(" ", "");
            text=text.Replace(".", "");
            text=text.Replace(",", "");
            text=text.Replace("!", "");
            text=text.Replace("?", "");
        }
    }
}
