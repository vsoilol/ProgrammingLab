using System;

namespace ProgrammingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            double eps = 0.00001;
            double a = 1;
            double s = 0;
            double summaMy;

            summaMy = MySummaWithFactorial(1, eps, ref a, ref s);
            Console.WriteLine($"Сумма через факториал =  {summaMy}\na = {a}");

            //a = 1;
            //s = 1;

            //summaMy = MySummaWithoutFactorial(0, eps, ref a, ref s);
            //Console.WriteLine($"\nСумма без факториала = {summaMy}\na = {a}");
        }

        static long Factorial(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            else
                return n * Factorial(n - 1);
        }

        /// <summary>
        /// 2^n / (n + 1)!
        /// </summary>
        /// <param name="n">n</param>
        /// <param name="eps">точность</param>
        /// <param name="a">Промежуточное значение</param>
        /// <param name="s">Сумма</param>
        /// <returns></returns>
        static double MySummaWithFactorial(int n, double eps, ref double a, ref double s)
        {
            if (Math.Abs(a) < eps)
                return s;
            else
            {
                a = (Math.Pow(-1, n) * n) / (Math.Pow(2 * n - 1, 2) * Math.Pow(2 * n + 1, 2));
                s += a;
                return MySummaWithFactorial(n + 1, eps, ref a, ref s);
            }
        }

        /// <summary>
        /// An+1 = An * Tn, Tn = 2 / (n+2)
        /// </summary>
        /// <param name="n"></param>
        /// <param name="eps">Точность</param>
        /// <param name="a">Промежуточное значение</param>
        /// <param name="s">Сумма</param>
        /// <returns></returns>
        static double MySummaWithoutFactorial(int n, double eps, ref double a, ref double s)
        {
            if (Math.Abs(a) < eps)
                return s;
            else
            {
                a *= 2D / (n + 2);
                s += a;
                return MySummaWithoutFactorial(n + 1, eps, ref a, ref s);
            }
        }
    }
}
