using System;

namespace Algorithms
{
    public class BubbleSort<T> : AlgorithmBase<T> where T : IComparable
    {
        protected override void MakeSort()
        {
            var count = Items.Count;

            for (int j = 0; j < count; j++)
            {
                for (int i = 0; i < count - j - 1; i++)
                {
                    var firstValue = Items[i];
                    var secondValue = Items[i + 1];

                    if (firstValue.CompareTo(secondValue) == 1)
                    {
                        Swap(i, i + 1);
                    }
                }
            }
        }
    }
}
