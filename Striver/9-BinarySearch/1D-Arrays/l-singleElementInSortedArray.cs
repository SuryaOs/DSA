namespace BinarySearch.OneDArrays;

public class SingleElementInSortedArray
{
    public static void Run()
    {
        int[] a = { 1, 1, 2, 2, 3, 3, 4, 4, 5, 6, 6 };
        // Console.WriteLine(Brute(a));
        Console.WriteLine(NaiveRefactor(a));
    }
    private static int Brute(int[] a)
    {
        int xor = a[0];
        for (int i = 1; i < a.Length; i++)
        {
            xor ^= a[i];
        }
        return xor;
    }

    // solved on first attempt with try and error
    private static int Naive(int[] a)
    {
        int low = 0;
        int high = a.Length - 1;
        while (low <= high)
        {
            int mid = (low + high) / 2;
            if (mid == 0 || mid == a.Length - 1 || (a[mid] != a[mid - 1] && a[mid] != a[mid + 1])) return a[mid];
            if (mid % 2 == 1)
            {
                if (a[mid] == a[mid - 1])
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            else
            {
                if (a[mid] == a[mid - 1])
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
        }
        return -1;
    }
    private static int NaiveRefactor(int[] a)
    {
        int n = a.Length;
        if (n == 1) return a[0];
        if (a[0] != a[1]) return a[0];
        if (a[n - 1] != a[n - 2]) return a[n - 1];

        int low = 0;
        int high = a.Length - 1;
        while (low <= high)
        {
            int mid = (low + high) / 2;
            if (a[mid] != a[mid - 1] && a[mid] != a[mid + 1]) return a[mid];
            if ((mid % 2 == 1 && a[mid] == a[mid - 1])
            || (mid % 2 == 0 && a[mid] != a[mid - 1]))
            {
                low = mid + 1; // right half
            }
            else
            {
                high = mid - 1; // left half
            }
        }
        return -1;
    }
}