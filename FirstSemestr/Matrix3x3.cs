using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix3x3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*float[,] A = new float[3, 3];
            Console.WriteLine("Введите числа по порядку через ENTER : ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    A[i, j] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\n Ваша матрица : \n");
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                    Console.Write("{0} ", A[i, j]);
                Console.WriteLine();
            }
            
            */
            Console.WriteLine("Введите ваше действие");
            int number = int.Parse(Console.ReadLine());
            double[,] A = new double[3, 3];
            //double[,] A1 = new double[3, 3];
            switch (number) 
            {
                case 1:
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine("Ваша нулевая матрица : ");
                    Matrix3x3 matrix1 = new Matrix3x3();
                    matrix1.GetMatrix();
                    break;
                case 2:
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine("\nВведите число,чтобы заполнить всю матрицу только им : ");
                    double n = int.Parse(Console.ReadLine());
                    Matrix3x3 matrix2 = new Matrix3x3(n);
                    matrix2.GetMatrix();
                    break;
                case 3:
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine("\nВведите числа по порядку через ENTER : ");
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                            A[i, j] = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("\nВаша матрица : ");
                    Matrix3x3 matrix3 = new Matrix3x3(A);
                    matrix3.GetMatrix();
                    break;
                case 4:
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine("\nВведите через ENTER 9 чисел по порядку : ");
                    double a1 = int.Parse(Console.ReadLine()); double a2 = int.Parse(Console.ReadLine());
                    double a3 = int.Parse(Console.ReadLine()); double a4 = int.Parse(Console.ReadLine());
                    double a5 = int.Parse(Console.ReadLine()); double a6 = int.Parse(Console.ReadLine());
                    double a7 = int.Parse(Console.ReadLine()); double a8 = int.Parse(Console.ReadLine());
                    double a9 = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nВаша матрица :");
                    Matrix3x3 matrix4 = new Matrix3x3(a1, a2, a3, a4, a5, a6, a7, a8, a9);
                    matrix4.GetMatrix();
                    break;
                /*case 5:
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine("Введите вашу первую матрицу  по порядку через ENTER : ");
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                            A[i, j] = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Введите вашу первую матрицу  по порядку через ENTER : ");
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                            A1[i, j] = int.Parse(Console.ReadLine());
                    }
                    Matrix3x3 matrix5 = new Matrix3x3();
                   
                    break;
                case 6:
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine("Введите число,чтобы умножить всю матрицу,состоящую из цифр 5 : ");
                    int num = int.Parse(Console.ReadLine());
                    Matrix3x3 matrix6 = new Matrix3x3(num);
                    matrix6.GetMatrix();
                    break;
                case 7:
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                            A1[i, j] = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine(A1[0,1]);
                    break;*/

            }

            Console.ReadLine();
        }
    }
    public class Matrix3x3
    {
        private static double[,] A = new double[3 , 3];

        private double this[int i, int j]
        {
            get => A[i, j];
            set => A[i, j] = value;
        }


        public Matrix3x3()
        {
            for ( int i = 0 ; i < 3; i++)
            {
                for (int  j = 0; j < 3; j++)
                    A[i, j] = 0;
            }
            
        }
        public Matrix3x3(double n)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    A[i, j] = n;
            }
        }
        public Matrix3x3(double[,]A1)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    A[i, j] = A1[i,j];
            }
        }
        public Matrix3x3(double a1, double a2, double a3, double a4, double a5, double a6, double a7, double a8, double a9)
        {
            A[0, 0] = a1; A[0, 1] = a2; A[0, 2] = a3; 
            A[1, 0] = a4; A[1, 1] = a5; A[1, 2] = a6;
            A[2, 0] = a7; A[2, 1] = a8; A[2, 2] = a9;
        }

        public static Matrix3x3 Plus(Matrix3x3 matrix)
        {
            return Add(matrix);
        }

        private static Matrix3x3 Add(Matrix3x3 matrix)
        {
            
            Matrix3x3 result = new Matrix3x3();
            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    result[i, j] = matrix[i, j] + A[i, j];
                }
            }

            return result;
        }
        public static Matrix3x3 Minus(Matrix3x3 matrix)
        {
            return Sub(matrix);
        }
        private static Matrix3x3 Sub(Matrix3x3 matrix)
        {
            Matrix3x3 result = new Matrix3x3(5);
            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    result[i, j] = A[i, j]

                    - matrix[i, j];
                }
            }
            return result;
        }

        public static Matrix3x3 Number(double a)
        {
            return MultNumber(a);
        }
        private static Matrix3x3 MultNumber(double a)
        {
            Matrix3x3 result = new Matrix3x3();
            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    result[i, j] = A[i,j] * a;
                }
            }
            return result;
        }

        public static Matrix3x3 MultNum(Matrix3x3 matrix)
        {
            return Mult(matrix);
        }

        private static Matrix3x3 Mult(Matrix3x3 matrix)
        {

            Matrix3x3 result = new Matrix3x3(5);
            for (var i = 0; i < 3; i++)//3 можно заменить на кол-во строк в 1 матрице
            {
                for (var j = 0; j < 3; j++)//3 можно заменить на кол-во столбцов в 2 матрице
                {
                    result[i, j] = 0;
                    for(var k = 0; k<3;k++)//3 можно заменить на кол-во столбцов в 1 матрице
                        result[i, j] += matrix[i, k] * A[k, j];
                }
            }
            return result;
        }

        public static Matrix3x3 Det(double[,] matrix)
        {
            Matrix3x3 result = new Matrix3x3();
             result[0,0]=matrix[0, 0] * matrix[1, 1] * matrix[2, 2] + matrix[2, 0] * matrix[0, 1] * matrix[1, 2] + matrix[1, 0] * matrix[2, 1] * matrix[0, 2] - matrix[2, 0] * matrix[1, 1] * matrix[0, 2] - matrix[0, 0] * matrix[2, 1] * matrix[1, 2] - matrix[1,0] * matrix[0,1] * matrix[2,2];
            //00 11 22 + 20 01 12 + 10 21 02 - 20 11 02 - 00 21 12 - 10 01 22
            return result;
        }

        public double[,] Transpose(double[,] matrix)
        {
            int w = matrix.GetLength(0);
            int h = matrix.GetLength(1);

            double[,] result = new double[h, w];

            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    result[j, i] = matrix[i, j];
                }
            }

            return result;
        }

        public static Matrix3x3 Multvector(Matrix3x3 matrix)
        {
            Console.WriteLine("Введите числа по порядку через ENTER : ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 1; j++)
                    A[i, j] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    matrix[i, j] =matrix[i,j] * A[i,0];
            }
            return matrix;
        }

        public void GetMatrix()
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                    Console.Write("{0} ", A[i, j]);
                Console.WriteLine();
            }
        }
    }
}
