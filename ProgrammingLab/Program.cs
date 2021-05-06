using Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgrammingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstArray = CreateRandomArray(10).ToList();
            List<int> secondArray = CreateRandomArray(20).ToList();

            AlgorithmBase<int> sort = new QuickSort<int>();

            sort.Sort(firstArray);
            sort.Sort(secondArray);

            Console.WriteLine("Первый массив:");
            foreach (var item in firstArray)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine("\nВторой массив:");
            foreach (var item in secondArray)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine("\nРезультат:");
            var newArray = MergeArrays(firstArray, secondArray);

            foreach (var item in newArray)
            {
                Console.Write($"{item} ");
            }
        }

        public static IEnumerable<int> MergeArrays(List<int> firstArray, List<int> secondArray)
        {
            List<int> result = new List<int>();
            int firstArrayIterator = 0;
            int secondArrayIterator = 0;

            while ((firstArrayIterator != firstArray.Count) && (secondArrayIterator != secondArray.Count))
            {
                if (firstArray[firstArrayIterator] <= secondArray[secondArrayIterator])
                {
                    result.Add(firstArray[firstArrayIterator]);
                    firstArrayIterator++;
                }
                else
                {
                    result.Add(secondArray[secondArrayIterator]);
                    secondArrayIterator++;
                }
            }

            while (firstArrayIterator != firstArray.Count)
            {
                result.Add(firstArray[firstArrayIterator]);
                firstArrayIterator++;
            }

            while (secondArrayIterator != secondArray.Count)
            {
                result.Add(secondArray[secondArrayIterator]);
                secondArrayIterator++;
            }
            return result;
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
