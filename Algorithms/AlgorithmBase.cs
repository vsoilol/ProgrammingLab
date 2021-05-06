using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Algorithms
{
    public class AlgorithmBase<T> where T : IComparable
    {
        public List<T> Items { get; set; } = new List<T>(); // Элементы сортировки

        /// <summary>
        /// Поменять элементы местами
        /// </summary>
        /// <param name="positionA"></param>
        /// <param name="positionB"></param>
        protected void Swap(int firstPosition, int secondPosition)
        {
            if (firstPosition < Items.Count && secondPosition < Items.Count)
            {
                var temp = Items[firstPosition];
                Items[firstPosition] = Items[secondPosition];
                Items[secondPosition] = temp;
            }
        }

        protected virtual void MakeSort()
        {
            Items.Sort();
        }

        public TimeSpan Sort(IEnumerable<T> items)
        {
            Items = items.ToList();
            var timer = new Stopwatch();

            timer.Start();
            MakeSort();
            timer.Stop();

            return timer.Elapsed;
        }
    }
}
