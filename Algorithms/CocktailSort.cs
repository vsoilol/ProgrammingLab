using System;

namespace Algorithms
{
    public class CocktailSort<T> : AlgorithmBase<T> where T : IComparable
    {
        protected override void MakeSort()
        {
            int left = 0, right = Items.Count - 1, last = right;
            do
            {
                for (int i = left; i < right; i++)
                {
                    if (Items[i].CompareTo(Items[i + 1]) == 1)
                    {
                        Swap(i, i + 1);
                        last = i;
                    }
                }

                right = last;

                for (int i = right; i > left; i--)
                {
                    if (Items[i].CompareTo(Items[i - 1]) == -1)
                    {
                        Swap(i, i - 1);
                        last = i;
                    }
                }

                left = last;
            } while (left < right);
        }
    }
}
