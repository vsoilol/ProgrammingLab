using System;

namespace Task1
{
    class Program
    {
        const char Colon = ':';

        static void Main(string[] args)
        {
            string testString = "Hello:ufhy7ergferf:eryfgeryuifn:Bye";

            Console.WriteLine($"Исходная строка {testString}");

            Console.WriteLine($"Строка до первого двоеточия: {TakeBeforeColon(testString)}");

            Console.WriteLine($"Строка после последнего двоеточия: {TakeAfterColon(testString)}");
        }

        static private string TakeBeforeColon(string text)
        {
            int firstIndexColon = text.IndexOf(Colon);

            return text.Substring(0, firstIndexColon);
        }

        static private string TakeAfterColon(string text)
        {
            int lastIndexColon = text.LastIndexOf(Colon);

            return text.Remove(0, lastIndexColon + 1);
        }
    }
}
