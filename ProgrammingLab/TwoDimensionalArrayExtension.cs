using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingLab
{
    public static class TwoDimensionalArrayExtension
    {
        public static string GetArrayElements(this int[,] matrix)
        {
            string result = "";

            for (int row = 0; row <= matrix.GetUpperBound(0); row++)
            {
                for (int column = 0; column <= matrix.GetUpperBound(1); column++)
                {
                    result += $"{matrix[row, column]}\t";
                }
                result += "\n";
            }

            return result;
        }

        public static IEnumerable<int> ToArray(this int[,] matrix)
        {
            List<int> result = new List<int>();

            for (int row = 0; row <= matrix.GetUpperBound(0); row++)
            {
                for (int column = 0; column <= matrix.GetUpperBound(1); column++)
                {
                    result.Add(matrix[row, column]);
                }
            }

            return result;
        }
    }
}
