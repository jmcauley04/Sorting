namespace Sorting
{
    public static class QuickSort
    {
        public static void Sort(int[] numbers, int low, int high)
        {
            // if the low < high
            if (low < high)
            {
                // select the last element (pivot)
                var pivotIndex = Partition(numbers, low, high);

                // run quicksort on the left and right sides of the pointer
                if (pivotIndex > 1)
                    Sort(numbers, low, pivotIndex - 1);

                if (pivotIndex + 1 < high)
                    Sort(numbers, pivotIndex + 1, high);
            }
        }

        static public int Partition(int[] numbers, int low, int high)
        {
            var pivot = numbers[high];
            var pivotIndex = high;
            high--;

            while (low < high)
            {
                // move from the left until a value that is greater than the pivot is found
                while (numbers[low] < pivot)
                    low++;

                // move from the right until a value that is less than the pivot is found
                while (numbers[high] > pivot)
                    high--;

                // if found, swap elements and repeat
                if (low < high)
                    Swap(numbers, low, high);
            }

            // if pivot is less than the left pointers number, swap pivot with left pointer
            if (pivot < numbers[low])
                Swap(numbers, pivotIndex, low);

            return low;
        }

        public static void Swap(int[] numbers, int indexA, int indexB)
            => (numbers[indexB], numbers[indexA]) = (numbers[indexA], numbers[indexB]);
    }
}