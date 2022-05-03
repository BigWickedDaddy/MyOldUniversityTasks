using System;
using System.IO;

namespace gallow
{
    class Program
    {

        static void Main()
        {
            string path = @"D:\test.txt";
            Random rnd = new Random();
            string word = "";
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                int count = rnd.Next(0, 7992);
                
                int i = 0;
                Console.WriteLine("Ваш уровеь : (1)Меньше 5 букв в слове (2)Больше 5 букв в слове");
                int number = int.Parse(Console.ReadLine());
                while (i <= count)
                {
                    sr.ReadLine();
                    switch (number)
                    {   
                        case 1:
                            if (i == count)
                            {
                                line = sr.ReadLine();
                                word = line;
                                string[] gallows = word.Split(new char[] { ' ', '-', ',' }, StringSplitOptions.RemoveEmptyEntries);
                                if (gallows[0].Length <= 5)
                                    break;
                                else
                                    count++;
                            }
                            break;
                        case 2:
                            if (i == count)
                            {
                                line = sr.ReadLine();
                                word = line;
                                string[] gallows = word.Split(new char[] { ' ', '-', ',' }, StringSplitOptions.RemoveEmptyEntries);
                                if (gallows[0].Length <= 5)
                                    break;
                                else
                                    count++;
                            }
                            break;
                    }
                    i++;
                }
            }
            Console.Clear();
            string[] gallow = word.Split(new char[] { ' ', '-', ',' }, StringSplitOptions.RemoveEmptyEntries);
            Game(gallow);
        }
        public static void Draw(int count)
        {
            if (count == 1)
                Console.WriteLine("\n\n\n\n|");
            if (count == 2)
                Console.WriteLine("\n\n\n|\n|");
            if (count == 3)
                Console.WriteLine("\n\n|\n|\n|");
            if (count == 4)
                Console.WriteLine("\n|\n|\n|\n|");
            if (count == 5)
                Console.WriteLine("|\n|\n|\n|\n|");
            if (count == 6)
                Console.WriteLine(" ----- \n|\n|\n|\n|");
            if (count == 7)
                Console.WriteLine("|_____|\n|    о\n|\n|\n|");
            if (count == 8)
                Console.WriteLine("|_____|\n|    о\n|   /|" + @"\" + "\n|\n|");
            if (count == 9)
            {
                Console.WriteLine("|_____|\n|    о\n|   /|" + @"\" + "\n|   / " + @"\" + " \n|\n");
                Console.WriteLine("You lose");
            }    
        }
        public static void Game(string[] gallow)
        {

            int count = 0;
            int length = gallow[0].Length;
            char[] symbols = new char[length];
            for (int i = 0; i < length; i++)
            {
                symbols[i] = '_';
            }
            while (count < 9)
            {
                int count2 = 0;
                int count3 = 0;
                Console.WriteLine();
                Console.WriteLine("(1)Ввести новую букву или (2)Взять подсказку");
                int num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("\n Введи букву \n");
                        char symbol = Convert.ToChar(Console.ReadLine());
                        Console.WriteLine();
                        for (int i = 0; i < length; i++)
                        {
                            if (symbol == gallow[0][i])
                            {
                                symbols[i] = symbol;
                                count2++;
                            }
                            Console.Write(symbols[i]);
                        }
                        if (count2 == 0)
                            count++;
                        Console.WriteLine();
                        Draw(count);
                        for (int i = 0; i < length; i++)
                        {
                            if (symbols[i] == gallow[0][i])
                                count3++;
                            else
                                break;
                        }

                        break;
                    case 2:
                        Console.Clear();
                        for (int i = 1; i < gallow.Length; i++)
                        {
                                Console.Write(gallow[i] + " ");
                        }
                        Console.ReadKey();
                        Console.Clear();
                        Draw(count);
                        break;
                }
                if (count3 == length)
                {
                    count = count3;
                    break;
                }
            }
            if (count == length)
                Console.WriteLine("You win");
        }
    }
}