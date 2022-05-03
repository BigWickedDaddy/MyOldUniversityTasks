using System;
using System.Collections.Generic;

namespace Список_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> data = new List<string>();
            all_eq(data);
        }
        public static List<string> all_eq(List<string> a)
        {
            List<string> data2 = a;

            int max = 0;
            //int variable=0;
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i].Length > max)
                    max = a[i].Length;
                else
                {
                    //variable = max - a[i].Length;
                    while (a[i].Length != max)
                        data2[i]=data2[i] + "_";
                }
            }
           
            return data2;
        }
    }
}
