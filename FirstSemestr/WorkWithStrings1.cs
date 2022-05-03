using System;

namespace Third
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Введите кол-во чисел : ");
            int n = int.Parse(Console.ReadLine());
            string[] A = new string[n];
            for (int i = 0; i < n; i++)
            {
                A[i] = Console.ReadLine();
            }*/

            string str = Console.ReadLine();
            string[] A = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("Вывод : ");

            if (A.Length == 0)
                Console.WriteLine("no one likes this");
            else if (A.Length == 1)
                Console.WriteLine(A[0] + " likes this ");
            else if (A.Length == 2)
                Console.WriteLine(A[0] + " and " + A[1] + " likes this ");
            else if (A.Length == 3)
                Console.WriteLine(A[0] + " and " + A[1] + " and " + A[2] + " likes this");
            else Console.WriteLine(A[0] + " and " + A[1] + " and " + (A.Length - 2) + " others likes this "); ;

            Console.ReadKey();
        }
    }
}
