using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgrammingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            Dictionary<string, IEnumerable<int>> dictionary = new Dictionary<string, IEnumerable<int>>();
            
            students.Add(new Student("Иванов", "Faculty1", 1, "Group-1"));
            students.Add(new Student("Петров", "Faculty2", 2, "Group-2"));
            students.Add(new Student("Шухов", "Faculty3", 3, "Group-3"));
            students.Add(new Student("Сергеев", "Faculty4", 4, "Group-4"));
            students.Add(new Student("Борисов", "Faculty5", 5, "Group-5"));

            Console.WriteLine($"\nВыводим содержимое списка:");

            foreach (Student student in students)
            {
                student.Evaluations.AddRange(CreateEvaluations());

                Console.WriteLine(student);

                if (student.Evaluations.Contains(2))
                {
                    dictionary.Add(student.Surname, student.Evaluations);
                }
            }

            Console.WriteLine($"\nВыводим содержимое словаря:");

            foreach (KeyValuePair<string, IEnumerable<int>> keyValue in dictionary)
            {
                Console.WriteLine($"{keyValue.Key,-10} - {keyValue.Value.GetEvaluationsString(),-10}");
            }
        }

        public static IEnumerable<int> CreateEvaluations(int numberEvaluation = 5)
        {
            Random random = new Random();

            int[] evaluations = new int[numberEvaluation];
            for (int i = 0; i < numberEvaluation; i++)
            {
                evaluations[i] = random.Next(1, 6);
            }
            return evaluations;
        }
    }
}
