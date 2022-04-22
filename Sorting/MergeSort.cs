namespace Sorting
{
    public static class MergeSort
    {
        public static void Sort<T>(T[] items)
            where T : IComparable<T>
        {
            int size = items.Length;

            // if the size is > 1
            if (size > 1)
            {
                // split the array along the center by creating 2 arrays (non-stable)
                Split(items, size, out T[] left, out T[] right);

                // Recursively MergeSort the individuals
                Sort(left);
                Sort(right);

                // Combine the left and right in the correct order
                Merge(items, size, left, right);
            }
        }

        private static void Merge<T>(T[] items, int size, T[] left, T[] right)
            where T : IComparable<T>
        {
            int leftIndex = 0;
            int rightIndex = 0;
            for (int i = 0; i < size; i++)
            {
                if (leftIndex < left.Length && (rightIndex == right.Length || left[leftIndex].CompareTo(right[rightIndex]) < 0))
                {
                    items[i] = left[leftIndex];
                    leftIndex++;
                }
                else
                {
                    items[i] = right[rightIndex];
                    rightIndex++;
                }
            }
        }

        private static void Split<T>(T[] items, int size, out T[] left, out T[] right)
        {
            // find the center
            var center = size / 2;

            // if size = 10, center = 5, size - center = 5
            // if size = 9, center = 4, size - center = 5
            left = new T[center];
            right = new T[size - center];
            for (int i = 0; i < size; i++)
            {
                if (i < center)
                    left[i] = items[i];
                else
                    right[i - center] = items[i];
            }
        }
    }
}
