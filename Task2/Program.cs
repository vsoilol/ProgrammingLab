using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder firstTask = new StringBuilder("1Hello36273447W6or67ldHow76AreYou23");

            DeleteNumbers(ref firstTask);
            Console.WriteLine(firstTask);

            StringBuilder secondTask = new StringBuilder("OMGGG!!!!!!!aaattttkkkklaaaa");

            DeleteLongestRecurringChar(ref secondTask);
            Console.WriteLine(secondTask);
        }

        static private void DeleteNumbers(ref StringBuilder stringBuilder)
        {
            for (int i = 0; i < stringBuilder.Length; i++)
            {
                if (Char.IsDigit(stringBuilder[i]))
                {
                    stringBuilder.Remove(i, 1);
                    i--;
                }
            }
        }

        static private void DeleteLongestRecurringChar(ref StringBuilder stringBuilder)
        {
            char longestChar = stringBuilder[0];

            int maxRepeat = 1;
            int repeat = 0;
            int finiteIndex = 0;

            for (int i = 0; i < stringBuilder.Length - 1; i++)
            {
                if(stringBuilder[i] == stringBuilder[i + 1])
                {
                    repeat++;

                }
                else
                {
                    if(repeat > maxRepeat)
                    {
                        longestChar = stringBuilder[i];
                        finiteIndex = i;
                        maxRepeat = repeat;
                    }
                    repeat = 1;
                }
            }

            stringBuilder.Remove(finiteIndex - maxRepeat + 1, maxRepeat);
        }
    }
}
