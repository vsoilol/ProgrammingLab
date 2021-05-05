using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingLab
{
    public static class Extension
    {
        public static string GetEvaluationsString(this IEnumerable<int> evaluations)
        {
            string result = "";
            foreach (var evaluation in evaluations)
            {
                result += $"\t { evaluation, -10}";
            }

            return result;
        }
    }
}
