using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ProgrammingLab
{
    public static class ArrayExtension
    {
        public static int[,] ToTwoDimensionalArray(this IEnumerable<int> array, int rows, int columns)
        {
            int[,] matrix = new int[rows, columns];

            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < columns; column++)
                {
                    matrix[row, column] = array.ElementAt(row*columns + column);
                }
            }

            return matrix;
        }
    }
}
