using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchGraph
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Graph
    {
        static public int n;
        static int rebra(int[,] m, int a)
        {
            a = 0;
            for (var j = 0; j < m.GetLength(0); j++)
            {
                for (var i = 0; i <= j; i++)
                {
                    if (m[i, j] == 1) a++;
                }
            }
            return a;
        }

        static void Incidence(int[,] matrix1, int v)
        {
            int[,] matrix2 = new int[rebra(matrix1, 0), v];
            for (var j = 0; j < v; j++)
            {
                for (var i = 0; i < j; i++)
                {
                    if (matrix1[i, j] == 1)
                    {
                        matrix2[n, i] = 1;
                        matrix2[n, j] = 1;
                        n++;
                    }
                }
            }
            for (var j = 0; j < matrix1.GetLength(1); j++)
            {
                for (var i = 0; i < matrix1.GetLength(0); i++)
                {
                    Console.Write(matrix1[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (var j = 0; j < matrix2.GetLength(1); j++)
            {
                for (var i = 0; i < matrix2.GetLength(0); i++)
                {
                    Console.Write(matrix2[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }


        private int V;

        private List<int>[] value1;

        Graph(int v)
        {
            V = v;
            value1 = new List<int>[v];
            for (int i = 0; i < v; ++i)
                value1[i] = new List<int>();
        }
        void AddEdge(int v, int w)
        {
            value1[v].Add(w);
        }

        void DFS(int v, bool[] visited)
        {
            visited[v] = true;
            Console.Write(v + " ");
            List<int> vList = value1[v];
            foreach (var n in vList)
            {
                if (!visited[n])
                    DFS(n, visited);
            }
        }



        private int _V;
        LinkedList<int>[] _adj;
        public void BFS(int s)
        {

            bool[] visited = new bool[_V];
            for (int i = 0; i < _V; i++)
                visited[i] = false;

            LinkedList<int> queue = new LinkedList<int>();

 
            visited[s] = true;
            queue.AddLast(s);

            while (queue.Any())
            {


                s = queue.First();
                Console.Write(s + " ");
                queue.RemoveFirst();

                
                LinkedList<int> list = _adj[s];

                foreach (var val in list)
                {
                    if (!visited[val])
                    {
                        visited[val] = true;
                        queue.AddLast(val);
                    }
                }
            }


        }
    }
}

