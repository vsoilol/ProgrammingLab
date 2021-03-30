using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ProgrammingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            const string serializeFile = "Film.dat";
            Random budget = new Random();

            Film film1 = new Film("Film1", new DateTime(2021, 1, 1, 15, 0, 0), new TimeSpan(1, 20, 0), "Сказка", budget.Next(300, 5000));

            Console.WriteLine($"Начальный объект\n{film1}");

            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream(serializeFile, FileMode.Create))
            {
                formatter.Serialize(fs, film1);
            }

            Film film2;
            using (FileStream fs = new FileStream(serializeFile, FileMode.Open))
            {
                film2 = (Film)formatter.Deserialize(fs);
            }

            Console.WriteLine($"\nПосле десериализации\n{film2}");
        }
    }
}
