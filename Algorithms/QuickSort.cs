using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class QuickSort<T> : AlgorithmBase<T> where T : IComparable
    {
        protected override void MakeSort()
        {
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
    }
}
