using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class SelectionSort<T> : AlgorithmBase<T> where T : IComparable
    {
        protected override void MakeSort()
        {
            var minIndex = 0;

            for (int i = 0; i < Items.Count - 1; i++)
            {
                minIndex = i;

                for (int j = i + 1; j < Items.Count; j++)
                {
                    if (Items[j].CompareTo(Items[minIndex]) == -1)
                    {
                        minIndex = j;
                    }
                }

                if (i != minIndex)
                {
                    Swap(i, minIndex);
                }
            }
        }
    }
}
