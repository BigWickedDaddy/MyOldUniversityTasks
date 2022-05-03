using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            List < List < int >> list = new List<List<int>>()
        {
            new List<int> {1 , 2 , 3 , 4 },
            new List<int> {1 , 2 , 3 , 4 , 5 },
            new List<int> {1 , 2 , 3 , 4 , 5 , 6 }
        };
            List<int> result = new List<int>();
            var variable = list.SelectMany(x => x).Take(5);
            Console.ReadKey();
        }
    }
}