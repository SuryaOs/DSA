namespace BinarySearch.TwoDArrays;

public class FindPeakElement
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
        Console.WriteLine(string.Join(", ", Optimal(a, n, m)));
    }
    private static int[] Optimal(int[,] a, int n, int m)
    {
        int low = 0;
        int high = m - 1;
        while (low <= high)
        {
            int mid = (low + high) / 2;
            int maxRowIndex = FindMax(a, mid);
            int left = mid - 1 >= 0 ? a[maxRowIndex, mid - 1] : -1;
            int right = mid + 1 < m ? a[maxRowIndex, mid + 1] : -1;
            if (a[maxRowIndex, mid] > left && a[maxRowIndex, mid] > right)
            {
                return new int[] { maxRowIndex, mid };
            }
            else if (a[maxRowIndex, mid] < left)
            {
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }
        return new int[] { -1, -1 };
    }
    private static int FindMax(int[,] a, int col)
    {
        int max = -1;
        int res = -1;
        for (int i = 0; i < a.GetLength(0); i++)
        {
            if (max < a[i, col])
            {
                max = a[i, col];
                res = i;
            }
        }
        return res;
    }
}