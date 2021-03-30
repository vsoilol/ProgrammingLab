using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProgrammingLab
{
    class Program
    {
        const string formatFile = ".txt";
        const string binFormatFile = ".bin";

        static void Main(string[] args)
        {
            string fileName = "";
            int initialRange, endRange;
            double step;

            Console.Write("Введите имя файла: ");
            fileName = Console.ReadLine();

            string fullFileName = fileName + formatFile;

            Console.Write("Введите начальный диапазон: ");
            initialRange = int.Parse(Console.ReadLine());

            Console.Write("Введите конечный диапазон: ");
            endRange = int.Parse(Console.ReadLine());

            Console.Write("Введите шаг: ");
            step = double.Parse(Console.ReadLine());

            WriteResultFunctionInFile(fullFileName, initialRange, endRange, step);

            Dictionary<double, double> results = ReadFile(fullFileName);

            double maxValue = results.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
            double max = results[maxValue];

            double minValue = results.Aggregate((x, y) => x.Value > y.Value ? y : x).Key;
            double min = results[minValue];

            double arithmeticMean = results.Values.Sum() / results.Count;


            Console.WriteLine("\nС помощью .txt");

            Console.WriteLine($"\nМаксимальное значение {max} при x равном {maxValue}\n" +
                $"Минимальное значение {min} при x равном {minValue}\n" +
                $"Среднее арифметическое: {arithmeticMean}");




            fullFileName = fileName + binFormatFile;

            BinaryWrite(fullFileName, initialRange, endRange, step);

            Dictionary<double, double> newResults = BinaryReader(fullFileName);

            Console.WriteLine("\nС помощью .bin");


            maxValue = newResults.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
            max = newResults[maxValue];

            minValue = newResults.Aggregate((x, y) => x.Value > y.Value ? y : x).Key;
            min = newResults[minValue];

            arithmeticMean = newResults.Values.Sum() / newResults.Count;

            Console.WriteLine($"\nМаксимальное значение {max} при x равном {maxValue}\n" +
                $"Минимальное значение {min} при x равном {minValue}\n" +
                $"Среднее арифметическое: {arithmeticMean}");
        }

        static private void BinaryWrite(string fileName, int initialRange, int endRange, double step)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create)))
            {
                writer.Write($"Вычислить значение функции cos(x)*x*x с шагом {step} начиная от {initialRange} и заканчивая {endRange}");

                double result = 0;

                for (double x = initialRange; x <= endRange; x += step)
                {
                    result = Math.Cos(x) * Math.Pow(x, 2);

                    writer.Write(Math.Round(x, 3));
                    writer.Write(result);
                }
            }
        }

        static private Dictionary<double, double> BinaryReader(string fileName)
        {
            Dictionary<double, double> values = new Dictionary<double, double>();

            using (BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.Open)))
            {
                string title = reader.ReadString();

                Console.WriteLine("\n" + title);

                while (reader.PeekChar() > -1)
                {
                    var key = reader.ReadDouble();
                    var value = reader.ReadDouble();

                    values.Add(key, value);
                }

            }

            return values;
        }

        static private void WriteResultFunctionInFile(string fileName, int initialRange, int endRange, double step)
        {
            using (StreamWriter writer = new StreamWriter(File.Open(fileName, FileMode.Create)))
            {
                writer.WriteLine($"Вычислить значение функции cos(x)*x*x с шагом {step} начиная от {initialRange} и заканчивая {endRange}");

                double result = 0;

                for (double x = initialRange; x <= endRange; x += step)
                {
                    result = Math.Cos(x) * Math.Pow(x, 2);

                    string note = $"{Math.Round(x, 3)}\t\t";
                    note += $"{result}";

                    writer.WriteLine(note);
                }
            }
        }

        static private Dictionary<double, double> ReadFile(string fileName)
        {
            Dictionary<double, double> values = new Dictionary<double, double>();

            using (StreamReader reader = new StreamReader(fileName))
            {
                string title = reader.ReadLine();

                Console.WriteLine("\n" + title);

                while (!reader.EndOfStream)
                {
                    var results = reader.ReadLine()
                        .Split(new char[] { ' ', '\t' },
                        StringSplitOptions.RemoveEmptyEntries);

                    values.Add(Convert.ToDouble(results[0]), Convert.ToDouble(results[1]));
                }
            }

            return values;
        }
    }
}
