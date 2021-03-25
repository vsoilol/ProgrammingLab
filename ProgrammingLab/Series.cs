using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingLab
{
    public struct Series
    {
        public string Name { get; }
        public int NumberSeasons { get; }
        public string Country { get; }
        public (int one, int two, int three) Assessment { get; }

        public Series(string name, int numberSeasons, string country, (int, int, int) assessment)
        {
            Name = name;
            NumberSeasons = numberSeasons;
            Country = country;
            Assessment = assessment;
        }
        public override string ToString()
        {
            return $"Название - {Name}, Количество сезонов - {NumberSeasons}, Страна - {Country}, Оценка {Assessment}";
        }
    }
}
