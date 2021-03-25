using System;

namespace ProgrammingLab
{

    public class Program
    {
        public static void Main(string[] args)
        {
            int triangleBase;//Основание треугольника
            int sideBit;//Боковая сторона треугольника

            while (true)//Бесконечный цикл
            {
                try//Обработка исключений
                {
                    Console.Write("Введите основание треугольника равнобедренного треугольника: ");
                    triangleBase = int.Parse(Console.ReadLine());//Приводит значение которое ввел пользователь в int

                    if (triangleBase < 0)//Если длина основания меньше нуля
                        throw new LessThenZeroException("Меньше нуля!");//Генерация исключения LessThenZero

                    Console.Write("Введите боковую сторону равнобедренного треугольника: ");
                    sideBit = int.Parse(Console.ReadLine());//Приводит значение которое ввел пользователь в int

                    if (sideBit < 0)//Если боковая сторона меньше нуля
                        throw new LessThenZeroException("Меньше нуля!");//Генерация исключения LessThenZero

                    if (!CheckTriangle(triangleBase, sideBit))//Если метод CheckTriangle вернет false
                        throw new NoTriangleException("Не треугольник!");//Генерация исключения NoTriangleException
                    break;//Выход из бесконечного цикла
                }
                catch (FormatException)//Если была ошибка FormatException
                {
                    Console.WriteLine("Вы введи не число!");
                    ContinueWork();
                }
                catch (NoTriangleException ex)//Если была ошибка NoTriangleException
                {
                    Console.WriteLine(ex.Message);
                    ContinueWork();
                }
                catch (LessThenZeroException ex)//Если была ошибка LessThenZeroException
                {
                    Console.WriteLine(ex.Message);
                    ContinueWork();
                }
            }

            double area;
            int perimetr;
            AreaAndPerimetrTriangle(out area, out perimetr, triangleBase, sideBit);//Вызывается метод
            Console.WriteLine($"Площадь: {area}\nПериметр: {perimetr}");//Выводит на консоль ПЛощадь и Периметр
        }

        /// <summary>
        /// Метод для нового ввода значений треугольник
        /// </summary>
        public static void ContinueWork()
        {
            Console.WriteLine("Нажмите кнопку чтобы продолжить");
            Console.ReadKey();//Ждет пока пользователь нажмет на любую кнопку
            Console.Clear();//Очищает консоль
        }

        /// <summary>
        /// Метод который считает площадь равнобедренного треугольника
        /// </summary>
        /// <param name="triangleBase">Основание треугольника</param>
        /// <param name="sideBit">Боковая сторона треугольника</param>
        /// <returns>Возвращает площадь</returns>
        public static double TriangleArea(int triangleBase, int sideBit)
        {
            double height = Math.Sqrt(Math.Pow(sideBit, 2) - Math.Pow(triangleBase / 2, 2));
            double area = (triangleBase * height) / 2;
            return area;
        }


        /// <summary>
        /// Метод который считает площадь равнобедренного треугольника
        /// </summary>
        /// <param name="triangleBase">Основание треугольника</param>
        /// <param name="sideBit">Боковая сторона треугольника</param>
        /// <returns>Возвращает периметр треугольника</returns>
        public static int TrianglePerimeter(int triangleBase, int sideBit) => (triangleBase + 2 * sideBit);

        /// <summary>
        /// Метод который вычисляет площадь и периметр треугольника
        /// </summary>
        /// <param name="area">Площадь треугольника</param>
        /// <param name="perimetr">Периметр треугольника</param>
        /// <param name="triangleBase">Основание треугольника</param>
        /// <param name="sideBit">Боковая сторона треугольника</</param>
        public static void AreaAndPerimetrTriangle(out double area, out int perimetr, int triangleBase, int sideBit)
        {
            area = TriangleArea(triangleBase, sideBit);
            perimetr = TrianglePerimeter(triangleBase, sideBit);
        }

        /// <summary>
        /// Метод который проверяет что существует треугольник
        /// </summary>
        /// <param name="triangleBase">Основание треугольника</param>
        /// <param name="sideBit">Боковая сторона треугольника</param>
        /// <returns>Если существует треугольник вернет true, иначе false</returns>
        public static bool CheckTriangle(int triangleBase, int sideBit)
        {
            return (triangleBase + sideBit > triangleBase && sideBit * 2 > triangleBase);
        }
    }

    public class NoTriangleException : Exception//Исключение которое срабатывает если треугольник не существует 
    {
        public NoTriangleException(string message) : base(message)//Объявляю конструктор класса который наследуется от базового и принимает строку Message
        {

        }
    }

    public class LessThenZeroException : Exception//Исключение если значение меньше нуля
    {
        public LessThenZeroException(string message) : base(message)//Объявляю конструктор класса который наследуется от базового и принимает строку Message
        {

        }
    }
}
