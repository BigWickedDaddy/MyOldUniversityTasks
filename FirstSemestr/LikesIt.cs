using System;

namespace _07._10__3_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во чисел : ");
            int n = int.Parse(Console.ReadLine());
            string[] A = new string[n];
            for (int i = 0; i < n; i++)
            {
                A[i] = Console.ReadLine();
            }

            Console.WriteLine("Вывод : ");
           
            if (n == 0)
                    Console.WriteLine("no one likes this");
                else if (n == 1)
                    Console.WriteLine(A[0] + " likes this ");
                else if (n == 2)
                    Console.WriteLine(A[0] + " and " + A[1] + " likes this ");
                else if (n == 3)
                    Console.WriteLine(A[0] + " and " + A[1] + " and " + A[2] + " likes this");
                else Console.WriteLine(A[0]+" and "+A[1] +" and "+ (n-2) + "others likes this ");
            
            Console.ReadKey();

        }
    }
}
