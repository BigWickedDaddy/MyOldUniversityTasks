using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TheSecond
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class TheSecond<T>
    {
        public Stack<T> VariableStack { get; set; }
        public int Release { get; set; }
        public Dictionary<int, Stack<T>> Releases { get; set; }

    public TheSecond()
    {
        Release=0;
        Releases = new Dictionary<int, Stack<T>>();
        VariableStack = new Stack<T>();
        Releases.Add(Release, VariableStack);
    }
    public void Push(T item)
    {
        Release++;
        VariableStack.Push(item);
        if (!Releases.ContainsKey(Release)) Releases.Add(Release, new Stack<T>(VariableStack));
    }


    public void Pop()
    {
        Release++;
        VariableStack.Pop();
        var n = new Stack<T>(VariableStack);
        if (!Releases.ContainsKey(Release)) Releases.Add(Release, n);
    }
    public void Forget()
    {
        Releases.Clear();
        Release = 0;
    }

}
}
