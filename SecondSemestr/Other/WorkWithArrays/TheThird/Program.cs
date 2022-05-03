using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._05
{
    class Program
    {
        static void Main(string[] args)
        {
            int value1 = 1;
            int value2 = 1;

            int a1 = int.Parse(Console.ReadLine());
            int b1 = int.Parse(Console.ReadLine());

            int a2 = int.Parse(Console.ReadLine());
            int b2 = int.Parse(Console.ReadLine());



            if (a1 == a2) value1 = 1;
            else if (a1 > a2) value1 = a1 - a2 + 1;
            else if (a2 > a1) value1 = a2 - a1 + 1;

            if (b1 == b2) value2 = 1;
            else if (b1 > b2) value2 = b1 - b2 + 1;
            else if (b2 > b1) value2 = b2 - b1 + 1;


            int[] x1 = new int[value1];
            if (a1 > a2)
            {
                for (int i = 0; i < x1.Length; i++)
                {
                    x1[i] = a1 - i;
                }
            }
            else
            {
                for (int i = 0; i < x1.Length; i++)
                {

                    x1[i] = a2 - i;
                }
            }


            int[] y1 = new int[value2];
            if (b1 > b2)
            {
                for (int i = 0; i < y1.Length; i++)
                {
                    y1[i] = b1 - i;
                }
            }
            else
            {
                for (int i = 0; i < y1.Length; i++)
                {
                    y1[i] = b2 - i;
                }
            }




            int a3 = int.Parse(Console.ReadLine());
            int b3 = int.Parse(Console.ReadLine());

            int a4 = int.Parse(Console.ReadLine());
            int b4 = int.Parse(Console.ReadLine());

            value1 = 1;
            value2 = 1;

            if (a3 == a4) value1 = 1;
            else if (a3 > a4) value1 = a3 - a4 + 1;
            else if (a4 > a3) value1 = a4 - a3 + 1;

            if (b3 == b4) value2 = 2;
            else if (b3 > b4) value2 = b3 - b4 + 1;
            else if (b4 > b3) value2 = b4 - b3 + 1;



            int[] x2 = new int[value1];

            if (a3 > a4)
            {
                for (int i = 0; i < x2.Length; i++)
                {
                    x2[i] = a3 - i;
                }
            }
            else
            {
                for (int i = 0; i < x2.Length; i++)
                {
                    x2[i] = a4 - i;
                }
            }

            int[] y2 = new int[value2];

            if (b3 > b4)
            {
                for (int i = 0; i < y2.Length; i++)
                {
                    y2[i] = b3 - i;
                }
            }
            else
            {
                for (int i = 0; i < y2.Length; i++)
                {
                    y2[i] = b3 - i;
                }
            }




            value1 = 999;
            value2 = 999;

            if (x1.Length > x2.Length)
            {
                for (int i = 0; i < x1.Length; i++)
                {
                    if (x1[i] == x2[0])
                    {
                        value1 = x1[i];
                    }
                }

            }
            else if (x2.Length > x1.Length)
            {
                for (int i = 0; i < x2.Length; i++)
                {
                    if (x2[i] == x1[0])
                    {
                        value1 = x2[i];
                    }
                }

            }


            if (y1.Length > y2.Length)
            {
                for (int i = 0; i < y1.Length; i++)
                {
                    if (y1[i] == y2[0])
                    {
                        value2 = y1[i];
                    }
                }
            }
            else if (y2.Length > y1.Length)
            {
                for (int i = 0; i < y2.Length; i++)
                {
                    if (y2[i] == y1[0])
                    {
                        value2 = y2[i];
                    }
                }
            }


            Console.WriteLine();

            if (value1 != 999 && value2 != 999)
                Console.WriteLine("Точка : " + value1 + " " + value2);
            else Console.WriteLine("Net");

            Console.ReadKey();

        }
    }
}
