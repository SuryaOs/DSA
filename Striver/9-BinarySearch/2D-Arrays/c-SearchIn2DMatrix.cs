namespace BinarySearch.TwoDArrays;

public class SearchInTwoDMatrix
{
    public static void Run()
    {
        int[,] a = {
            {1, 4, 7, 11, 15},
            {2, 5, 8, 12, 19},
            {3, 6, 9, 16, 22},
            {10, 13, 14, 17, 24},
            {18, 21, 23, 26, 30}
        };
        int n = a.GetLength(0);
        int m = a.GetLength(1);
        Console.WriteLine(string.Join(",", Optimal(a, n, m, 30)));
    }
    private static int[] Optimal(int[,] a, int n, int m, int target)
    {
        int low = 0;
        int high = m - 1;
        int[] res = new int[2];
        while (low < n && high > 0)
        {
            if (a[low, high] == target) return new[] { low, high };
            else if (a[low, high] > target) high--;
            else low++;
        }
        return res;
    }
}