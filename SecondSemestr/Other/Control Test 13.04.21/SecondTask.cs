using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Контрольная_работа
{
    
    class Program
    {
        static void Main(string[] args)
        {
            List<double> first = new List<double>() { 1, 3, 5, 7, 5, 6, 7, 8, 9, 10 };
            int value = first.Count;
            List<double> second = new List<double>(first.Count) { 0 , 0 , 0 , 0 , 0 , 0 , 0 , 0 , 0 , 0 };

            if (first.Count > 1) 
            {
                second[0] = first[0];
                Console.WriteLine(second[0]);
            }
            for(int i = 1; i < first.Count; i++)
            {
                second[i] = first[i] + second[i - 1];
                Console.WriteLine(second[i]+ " ");
            }



            Console.ReadKey();
        }
        public static void SumList()
        {
           // List<double> second = new List<double>() {1,2,3,4,5,6,7,8,9,10};
        }
    }
}
