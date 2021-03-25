using System;
using System.Collections.Generic;

namespace ProgrammingLab
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();

            int numberSeasons = 5;
            int assessment = 3;
            int year = 2003;

            List<Series> series = new List<Series>();
            int numberSeries = 5;

            var assessments = (random.Next(1, ValuesSeries.MaxAssessment + 1),
                                random.Next(1, ValuesSeries.MaxAssessment + 1),
                                random.Next(1, ValuesSeries.MaxAssessment + 1));

            for (int i = 1; i <= numberSeries; i++)
            {
                series.Add(new Series(
                    ValuesSeries.NamesSeries + i,
                    random.Next(1, ValuesSeries.MaxSeasons + 1),
                    ValuesSeries.Countries[random.Next(0, ValuesSeries.Countries.Length)],
                    assessments));
            }

            Console.WriteLine("Сериалы:\n");

            foreach (var item in series)
            {
                Console.WriteLine(item);


            }

            Console.WriteLine("\nРезультат:\n");

            foreach (var item in series)
            {
                var result = Method(item, (year, numberSeasons, assessment));

                OututTuple(result);
            }


        }

        static (string name, string country, string code, double averageAssessment, Coincidence coincidence)
            Method(Series series, (int year, int numberSeasons, int assessment) data)
        {
            string nameResult = series.Name;
            string country = series.Country;
            string code = data.year + series.Country;
            double averageAssessment = (series.Assessment.one + series.Assessment.two + series.Assessment.three + data.assessment) / 2;

            Coincidence coincidence = Coincidence.No;

            if (data.numberSeasons == series.NumberSeasons)
                coincidence = Coincidence.Yes;

            var result = (name: nameResult, country: country, code: code, averageAssessment: averageAssessment, coincidence: coincidence);
            return result;
        }

        static void OututTuple((string name, string country, string code, double averageAssessment, Coincidence coincidence) tuple)
        {
            Console.WriteLine($"Название - {tuple.name}, Страна - {tuple.country}, Код - {tuple.code}, Средняя оценка - {tuple.averageAssessment}, Да/Нет - {tuple.coincidence}");
        }
    }
}
