using System;

namespace Массивизбукв
{
    class Program
    {
        static void Main(string[] args)
        {

            string alpha = "ABCDEFGHIJKLMNOPQRSTUVQXYZ";
            char[] letters = "ABCDEFGHIJKLMNOPQRSTUVQXYZ".ToCharArray();
            Random random = new Random();
            for (int a = letters.Length-1; a >= 1; a--)
            {
                int b = random.Next(a);
                var c = letters[a];
                letters[a] = alpha[b];
                letters[b] = c;
            }
            for (int i = 0; i < 26; ++i)
            {
                Console.Write(letters[i]+" ");
            }
            Console.WriteLine("");
            for (int a = letters.Length-1; a >= 1; a--)
            {
                int b = random.Next(a);
                var c = letters[a];
                letters[a] = letters[b];
                letters[b] = c;
            }
            for (int i = 0; i < 26; ++i)
            {
                Console.Write(letters[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
