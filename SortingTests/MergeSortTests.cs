using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sorting.Tests
{
    [TestClass()]
    public class MergeSortTests
    {

        [TestMethod()]
        [DataRow(
            new int[] { -4, 5, 1, 16, 2, 3 },
            new int[] { -4, 1, 2, 3, 5, 16 }
            )]
        public void MergeSortTest_1(int[] numbers, int[] expected) => MergeSortTest(numbers, expected);

        [TestMethod()]
        [DataRow(
            new int[] { 0 },
            new int[] { 0 }
            )]
        public void MergeSortTest_2(int[] numbers, int[] expected) => MergeSortTest(numbers, expected);

        [TestMethod()]
        [DataRow(
            new int[] { 4, 5, 1, 16, 2, 3 },
            new int[] { 1, 2, 3, 4, 5, 16 }
            )]
        public void MergeSortTest_3(int[] numbers, int[] expected) => MergeSortTest(numbers, expected);

        [TestMethod()]
        [DataRow(
            new int[] { 4, 5, 1, 6, 2, 3 },
            new int[] { 1, 2, 3, 4, 5, 6 }
            )]
        public void MergeSortTest_4(int[] numbers, int[] expected) => MergeSortTest(numbers, expected);
        public void MergeSortTest(int[] numbers, int[] expected)
        {
            MergeSort.Sort(numbers);

            for (int i = 0; i < expected.Length; i++)
                Assert.AreEqual(expected[i], numbers[i]);
        }
    }
}