namespace BinarySearch.Problems;

public class SmallestDivisorThreshold
{
    public static void Run()
    {
        int[] a = { 8, 4, 2, 3 };
        int threshold = 10;
        Console.WriteLine(Naive(a, threshold)); // TC => O(max(a) * n)
        Console.WriteLine(Optimal(a, threshold)); // TC => O(log max(a) * n)
    }
    private static int Naive(int[] a, int x)
    {
        if (a.Length > x) return -1;
        int n = FindMax(a);
        for (int i = 1; i <= n; i++)
        {
            var sum = FindSumForDivisor(a, i, x);
            if (sum <= x)
            {
                return i;
            }
        }
        return -1;
    }
    private static int Optimal(int[] a, int x)
    {
        if (a.Length > x) return -1; // optional
        int low = 1;
        int high = FindMax(a);
        int ans = -1;
        while (low <= high)
        {
            int mid = (low + high) / 2;
            var sum = FindSumForDivisor(a, mid, x);
            if (sum <= x)
            {
                ans = mid;
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }
        return ans; // can return low, coz it ends up in first possible value and high ends up in first non-possible value
    }
    private static double FindSumForDivisor(int[] a, int i, int x)
    {
        double sum = 0;
        for (int j = 0; j < a.Length; j++)
        {
            sum += Math.Ceiling((double)a[j] / i);
        }
        return sum;
    }
    private static int FindMax(int[] a)
    {
        int max = -1;
        for (int i = 0; i < a.Length; i++)
        {
            max = Math.Max(a[i], max);
        }
        return max;
    }
}