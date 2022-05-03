using System;

namespace сортировки
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во чисел : ");
            int n = int.Parse(Console.ReadLine());
            int[] A = new int[n];
            for (int i = 0; i < n; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Сортировка пузырькром : ");

            int t;

            for (int i = 0; i < A.Length - 1; i++)
            {
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (A[i] > A[j])
                    {
                        t = A[i];
                        A[i] = A[j];
                        A[j] = t;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(A[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Сортировка вставками : ");
            for (var i = 1; i < A.Length; i++)
            {
                var key = A[i];
                var j = i;
                while ((j > 1) && (A[j - 1] > key))
                {
                    
                    Swap(ref A[j - 1], ref A[j]);
                    j--;
                }

                A[j] = key;
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(A[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Сортировка выбором : ");

            for (int i = 0; i < A.Length - 1; i++)
            {
                //поиск минимального числа
                int min = i;
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (A[j] < A[min])
                    {
                        min = j;
                    }
                }
                //обмен элементов
                int temp = A[min];
                A[min] = A[i];
                A[i] = temp;
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(A[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Сортировка слиянием : ");
            MergeSort_Recursive(A, 0, n - 1);
            for (int i = 0; i < n; i++)
            {
                Console.Write(A[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Сортировка быстрая : ");
            Console.WriteLine("Упорядоченный массив: {0}", string.Join(", ", QuickSort(A)));
            Console.ReadKey();
        }
        //метод возвращающий индекс опорного элемента
        static int Partition(int[] array, int minIndex, int maxIndex)
        {
            var pivot = minIndex - 1;
            for (var i = minIndex; i < maxIndex; i++)
            {
                if (array[i] < array[maxIndex])
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                }
            }

            pivot++;
            Swap(ref array[pivot], ref array[maxIndex]);
            return pivot;
        }

        //быстрая сортировка
        static int[] QuickSort(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }

            var pivotIndex = Partition(array, minIndex, maxIndex);
            QuickSort(array, minIndex, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, maxIndex);

            return array;
        }

        static int[] QuickSort(int[] array)
        {
            return QuickSort(array, 0, array.Length - 1);
        }
      







        static public void DoMerge(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[25];
            int i, left_end, num_elements, tmp_pos;

            left_end = (mid - 1);
            tmp_pos = left;
            num_elements = (right - left + 1);

            while ((left <= left_end) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[tmp_pos++] = numbers[left++];
                else
                    temp[tmp_pos++] = numbers[mid++];
            }

            while (left <= left_end)
                temp[tmp_pos++] = numbers[left++];

            while (mid <= right)
                temp[tmp_pos++] = numbers[mid++];

            for (i = 0; i < num_elements; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }

        static public void MergeSort_Recursive(int[] numbers, int left, int right)
        {
            int mid;

            if (right > left)
            {
                mid = (right + left) / 2;
                MergeSort_Recursive(numbers, left, mid);
                MergeSort_Recursive(numbers, (mid + 1), right);

                DoMerge(numbers, left, (mid + 1), right);
            }
        }
        static void Swap(ref int e1, ref int e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }
    }
}
