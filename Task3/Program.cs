using System;
using System.Collections.Generic;
using System.Linq;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString = "Привет, это очень интересный проект. Если хочешь узнать, что там проста запусти проект";

            Console.WriteLine($"Исходная строка: {testString}");

            Console.WriteLine($"\nВ алфавитном порядке:\n{AlphabeticalOrder(testString)}");

            Console.WriteLine($"\nСортировка по самому длинному слову:\n{LongestOrder(testString)}");
        }

        static private string AlphabeticalOrder(string text)
        {
            char[] div = { ' ', ',', '.', ':', '!', '?', ';', ';', '-' };
            List<string> words = text.Split(div, StringSplitOptions.RemoveEmptyEntries).ToList();
            words.Sort();
            return string.Join(" | ", words);
        }

        static private string LongestOrder(string text)
        {
            char[] div = { ' ', ',', '.', ':', '!', '?', ';', ';', '-' };
            List<string> words = text.Split(div, StringSplitOptions.RemoveEmptyEntries).ToList();
            //words.OrderBy(word => word.Length);
            return string.Join(" | ", words.OrderBy(word => word.Length));
        }
    }
}
