using Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SortAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> array = CreateRandomArray(10000).ToList();
            AlgorithmBase<int> sort = new BubbleSort<int>();

            TimeSpan time = sort.Sort(array.ToArray());
            Console.WriteLine($"Время работы сортировки пузырьком: {time.TotalMilliseconds}");

            sort = new CocktailSort<int>();
            time = sort.Sort(array.ToArray());
            Console.WriteLine($"Время работы шейкерной сортировки: {time.TotalMilliseconds}");

            sort = new InsertSort<int>();
            time = sort.Sort(array.ToArray());
            Console.WriteLine($"Время работы сортировки вставками: {time.TotalMilliseconds}");

            sort = new SelectionSort<int>();
            time = sort.Sort(array.ToArray());
            Console.WriteLine($"Время работы сортировки выбором: {time.TotalMilliseconds}");

            sort = new ShellSort<int>();
            time = sort.Sort(array.ToArray());
            Console.WriteLine($"Время работы сортировки Методом Шелла: { time.TotalMilliseconds}");

            sort = new QuickSort<int>();
            time = sort.Sort(array.ToArray());
            Console.WriteLine($"Время работы быстрой сортировки: { time.TotalMilliseconds}");
        }

        public static IEnumerable<int> CreateRandomArray(int length)
        {
            Random random = new Random(DateTime.Now.Millisecond);
            List<int> randomArray = new List<int>();

            for (int i = 0; i < length; i++)
            {
                randomArray.Add(random.Next(0, 100));
            }
            return randomArray;
        }
    }
}
