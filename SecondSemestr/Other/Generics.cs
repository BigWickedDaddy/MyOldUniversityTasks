using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            Number<long> number1 = new Number<long>();
            Number<int> number2 = new Number<int>();
            Number<string> number3 = new Number<string>();
            number1.Add((long)10);
            number1.Sub((long)6);
            number1.CompareTo((long)2);
            number2.Add(3);
            number2.Sub(1);
            number2.CompareTo(1);
            number3.Add("5");
            number3.Sub("1");
            number3.CompareTo("4");
        }
    }
    class Number<T>
    {
        
        public double save = 0;
        public double[] NumSave = new double[100];
        private int i = 0;
        public void Sub(T n)
        {
            double val = Convert.ToDouble(n);
            if (val > save) throw new Exception(" = отрицательное значение");
            else
            {
                Console.WriteLine(save - val);
                save = save - val;
            }
        }
        public void Add(T n)
        {
            double val = Convert.ToDouble(n);
            Console.WriteLine(save + val);
            save = save + val;
        }
        
        public int CompareTo(T n)
        {
            double val = Convert.ToDouble(n);
            Console.WriteLine(val.CompareTo(save));
            return val.CompareTo(save);
        }
        public void saveNum()
        {
            NumSave[i] = save;
            i++;
        }
    }
}
