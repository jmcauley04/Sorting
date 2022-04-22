using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sorting.Tests
{
    [TestClass()]
    public class QuickSortTests
    {
        [TestMethod()]
        [DataRow(
            new int[] { -4, 5, 1, 16, 2, 3 },
            new int[] { -4, 1, 2, 3, 5, 16 }
            )]
        public void QuickSortTest_1(int[] numbers, int[] expected) => QuickSortTest(numbers, expected);

        [TestMethod()]
        [DataRow(
            new int[] { 0 },
            new int[] { 0 }
            )]
        public void QuickSortTest_2(int[] numbers, int[] expected) => QuickSortTest(numbers, expected);

        [TestMethod()]
        [DataRow(
            new int[] { 4, 5, 1, 16, 2, 3 },
            new int[] { 1, 2, 3, 4, 5, 16 }
            )]
        public void QuickSortTest_3(int[] numbers, int[] expected) => QuickSortTest(numbers, expected);

        [TestMethod()]
        [DataRow(
            new int[] { 4, 5, 1, 6, 2, 3 },
            new int[] { 1, 2, 3, 4, 5, 6 }
            )]
        public void QuickSortTest_4(int[] numbers, int[] expected) => QuickSortTest(numbers, expected);

        public void QuickSortTest(int[] numbers, int[] expected)
        {
            int length = numbers.Length;
            QuickSort.Sort(numbers, 0, length - 1);

            for (int i = 0; i < expected.Length; i++)
                Assert.AreEqual(expected[i], numbers[i]);
        }


        [DataTestMethod()]
        [DataRow(new int[] { 1, 2, 3 }, 0, 2, new int[] { 3, 2, 1 })]
        [DataRow(new int[] { 1, 2, 3, 5, 6, 7 }, 5, 2, new int[] { 1, 2, 7, 5, 6, 3 })]
        [DataRow(new int[] { 1, 2, 3, 5, 6, 7 }, 2, 4, new int[] { 1, 2, 6, 5, 3, 7 })]
        [DataRow(new int[] { 1, 2, 3, 5, 6, 7 }, 2, 5, new int[] { 1, 2, 7, 5, 6, 3 })]
        public void SwapTest(int[] numbers, int indexA, int indexB, int[] expected)
        {
            QuickSort.Swap(numbers, indexA, indexB);

            for (int i = 0; i < expected.Length; i++)
                Assert.AreEqual(expected[i], numbers[i]);
        }

        [DataTestMethod()]
        [DataRow(new int[] { 4, 5, 1, 6, 2, 3 }, 0, 5, new int[] { 2, 1, 3, 6, 4, 5 })]
        public void PartitionTest_1(int[] numbers, int low, int high, int[] expected) => PartitionTest(numbers, low, high, expected);

        [DataTestMethod()]
        [DataRow(new int[] { 4, 5, 1, 6, 2, 3, 20 }, 0, 5, new int[] { 2, 1, 3, 6, 4, 5, 20 })]
        public void PartitionTest_2(int[] numbers, int low, int high, int[] expected) => PartitionTest(numbers, low, high, expected);

        public void PartitionTest(int[] numbers, int low, int high, int[] expected)
        {
            QuickSort.Partition(numbers, low, high);

            for (int i = 0; i < expected.Length; i++)
                Assert.AreEqual(expected[i], numbers[i]);
        }
    }
}