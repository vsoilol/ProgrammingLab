using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgrammingLab
{
    public class QuickSort<T> where T : IComparable
    {
        public List<T> Items { get; set; } = new List<T>(); // Элементы сортировки

        public void Sort(IEnumerable<T> items)
        {
            Items = items.ToList();
            Qsort(0, Items.Count - 1);
        }

        private void Qsort(int left, int right)
        {
            T pivot = Items[(right - left) / 2 + left]; // берём центральный элемент

            int leftToRight = left, rightToLeft = right;

            while (leftToRight <= rightToLeft)
            {
                // Пока элемент меньше центрального и не достигли последнего, двигаемся вправо
                while (Items[leftToRight].CompareTo(pivot) < 0 && leftToRight <= right)
                {
                    leftToRight++;
                }

                // Пока элемент из правой части больше центрального и не достигли первого, двигаемся влево
                while (Items[rightToLeft].CompareTo(pivot) > 0 && rightToLeft >= left)
                {
                    rightToLeft--;
                }

                if (leftToRight <= rightToLeft)
                {
                    // Меняем элементы местами
                    Swap(leftToRight, rightToLeft);

                    leftToRight++; rightToLeft--;
                }
            }
            // Рекурсивно вызываем этот же метод для дальнейшей сортировки
            if (rightToLeft > left)
            {
                Qsort(left, rightToLeft);
            }

            if (leftToRight < right)
            {
                Qsort(leftToRight, right);
            }
        }

        private void Swap(int firstPosition, int secondPosition)
        {
            if (firstPosition < Items.Count && secondPosition < Items.Count)
            {
                var temp = Items[firstPosition];
                Items[firstPosition] = Items[secondPosition];
                Items[secondPosition] = temp;
            }
        }
    }
}
