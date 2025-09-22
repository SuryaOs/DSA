namespace BinarySearch.OneDArrays;

public class FindXInSortedArray
{
    public static void Run()
    {
        int[] a = { -1, 0, 3, 5, 9, 12 };
        int target = 100;
        Console.Write(Brute(a, target));
        Console.Write(Recurse(a, target, 0, a.Length - 1));
        /*
            # Binary Search: O(log₂ n) or O(log n) => base doesn't matter
            # Why? Each step cuts array size in half -> n -> n/2 -> n/4 -> ... -> 1
            # The number of steps = log base 2 of n => O(log n)
            # Overflow case - use long for mid var (int.MaxValue + int.MaxValue wpont fit in int)
        */

    }

    private static int Brute(int[] a, int target)
    {
        int low = 0;
        int high = a.Length - 1;
        while (low <= high)
        {
            int mid = (low + high) / 2;

            if (a[mid] == target)
                return mid;
            else if (a[mid] < target)
                low = mid + 1;
            else if (a[mid] > target)
                high = mid - 1;
        }
        return -1;
    }

    private static int Recurse(int[] a, int target, int low, int high)
    {
        if (low > high)
            return -1;
        int mid = (low + high) / 2;
        if (a[mid] == target)
            return mid;
        else if (a[mid] < target)
            return Recurse(a, target, mid + 1, high);

        return Recurse(a, target, low, mid - 1);
    }
}
