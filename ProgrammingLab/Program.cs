using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgrammingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[7, 5];
            string result = "\n";
            Random random = new Random();

            for (int row = 0; row <= matrix.GetUpperBound(0); row++)
            {
                for (int column = 0; column <= matrix.GetUpperBound(1); column++)
                {
                    matrix[row, column] = random.Next(1, 10);

                    if (matrix[row, column] % 3 == 0)
                    {
                        result += $"Число {matrix[row, column]} кратно 3 и " +
                            $"находится на {row + 1} строке и на {column + 1} столбце\n";
                    }
                }
            }

            Console.WriteLine("Исходная матрица:");
            Console.WriteLine(matrix.GetArrayElements());
            Console.WriteLine(result);

            List<int> array = matrix.ToArray().ToList();

            QuickSort<int> sort = new QuickSort<int>();
            sort.Sort(array);

            Console.WriteLine("После сортировки:");
            Console.WriteLine(sort.Items.ToTwoDimensionalArray(matrix.GetUpperBound(0) + 1, matrix.GetUpperBound(1) + 1).GetArrayElements());
        }
    }
}
