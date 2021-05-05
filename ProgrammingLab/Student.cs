using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgrammingLab
{
    public struct Student
    {
        public string Surname { get; set; }
        public string Faculty { get; set; }
        public int Course { get; set; }
        public string Group { get; set; }
        public List<int> Evaluations { get; set; }

        public Student(string surname, string faculty, int course, string group, params int[] evaluations)
        {
            Surname = surname;
            Faculty = faculty;
            Course = course;
            Group = group;
            Evaluations = evaluations.ToList();
        }

        public override string ToString()
        {
            return $"{Surname,-10} \t {Faculty,-10} \t { Course,-10} " +
                $"\t { Group,-10} \t { Evaluations.GetEvaluationsString(),-10}";
        }
    }

}
