using System;

namespace ProgrammingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = -10; i <= 10; i++)
            {
                Console.WriteLine($"{i} - {RaiseDegree(i)}");
            }
        }

        /// <summary>
        /// Метод который возводит число в квадрат если число больше нуля и в куб если меньше
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static public int RaiseDegree(int number)
        {
            return (number >= 0) ? number * number : number * number * number;
        }
    }
}
