using System;

namespace Rsceptions
{
    class Program
    {
        static void Main()
        {
            var x = Convert.ToInt32(Console.ReadLine());
            var y = Convert.ToInt32(Console.ReadLine());
            SimpleMethod(x, y);
            Console.ReadKey();
        }



        static void SimpleMethod(int x, int y)
        {

            string str = null;
            byte[] array = new byte[1];

            try
            {
                var z = x / y;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("DivideByZeroException \n");
            }

            try
            {
                var date = Convert.ToDateTime(x);
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("InvalidCastException \n");
            }

            try
            {
                string k = null;
                int.Parse(k);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("ArgumentNullException \n");
            }

            try
            {
                var b = array[2];
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("IndexOutOfRangeException \n");
            }

            try
            {
                if (x == 0)
                {
                    throw new ArgumentException();
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("ArgumentException \n ");
            }
       }
    }
}