using System;

namespace Matrix2sem
{
    class Matrix
    {
        private int[,] numbers = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        public int this[int i, int j]
        {
            get
            {
                return numbers[i, j];
            }
             set
            {
                numbers[i, j] = value;
            }
        }
        private int size;
        public int Size
        {
            get
            {
                return size;
            }
            set
            {
                size = numbers.Length;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
