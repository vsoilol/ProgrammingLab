using System;
using System.Linq;

namespace ProgrammingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] Task1 = new double[]
            {
                1.9, 2, 80.1, 5.4, 6.6
            };

            double[][] Task2 = new double[][]
            {
                new double[]{1.6, 5, 0, 9.2},
                new double[]{1, 5.5, 5, 9},
                new double[]{1, 7.5, 0, 9.3}
            };

            while (true)
            {
                Console.WriteLine("1. Первое задание");
                Console.WriteLine("2. Второе задание");
                Console.WriteLine("3. Выход");
                Console.Write("Выберите операцию: ");

                MenuItem numberOperation = (MenuItem)int.Parse(Console.ReadLine());

                switch (numberOperation)
                {
                    case MenuItem.TaskOne:
                        Console.WriteLine($"\nРезультат унможения: {ProductAfterMaxElement(Task1)}\n");
                        break;
                    case MenuItem.TaskTwo:
                        double[] result = SumElement(Task2);
                        Console.WriteLine();
                        for (int i = 0; i < result.Length; i++)
                        {
                            Console.WriteLine($"Сумма элементов строки {i + 1}: {result[i]}");
                        }
                        Console.WriteLine();
                        break;
                    case MenuItem.Exit:
                        return;
                }
            }
        }


        /// <summary>
        /// Находит произведенте элементов находящихся после максимального элемента
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        static double ProductAfterMaxElement(double[] array)
        {
            int maxElementIndex = array.Select((x, i) => new { x, i })
                                        .Aggregate((a, a1) => a.x > a1.x ? a : a1).i;
            double product = 0;

            if (maxElementIndex != array.Length - 1)
                product = array.Skip(maxElementIndex + 1).Aggregate((x, y) => x * y);

            return product;
        }

        /// <summary>
        /// Находим сумму элеменотов строки в которой есть нулевое значение
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        static double[] SumElement(double[][] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;

            double[] sum = new double[rows];

            for (int i = 0; i < rows; i++)
            {
                if (matrix[i].Any(t => t == 0))
                {
                    sum[i] = matrix[i].Sum();
                }
            }

            return sum;
        }
    }
}
