using System;

namespace _08._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во строк : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите кол-во столбцов : ");
            int h = int.Parse(Console.ReadLine());
            float[,] A = new float[n,h];
            Console.WriteLine("Введите числа по порядку через ENTER : ");
            for (int i = 0; i < n; i++)
            {   
                for(int j=0;j<h;j++)
                A[i,j] = int.Parse(Console.ReadLine());
            }
            Chetniy(A, n, h);
            SummElements(A, n, h);
            Kvadratnaya(A, n, h);
            Twoandfive(A, n, h);
            Kvadrati(A, n, h);
            Srednee(A, n, h);
            Index(A, n, h);
        }
            static void SummElements(float[,] A, int n,int h)
        {
            float summa = 0;
            Console.WriteLine("");
            Console.WriteLine("Сумма всех элементов : ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    summa += A[i, j];
                }
            }
            Console.WriteLine(summa);
            Console.ReadKey();
        }
            static void Kvadratnaya(float[,] A, int n, int h)
        {
            Console.WriteLine("");
            Console.WriteLine("Ваша матрица :");
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                    Console.Write("{0} ", A[i, j]);
                Console.WriteLine();
            }
            float summ=0;
            try
            {
                for (int j = 0; j < h; j++)
                {
                    summ += A[j, j];
                }
            }
            catch
            {
                Console.WriteLine("Матрица не квадратная");
            }
            Console.WriteLine("");
            Console.WriteLine("Сумма элементов главной диагонали :" + summ);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    A[i, j] = A[i, j] / summ;
                }
            }
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                    Console.Write("{0} ", A[i, j]);
                Console.WriteLine();
            }
            Console.WriteLine();
        }
            static void Twoandfive(float[,] A, int n, int h)
        {
            Console.WriteLine("Ваш текущий массив : ");
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                    Console.Write("{0} ", A[i, j]);
                Console.WriteLine();
            }
            float a = 0;
            try
            {
                for (int j = 0; j < n; j++)
                {
                    a = A[j, 1];
                    A[j,1]=A[j,4];
                    A[j, 4] = a;
                }
            }
            catch
            {
                Console.WriteLine("Нет 2 - ой или 5 - ой строки");
            }
            Console.WriteLine();
            Console.WriteLine("Поменяли местами 2 и 5 :");
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                    Console.Write("{0} ", A[i, j]);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        static void Kvadrati(float[,] A, int n, int h)
        {
            Console.WriteLine("");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < h; j++)
                    A[i, j] = A[i, j] * A[i, j];
            }
            Console.WriteLine("Квадрат двумерного массива : ");
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                    Console.Write("{0} ", A[i, j]);
                Console.WriteLine();
            }
        }
            static void Srednee(float[,] A, int n, int h)
            {
            float k=0;
            int m=0;
            int nuli=0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    if (A[i, j] > 0)
                    {
                        k += A[i, j];
                        m++;
                    }
                    else if (A[i, j] == 0)
                        nuli++;
                }
            }
            k = k / m;
            Console.WriteLine("");
            Console.WriteLine("Среднее арифмитическое всех положительных чисел = " + k);
            Console.WriteLine("Кол-во нулей : " + nuli);
        }
        static void Chetniy(float[,] A, int n, int h)
        {
            Console.WriteLine("");
            Console.WriteLine("Четный массив : ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    
                    if (A[i, j] % 2 == 0)
                        Console.Write(A[i,j] + " ");

                           
                }
            }
            Console.WriteLine("");
        }
        static void Index(float[,] A, int n, int h)
        {
            Console.WriteLine("");
            Console.WriteLine("Сумма чисел с суммой индексов = 4  : ");
            float  sum=0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    if (i + j == 4)
                        sum += A[i, j];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
