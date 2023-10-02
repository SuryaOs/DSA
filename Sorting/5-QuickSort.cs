namespace dsaproblem.Sorting
{
    public class QuickSorting
    {
        public static void QuickSort(int[] a, int l, int h)
        {
            Qs(a, l, h);
            // Print the sorted array
            Console.WriteLine(string.Join(", ", a));
        }
        private static void Qs(int[] a, int l, int h)
        {
            if (l < h)
            {
                int p = a[l]; // Pivot element
                int i = l;
                int j = h;
                int part;

                while (i < j)
                {
                    while (i <= h - 1 && a[i] <= p) // Find an element greater than the pivot
                    {
                        i++;
                    }
                    while (j >= l + 1 && a[j] > p) // Find an element less than or equal to the pivot
                    {
                        j--;
                    }
                    if (i < j)
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }

                int t = a[j]; // Swap pivot into its correct position
                a[j] = a[l];
                a[l] = t;

                part = j;

                Qs(a, l, part - 1); // Recursively sort the left sub-array
                Qs(a, part + 1, h); // Recursively sort the right sub-array
            }

        }
    }
}
