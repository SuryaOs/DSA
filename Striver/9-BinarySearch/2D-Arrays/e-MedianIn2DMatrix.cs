namespace BinarySearch.TwoDArrays;

public class MedianInTwoDMatrix
{
    public static void Run()
    {
        int[][] a = {
            new[] {1, 2, 3},
            new[] {2,4,4},
            new[] {6,7, 8}
        };
        int n = a.Length;
        int m = a[0].Length;
        Console.WriteLine(Optimal(a, n, m));
    }
    private static int Optimal(int[][] a, int n, int m)
    {
        int high = -1, low = int.MaxValue;
        for (int i = 0; i < n; i++)
        {
            high = Math.Max(high, a[i][m - 1]);
            low = Math.Min(low, a[i][0]);
        }
        int target = (n * m) / 2;
        while (low <= high)
        {
            int mid = (low + high) / 2;
            int lesserEqual = countLesserEqual(a, n, mid);
            if (lesserEqual <= target)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }
        return low;
    }
    private static int countLesserEqual(int[][] a, int n, int x)
    {
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            count += UpperBound(a[i], x);
        }
        return count;
    }
    private static int UpperBound(int[] a, int target)
    {
        int ans = a.Length;
        int low = 0;
        int high = a.Length - 1;
        while (low <= high)
        {
            int mid = (low + high) / 2;
            if (a[mid] > target)
            {
                ans = mid;
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }
        return ans;
    }
}