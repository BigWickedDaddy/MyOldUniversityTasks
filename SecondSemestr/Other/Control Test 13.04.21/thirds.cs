using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> first = new Dictionary<string, int>(5);
            Dictionary<string, int> second = new Dictionary<string, int>(5);
            first.Add("a", 1);
            first.Add("b", 3);
            first.Add("c", 2);
            first.Add("d", 4);
            first.Add("e", 5);

            second.Add("a", 1);
            second.Add("b", 3);
            second.Add("c", 2);
            second.Add("d", 4);
            second.Add("e", 5);

            List<Dictionary<string, int>> dicts = new List<Dictionary<string, int>>(2);
            List<Dictionary<string, int>> seconddictionaries = new List<Dictionary<string, int>>(2);
            var result = new Dictionary<string, int>();
            dicts.Add(first);
            dicts.Add(second);
            result = max_dct(dicts);

            Console.WriteLine();
            Console.ReadKey();

        }
        private static Dictionary<string, int> max_dct(List<Dictionary<string, int>> dicts)
        {
            var result = new Dictionary<string, int>();


            result = dicts.SelectMany(dict => dict)
            .ToLookup(x => x.Key, y => y.Value)
            .ToDictionary(x => x.Key, y => y.Max());


            return result;
        }

        private static Dictionary<string, int> sum_dct(List<Dictionary<string, int>> dicts)
        {
            var result = new Dictionary<string, int>();


            result = dicts.SelectMany(dict => dict)
            .ToLookup(x => x.Key, y => y.Value)
            .ToDictionary(x => x.Key, y => y.Sum());


            return result;
        }

    }
}
