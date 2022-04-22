namespace Sorting
{
    public static class MergeSort
    {
        public static void Sort(int[] numbers)
        {
            int size = numbers.Length;

            // if the size is > 1
            if (size > 1)
            {
                // split the array along the center by creating 2 arrays (non-stable)
                Split(numbers, size, out int[] left, out int[] right);

                // Recursively MergeSort the individuals
                Sort(left);
                Sort(right);

                // Combine the left and right in the correct order
                Merge(numbers, size, left, right);
            }
        }

        private static void Merge(int[] numbers, int size, int[] left, int[] right)
        {
            int leftIndex = 0;
            int rightIndex = 0;
            for (int i = 0; i < size; i++)
            {
                if (leftIndex < left.Length && (rightIndex == right.Length || left[leftIndex] < right[rightIndex]))
                {
                    numbers[i] = left[leftIndex];
                    leftIndex++;
                }
                else
                {
                    numbers[i] = right[rightIndex];
                    rightIndex++;
                }
            }
        }

        private static void Split(int[] numbers, int size, out int[] left, out int[] right)
        {
            // find the center
            var center = size / 2;

            // if size = 10, center = 5, size - center = 5
            // if size = 9, center = 4, size - center = 5
            left = new int[center];
            right = new int[size - center];
            for (int i = 0; i < size; i++)
            {
                if (i < center)
                    left[i] = numbers[i];
                else
                    right[i - center] = numbers[i];
            }
        }
    }
}
