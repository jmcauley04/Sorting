namespace Sorting
{
    public static class QuickSort
    {
        public static void Sort<T>(T[] items, int low, int high)
            where T : IComparable<T>
        {
            // if the low < high
            if (low < high)
            {
                // select the last element (pivot)
                var pivotIndex = Partition(items, low, high);

                // run quicksort on the left and right sides of the pointer
                if (pivotIndex > 1)
                    Sort(items, low, pivotIndex - 1);

                if (pivotIndex + 1 < high)
                    Sort(items, pivotIndex + 1, high);
            }
        }

        static public int Partition<T>(T[] items, int low, int high)
            where T : IComparable<T>
        {
            var pivot = items[high];
            var pivotIndex = high;
            high--;

            while (low < high)
            {
                // move from the left until a value that is greater than the pivot is found
                while (pivot.CompareTo(items[low]) > 0)
                    low++;

                // move from the right until a value that is less than the pivot is found
                while (pivot.CompareTo(items[high]) < 0)
                    high--;

                // if found, swap elements and repeat
                if (low < high)
                    Swap(items, low, high);
            }

            // if pivot is less than the left pointers number, swap pivot with left pointer
            if (pivot.CompareTo(items[low]) < 0)
                Swap(items, pivotIndex, low);

            return low;
        }

        public static void Swap<T>(T[] items, int indexA, int indexB)
            => (items[indexB], items[indexA]) = (items[indexA], items[indexB]);
    }
}