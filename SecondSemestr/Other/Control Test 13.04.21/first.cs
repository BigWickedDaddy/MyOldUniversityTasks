using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace frst
{
    struct SetofStacks
    {
        readonly int maxvalue;
        public List<Stack<int>> stack;
        public int i { get;  set; }

        public SetofStacks(int maxcount)
        {
            i = 0;
            maxvalue = maxcount;
            stack = new List<Stack<int>>();
        }

        public int Pop()
        {
            if (stack.Count == 0)
                return 0;
            else
            {
                int a = stack[i % maxvalue].Pop();
                i--;
                return a;
            }
        }

        public void Push(int value)
        {
            if (stack.Count == 0)
            {
                stack[0] = new Stack<int>();
                stack[0].Push(value);
                i++;
            }

            if (i % maxvalue == 0)
            {
                stack[i % maxvalue + 1] = new Stack<int>();
                stack[i % maxvalue + 1].Push(value);
                i++;
            }
            else
            {
                stack[i % maxvalue].Push(value);
                i++;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
}