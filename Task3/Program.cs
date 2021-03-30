using System;
using System.Collections.Generic;
using System.Linq;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString = "Привет1, это очень интересный проект. Если хочешь узнать2, что там проста запусти проект";
            int quantityLettersWord = 6;

            Console.WriteLine($"Исходная строка: {testString}");

            Console.WriteLine($"\nСлова в которых букв меньше либо равно {quantityLettersWord}:\n{DeleteLongWOrd(testString, quantityLettersWord)}");

            Console.WriteLine($"\nСлова которые содержат числа:\n{ReturnWordWithNumber(testString)}");
        }

        static private string DeleteLongWOrd(string text, int quantityLettersWord)
        {
            char[] div = { ' ', ',', '.', ':', '!', '?', ';', ';', '-' };
            List<string> words = text.Split(div, StringSplitOptions.RemoveEmptyEntries).ToList();

            for (int i = 0; i < words.Count; i++)
            {
                if(words[i].Length > quantityLettersWord)
                {
                    words.RemoveAt(i);
                    i--;
                }
            }

            return string.Join(" | ", words);
        }

        static private string ReturnWordWithNumber(string text)
        {
            char[] div = { ' ', ',', '.', ':', '!', '?', ';', ';', '-' };
            List<string> words = text.Split(div, StringSplitOptions.RemoveEmptyEntries).ToList();

            for (int i = 0; i < words.Count; i++)
            {
                if (!IsWordWithNumber(words[i]))
                {
                    words.RemoveAt(i);
                    i--;
                }
            }

            return string.Join(" | ", words);
        }

        static private bool IsWordWithNumber(string word)
        {
            foreach (var letter in word)
            {
                if (char.IsDigit(letter))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
