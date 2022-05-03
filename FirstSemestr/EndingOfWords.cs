using System;


namespace EndingOfWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слова через пробел ");
            string stroka = Console.ReadLine();
            stroka = stroka + " ";
            for (int i = 0; i < stroka.Length; i++)
            {
                if(stroka[i].ToString() == " ")
                Console.Write(stroka[i-1]);
            }
            Console.ReadKey();
        }
    }
}
