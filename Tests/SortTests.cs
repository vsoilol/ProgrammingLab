using Algorithms;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    [TestFixture]
    public class SortTests
    {
        readonly Random random = new Random();
        readonly List<int> Items = new List<int>();
        readonly List<int> Sorted = new List<int>();

        [SetUp]
        public void Setup()
        {
            Items.Clear();
            for (int i = 0; i < 1000; i++)
            {
                Items.Add(random.Next(0, 1000));
            }

            Sorted.Clear();
            Sorted.AddRange(Items.OrderBy(x => x).ToArray());
        }

        [Test]
        public void BubbleSortTest()
        {
            // arrange
            var bubble = new BubbleSort<int>();

            // act
            bubble.Sort(Items);

            // assert
            Assert.That(Items, Is.EquivalentTo(Sorted));
        }

        [Test]
        public void CocktailSortTest()
        {
            // arrange
            var cocktail = new CocktailSort<int>();

            // act
            cocktail.Sort(Items);

            // assert
            Assert.That(Items, Is.EquivalentTo(Sorted));
        }

        [Test]
        public void InsertSortTest()
        {
            // arrange
            var insert = new InsertSort<int>();

            // act
            insert.Sort(Items);

            // assert
            Assert.That(Items, Is.EquivalentTo(Sorted));
        }

        [Test]
        public void ShellSortTest()
        {
            // arrange
            var shellSort = new ShellSort<int>();

            // act
            shellSort.Sort(Items);

            // assert
            Assert.That(Items, Is.EquivalentTo(Sorted));
        }

        [Test]
        public void SelectionSortTest()
        {
            // arrange
            var selection = new SelectionSort<int>();

            // act
            selection.Sort(Items);

            // assert
            Assert.That(Items, Is.EquivalentTo(Sorted));
        }

        [Test]
        public void QuickSortTest()
        {
            // arrange
            var quick = new QuickSort<int>();

            // act
            quick.Sort(Items);

            // assert
            Assert.That(Items, Is.EquivalentTo(Sorted));
        }
    }
}