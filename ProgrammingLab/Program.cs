using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            const char firstSymbol = 'f';
            const char secondSymbol = 'a';

            string testString = "aoooaoooallfhhhgfff";

            Console.WriteLine($"Исходная строка {testString}");

            Console.WriteLine($"Сумма всех вхождений символов '{firstSymbol}' и '{secondSymbol}': {GetSumSymbolsOccurrences(testString, firstSymbol, secondSymbol)}");

            var result = GetHighestOccurrence(testString, firstSymbol, secondSymbol);

            Console.WriteLine($"Наибольшее вхождение '{result.symbol}' составляет {result.occurrence}");
        }

        static private int GetSumSymbolsOccurrences(string text, char firstSymbol, char secondSymbol)
        {
            int firstSymbolOccurrences = 0;
            int secondSymbolOccurrences = 0;

            foreach (var symbol in text)
            {
                if(firstSymbol == symbol)
                {
                    firstSymbolOccurrences++;
                }
                else if(secondSymbol == symbol)
                {
                    secondSymbolOccurrences++;
                }
            }

            return firstSymbolOccurrences + secondSymbolOccurrences;
        }

        static private (char symbol, int occurrence) GetHighestOccurrence(string text, char firstSymbol, char secondSymbol)
        {
            int firstSymbolOccurrences = 0;
            int secondSymbolOccurrences = 0;

            foreach (var symbol in text)
            {
                if (firstSymbol == symbol)
                {
                    firstSymbolOccurrences++;
                }
                else if (secondSymbol == symbol)
                {
                    secondSymbolOccurrences++;
                }
            }

            if(secondSymbolOccurrences > firstSymbolOccurrences)
            {
                return (secondSymbol, secondSymbolOccurrences);
            }

            return (firstSymbol, firstSymbolOccurrences);
        }
    }
}
