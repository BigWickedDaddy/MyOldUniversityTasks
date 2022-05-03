using System;
using System.Collections.Generic;


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



        public Matrix(int[,] Numbers)
        {
            numbers = Numbers;
        }

        public int Dimensions
        {
            get 
            {
                return size;
            }
            set
            {
                size = value;
                size = numbers.Length;
            }
        }

        public int[] this[int i]
        {
            get
            {
                var arr = new List<int>();
                for (var k = 0; k < numbers.Length; k++)
                {
                    var intermediate = numbers[i, k];
                    arr.Add(intermediate);
                }

                return arr.ToArray();
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
