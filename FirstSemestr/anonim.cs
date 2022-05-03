using System;
using System.Linq;

namespace anonimmethods
{
    class Program
    {

        delegate int Example();
        delegate double Delegates(Example[] arr);


        static void Main(string[] args)
        {
            Delegates sum = delegate (Example[] arr)
            {
                return Method(arr);
            };

            var array = new Example[]
            {
                GetRandom,
                GetRandom
            };

            Console.WriteLine(sum(array));
            Console.ReadKey();
        }

        private static double Method(Example[] arr)
        {
            return arr.Select(x => x()).Average();
        }

        static int GetRandom()
        {
            var r = new Random();
            return r.Next();
        }
    }
}
