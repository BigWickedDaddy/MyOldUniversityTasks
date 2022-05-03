using System;

namespace dop3
{
    class Program
    {
        static void Main(string[] args)
        {
            string rus = " абвгдежзиклмнопрстуфхцчщыэюя";
            string eng = " abvgdesziklmnoprstufhchieya";
            string In = "";
            string Out = "";

            Console.WriteLine("Введите строку");
            In = Console.ReadLine();

            foreach (char ch in In)
            {
                for (int i = 0; i < rus.Length; i++)
                {
                    if (ch == rus[i])
                    {
                        Out += eng[i];
                    }
                }
            }

            Console.WriteLine("Транслит");
            for (int i = 0; i < Out.Length; i++)
            {
                Console.Write(Out[i]);
            }
            Console.ReadKey();
        }
    }
}