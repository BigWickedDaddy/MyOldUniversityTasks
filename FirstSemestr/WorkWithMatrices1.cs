using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    //Создать класс Matrix3x3 - двумерная матрица из вещественных чисел.Аргументы -
    //содержимое матрицы(лучше, разумеется, хранить двумерным массивом, а то замучаетесь).
    //Методы:
    //Matrix3x3() - конструктор для нулевой матрицы;•
    //Matrix3x3(double) - конструктор для матрицы, у которой каждый элемент равен поданному числу;
    //Matrix3x3(double[][]) - конструктор для матрицы, содержимое подается на вход в виде массива;
    //Matrix3x3(double, double, double, double, double, double, double, double, double) - глупый конструктор, но пусть он будет.
    //Сами знаете, что он делает.В конструкторах устраняйте дублирование кода;
    //Matrix3x3 add(Matrix3x3) - сложение матрицы с другой;
    //void add3(Matrix3x3) - сложение матрицы с другой;
    //Matrix3x3 sub(Matrix3x3) - вычитание из матрицы другой матрицы;
    //void sub3(Matrix3x3) - вычитание из матрицы другой матрицы;
    //Matrix3x3 multNumber(double) - умножение матрицы на вещественное число;
    //void multNumber3(double) - умножение матрицы на вещественное число;
    //Matrix3x3 mult(Matrix3x3) - умножение матрицы на другую матрицу;
    //void mult3(Matrix3x3) - умножение матрицы на другую матрицу;
    //double det() - определитель матрицы;
    //void transpon() - транспонировать матрицу;
    //Matrix3x3 inverseMatrix() - возвратить обратную матрицу для заданной.Если это невозможно, вывести сообщение об ошибке и вернуть нулевую матрицу(кто вдруг знает
    //исключения, может их использовать).
    //Matrix3x3 equivalentDiagonal() - возвратить эквивалентную диагональную матрицу;
    //Vector3D multVector(Vector3D) - умножить матрицу на двумерный вектор(считая его столбцом) и возвратить получившийся столбец в виде вектора.
    //Прикрутить функции по сведению к треугольному виду
    class Matrix3x3
    {
        private readonly int height = 3;
        private static double[,] matrix;

        public Matrix3x3(int height)
        {
            this.height = height;
            matrix = new double[this.height, this.height];
        }

        private double this[int i, int j]
        {
            get => matrix[i, j];
            set => matrix[i, j] = value;
        }

        public Matrix3x3()
        {
            for (var i = 0; i < height; i++)
            {
                for (var j = 0; j < height; j++)
                {
                    matrix[i, j] = 0;
                }
            }
        }

        public Matrix3x3(double number)
        {
            for (var i = 0; i < height; i++)
            {
                for (var j = 0; j < height; j++)
                {
                    matrix[i, j] = number;
                }
            }
        }

        public Matrix3x3(double[][] numbers)
        {
            for (var i = 0; i < height; i++)
            {
                for (var j = 0; j < height; j++)
                {
                    matrix[i, j] = numbers[i][j];
                }
            }
        }

        public Matrix3x3(double x1, double x2, double x3, double y1, double y2, double y3, double i1, double i2, double i3)
        {
            matrix[0, 0] = x1;
            matrix[0, 1] = x2;
            matrix[0, 2] = x3;

            matrix[1, 0] = y1;
            matrix[1, 1] = y2;
            matrix[1, 2] = y3;

            matrix[2, 0] = i1;
            matrix[2, 1] = i2;
            matrix[2, 2] = i3;
        }

        public static Matrix3x3 operator +(Matrix3x3 matrix1)
        {
            return Add(matrix1);
        }

        public static Matrix3x3 operator -(Matrix3x3 matrix1)
        {
            return Add(matrix1);
        }

        private static Matrix3x3 Add(Matrix3x3 matrix1)
        {
            Matrix3x3 result = new Matrix3x3();
            for (var i = 0; i < matrix1.height; i++)
            {
                for (var j = 0; j < matrix1.height; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix[i, j];
                }
            }

            return result;
        }


        private static Matrix3x3 Subtract(Matrix3x3 matrix1)
        {
            Matrix3x3 result = new Matrix3x3();
            for (var i = 0; i < matrix1.height; i++)
            {
                for (var j = 0; j < matrix1.height; j++)
                {
                    result[i, j] = matrix[i, j]

                    - matrix1[i, j];
                }
            }

            return result;
        }
