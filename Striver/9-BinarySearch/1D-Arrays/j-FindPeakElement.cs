namespace BinarySearch.OneDArrays;

public class FindPeakElement
{
    public static void Run()
    {
        int[] a = { 1, 5, 1, 2, 1 };
        Console.WriteLine(Brute(a)); // TC O(N)
        Console.WriteLine(Optimal(a));
    }
    private static int Brute(int[] a)
    {
        // if (a.Length == 1) return 0;
        for (int i = 0; i < a.Length; i++)
        {
            // if (a[i] > a[i - 1] && a[i] > a[i + 1])
            // {
            //     return i;
            // }
            if ((i == 0 || a[i] > a[i - 1]) && (i == a.Length - 1 || a[i] > a[i + 1]))
            {
                return i;
            }
        }
        // if (a[0] > a[1])
        // {
        //     return 0;
        // }
        // if (a[a.Length - 1] > a[a.Length - 2])
        // {
        //     return a.Length - 1;
        // }
        return -1;
    }
    private static int Optimal(int[] a)
    {
        int n = a.Length;
        if (n == 1) return 0;
        if (a[0] > a[1]) return 0;
        if (a[n - 1] > a[n - 2]) return n - 1;

        int low = 1;
        int high = n - 2;
        while (low <= high)
        {
            int mid = (low + high) / 2;
            if (a[mid - 1] < a[mid] && a[mid] > a[mid + 1]) return mid;
            if (a[mid - 1] < a[mid])
            {
                low = mid + 1;
            }
            else if (a[mid + 1] < a[mid])
            {
                high = mid - 1;
            }
            else // corner case 1 5 1 2 1
            {
                low = mid + 1;
                // or high = mid -1;
            }
        }
        return -1;
    }
}