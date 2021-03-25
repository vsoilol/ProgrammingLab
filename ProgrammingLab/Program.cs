using System;

namespace ProgrammingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Clothes clothesWithoutParameters = new Clothes();
            Clothes clothesWithParameters = new Clothes("Кожа", 20, 10);

            Console.WriteLine("Одежа с конструктором без параметров:");
            Console.WriteLine($"Данные - {clothesWithoutParameters.OutputInformation()}");
            Console.WriteLine($"Расход ткани - {clothesWithoutParameters.FabricConsumption()}");


            Console.WriteLine("\nОдежа с конструктором с параметрами:");
            Console.WriteLine($"Данные - {clothesWithParameters.OutputInformation()}");
            Console.WriteLine($"Расход ткани - {clothesWithParameters.FabricConsumption()}");

            Console.Write("\nВведите ширину ткани: ");
            clothesWithParameters.Width = int.Parse(Console.ReadLine());

            Console.Write("Введите норму расхода ткани: ");
            clothesWithParameters.FabricNorm = int.Parse(Console.ReadLine());

            Console.WriteLine($"Полученный расход ткани - {clothesWithParameters.FabricConsumption()}");
        }
    }
}
