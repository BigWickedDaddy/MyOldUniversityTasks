using System;

namespace Контрольная16._12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Кол-во чисел: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите ваши числа через ENTER: ");
            
            string[] Massiv1 = new string[100];
            string[] Massiv2 = new string[100];
            for (int i = 0; i < a; i++)
            {
                string n = Console.ReadLine();
                if (n.Length < 20) Massiv1[i] = n;
                else Massiv2[i] = n;
            }

            Console.WriteLine("Ваши массив сингллонг : ");
            for (int i = 0; i < a; i++)
                Console.Write(Massiv1[i] + " ");

            Console.WriteLine("\nВаши массив верилонг : ");
            for (int i = 0; i < a; i++)
                Console.Write(Massiv2[i] + " ");
            Console.ReadKey();
        }
    }
    class Number
    {
        public const int MaxValue = 2147483647;

        private int Number1
        {
            get => Number1;
            set => this.Number1 = Number1;
        }
        public Number()
        {
            Number1 = 0;
        }

        public Number(int n)
        {
            Number1 = n;
        }

        Number Add(Number n)
        {
            return new Number(Number1 += n.Number1);
        }

        public static Number operator +(Number a1, Number a2)
        {
            return new Number(a1.Number1 + a2.Number1);
        }
        Number Sub(Number n)
        {
            if (n.Number1 > Number1)
                throw new ArgumentException("Натуральное ");

            return new Number(Number1 = Number1 - n.Number1);
        }
        public static Number operator -(Number a1, Number a2)
        {
            return new Number(a1.Number1 + a2.Number1);
        }
        public int CompareTo(Number n)
        {
            if (Number1 > n.Number1)
                return 1;
            if (Number1 < n.Number1)
                return -1;
            else return 0;
        }
    }
    public class SimpleLongNumber
    {
        private long Number1
        {
            get => Number1;
            set => this.Number1 = Number1;
        }
        public SimpleLongNumber()
        {
            Number1 = 0;
        }

        public SimpleLongNumber(long n)
        {
            Number1 = n;
        }

        SimpleLongNumber Add(SimpleLongNumber n)
        {
            return new SimpleLongNumber(Number1 += n.Number1);
        }

        public static SimpleLongNumber operator +(SimpleLongNumber a1, SimpleLongNumber a2)
        {
            return new SimpleLongNumber(a1.Number1 + a2.Number1);
        }
        SimpleLongNumber Sub(SimpleLongNumber n)
        {
            if (n.Number1 > Number1)
                throw new ArgumentException("Натуральное ");

            return new SimpleLongNumber(Number1 = Number1 - n.Number1);
        }
        public static SimpleLongNumber operator -(SimpleLongNumber a1, SimpleLongNumber a2)
        {
            return new SimpleLongNumber(a1.Number1 + a2.Number1);
        }
        public int CompareTo(SimpleLongNumber n)
        {
            if (Number1 > n.Number1)
                return 1;
            if (Number1 < n.Number1)
                return -1;
            else return 0;
        }

    }

    public class VeryLongNumber
    {

        private string Number1 = "";

        public VeryLongNumber(long n)
        {
            Number1 = n.ToString();
        }


        public VeryLongNumber()
        {
            Number1 = "0";
        }

        public VeryLongNumber(string n)
        {
            Number1 = n;
        }

        VeryLongNumber Add(VeryLongNumber n)
        {
            return new VeryLongNumber(Convert.ToInt64(Number1) + Convert.ToInt64(n.Number1));
        }

        public static VeryLongNumber operator +(VeryLongNumber a1, VeryLongNumber a2)
        {
            return new VeryLongNumber(Convert.ToInt64(a1.Number1) + Convert.ToInt64(a2.Number1));
        }
        VeryLongNumber Sub(VeryLongNumber n)
        {
            if (Convert.ToInt64(n.Number1) > Convert.ToInt64(Number1))
                throw new ArgumentException("Натуральное ");

            return new VeryLongNumber(Convert.ToInt64(Number1) - Convert.ToInt64(n.Number1));
        }
        public static VeryLongNumber operator -(VeryLongNumber a1, VeryLongNumber a2)
        {
            return new VeryLongNumber(a1.Number1 + a2.Number1);
        }
        public int CompareTo(VeryLongNumber n)
        {
            if (Convert.ToInt64(Number1) > Convert.ToInt64(n.Number1))
                return 1;
            if (Convert.ToInt64(Number1) < Convert.ToInt64(n.Number1))
                return -1;
            else return 0;
        }

    }
    class equations
    {
        static void Main2(string[] args)
        {
           
            string[] inLine = Console.ReadLine().Split();
            int N = int.Parse(inLine[0]);   
            int M = int.Parse(inLine[1]);  
            double[,] A = new double[M, N + 1];  
            for (int i = 0; i < M; i++)
            {
                inLine = Console.ReadLine().Split();
                A[i, int.Parse(inLine[0]) - 1] = 1;
                A[i, int.Parse(inLine[1]) - 1] = 1;
                A[i, N] = int.Parse(inLine[2]);
            }

            if (M < N)
                Console.WriteLine("IMPOSSIBLE");
            else
            {
                double[] result = GaussMethod(A);
                for (int i = 0; i < M; i++)
                    if (double.IsNaN(result[i]))
                    {
                        Console.WriteLine("IMPOSSIBLE");
                        return;
                    }
                for (int j = 0; j < result.Length; j++)
                    Console.WriteLine("{0:0.00}", result[j]);
            }
        }

        static double[] GaussMethod(double[,] a)
        {
            
            int width = a.GetLength(1);
            int height = a.GetLength(0);
            

            double[] x = new double[height]; 
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = a[i, width - 1];
            }

            
            double m;
            for (int i = 0; i < width - 1; i++)
                for (int j = i + 1; j < height; j++)
                {
                    m = a[j, i] / a[i, i];
                    if (double.IsNaN(m)) m = 0;
                    for (int k = 0; k < height; k++)
                        a[j, k] -= m * a[i, k];
                    x[j] -= m * x[i];
                }

            for (int i = 0; i < height; i++)
                a[i, width - 1] = x[i];
           

            for (int i = height - 1; i >= 0; i--)
            {
                for (int j = i + 1; j < width - 1; j++)
                {
                    x[i] -= i != j ? a[i, j] * x[j] : 0;
                }
                x[i] = x[i] / a[i, i];
            }
            return x;
        }
    }
}
