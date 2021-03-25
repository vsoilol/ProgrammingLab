using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ProgrammingLab
{
    public struct Film
    {
        public string Name { get; }
        public DateTime FilmStart { get; }
        public TimeSpan Duration { get; }
        public string Genre { get; }
        public decimal Budget { get; }

        public Film(string name, DateTime filmStart, TimeSpan duration, string genre, decimal budget)
        {
            Name = name;
            FilmStart = filmStart;
            Duration = duration;
            Genre = genre;
            Budget = budget;
        }

        public override string ToString()
        {
            NumberFormatInfo nfi = new CultureInfo("en-US").NumberFormat;
            return $"Название - {Name}, Начало - {FilmStart}, Продолжительность - {Duration.ToString()}, Жанр - {Genre}, Бюджет - {Budget.ToString("c", nfi)}";
        }
    }
}
