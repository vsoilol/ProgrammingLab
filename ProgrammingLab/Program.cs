using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgrammingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Random budget = new Random();

            TimeSpan sortDate = new TimeSpan(18, 0, 0);
            TimeSpan sortDuration = new TimeSpan(1, 40, 0);

            DateTime dateTime = new DateTime(2021, 1, 1, 18, 40, 0);

            if (sortDate > dateTime.TimeOfDay)
            {
                Console.WriteLine(dateTime.TimeOfDay);
            }

            List<Film> films = new List<Film>()
            {
                new Film("Film1", new DateTime(2021, 1, 1, 15, 0, 0), new TimeSpan(1, 20, 0), "Сказка", budget.Next(300, 5000)),
                new Film("Film2", new DateTime(2021, 2, 2, 19, 0, 0), new TimeSpan(1, 50, 0), "Боевик", budget.Next(300, 5000)),
                new Film("Film3", new DateTime(2021, 3, 3, 12, 0, 0), new TimeSpan(1, 20, 0), "Вестерн", budget.Next(300, 5000)),
                new Film("Film4", new DateTime(2021, 4, 4, 20, 0, 0), new TimeSpan(1, 20, 0), "Детектив", budget.Next(300, 5000)),
                new Film("Film5", new DateTime(2021, 5, 5, 22, 0, 0), new TimeSpan(2, 0, 0), "Драма", budget.Next(300, 5000)),
                new Film("Film6", new DateTime(2021, 6, 6, 15, 0, 0), new TimeSpan(1, 10, 0), "Комедия", budget.Next(300, 5000)),
                new Film("Film7", new DateTime(2021, 7, 7, 9, 0, 0), new TimeSpan(1, 0, 0), "Мелодрама", budget.Next(300, 5000)),
                new Film("Film8", new DateTime(2021, 8, 8, 11, 0, 0), new TimeSpan(2, 0, 0), "Трагедия", budget.Next(300, 5000)),
                new Film("Film9", new DateTime(2021, 9, 9, 23, 0, 0), new TimeSpan(1, 40, 0), "Хоррор", budget.Next(300, 5000)),
                new Film("Film10", new DateTime(2021, 10, 10, 13, 0, 0), new TimeSpan(1, 20, 0), "Триллер", budget.Next(300, 5000))
            };

            var selection = films.Where(film => (film.FilmStart.TimeOfDay >= sortDate && film.Duration >= sortDuration));

            foreach (var item in selection)
            {
                Console.WriteLine(item);
            }

        }
    }
}
