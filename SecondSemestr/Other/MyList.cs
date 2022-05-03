using System;
using System.Collections.Generic;
using System.Linq;


namespace MyList
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class List<T>
    {
        public T[] Items { get; set; }

        public void ChangeMin()
        {
            var list = new List<T>(Items);
            list.Sort();
            var min = list.Items[0];
            var max = list.Items[Items.Length - 1];
            for (int i = 0; i < Items.Length; i++)
            {
                if (Equals(Items[i], min))
                {
                    Items[i] = max;
                }
                else if (Equals(Items[i], max))
                {
                    Items[i] = min;
                }
            }

        }

        public List()
        {
            Items = new T[1];
            int Length = Items.Length;
        }

        public List(T[] Items)
        {
            this.Items = Items;
            int Length = this.Items.Length;
        }

        public void Add(T item)
        {
            int end = Items.Length;
            var increase = new T[Items.Length + 1];
            for (int i = 0; i < Items.Length; i++)
            {
                increase[i] = Items[i];
            }
            Items = increase;
            Items[end] = item;
        }

        public void AddRange(T[] collection)
        {
            var result = new T[Items.Length + collection.Length];
            int indexCollect = 0;
            for (int i = 0; i < result.Length; i++)
            {
                if (i < Items.Length)
                {
                    result[i] = Items[i];
                }
                else
                {
                    result[i] = collection[indexCollect];
                    indexCollect++;
                }
            }
            Items = result;
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < Items.Length; i++)
            {
                if (Items[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }

        public void Insert(int index, T item)
        {
            var result = new T[Items.Length + 1];
            int indexItem = 0;
            for (int i = 0; i < result.Length; i++)
            {
                if (i == index)
                {
                    result[i] = item;
                }
                else
                {
                    result[i] = Items[indexItem];
                    indexItem++;
                }
            }
            Items = result;
        }
        public void Sort()
        {
            Array.Sort<T>(this.Items, 0, Items.Length, null);
        }

        public bool Remove(T item)
        {
            int itemcount = 0;
            int resultindex = 0;
            var result = new T[Items.Length - itemcount];


            for (int i = 0; i < Items.Length; i++)
            {
                if (Items[i].Equals(item))
                    itemcount++;
            }

            for (int i = 0; i < Items.Length; i++)
            {
                if (Items[i].Equals(item))
                {
                    itemcount--;
                    continue;
                }
                else
                {
                    result[resultindex] = Items[i];
                    resultindex++;
                }
            }
            Items = result;
            if (itemcount == 0) return true;
            else return false;
        }

        public void RemoveAt(int index)
        {
            var result = new T[Items.Length - 1];

            int resultindex = 0;
            for (int i = 0; i < Items.Length; i++)
            {
                if (i == index)
                {
                    continue;
                }
                result[resultindex] = Items[i];
                resultindex++;
            }
            Items = result;
        }

    }
}