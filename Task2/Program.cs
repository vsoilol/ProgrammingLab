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
            const char firstSymbol = 'f';
            const char secondSymbol = 'a';

            StringBuilder testString = new StringBuilder("adffgaduifad,mkalpka");

            InsertSymbolAfterSymbol(testString, firstSymbol, secondSymbol);
            Console.WriteLine($"Новая строка {testString}");

            testString = new StringBuilder("hellohelkoplehelnhdhel");
            string substring = "hel";

            DoubleSubstring(testString, substring);
            Console.WriteLine($"Новая строка {testString}");

        }

        static private void InsertSymbolAfterSymbol(StringBuilder stringBuilder, char insertSymbol, char symbol)
        {
            stringBuilder.Replace(symbol.ToString(), symbol.ToString() + insertSymbol.ToString());
        }

        static private void DoubleSubstring(StringBuilder stringBuilder, string substring)
        {
            stringBuilder.Replace(substring, substring + substring);
        }
    }
}
