namespace BinarySearch.TwoDArrays;

public class SearchInSortedMatrix
{
    public static void Run()
    {
        int[,] a = {
            {1, 2, 3, 4},
            {5, 6, 7, 8},
            {9, 10, 11, 12}
        };

        List<List<int>> matrix = new()
        {
            new() {1, 2, 3, 4},
            new() {5, 6, 7, 8},
            new() {9, 10, 11, 12}
        };
        int n = a.GetLength(0);
        int m = a.GetLength(1);
        Console.WriteLine(Naive(a, n, m, 8));
        Console.WriteLine(Medium(matrix, n, m, 8));
        Console.WriteLine(Optimal(a, n, m, 8));
    }
    private static bool Naive(int[,] a, int n, int m, int target)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (a[i, j] == target)
                {
                    return true;
                }
            }
        }
        return false;
    }
    private static bool Medium(List<List<int>> a, int n, int m, int target)
    {
        for (int i = 0; i < n; i++)
        {
            if (target >= a[i][0] && target <= a[i][m - 1])
            {
                if (SearchElement(a[i], target))
                {
                    return true;
                }
            }

        }
        return false;
    }
    private static bool SearchElement(List<int> a, int target)
    {
        int low = 0;
        int high = a.Count - 1;
        while (low <= high)
        {
            int mid = (low + high) / 2;
            if (a[mid] == target) return true;
            else if (a[mid] < target)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }
        return false;
    }
    private static bool Optimal(int[,] a, int n, int m, int target)
    {
        int low = 0;
        int high = n * m - 1;
        while (low <= high)
        {
            int mid = (low + high) / 2;
            int row = mid / m;
            int col = mid % m;
            int val = a[row, col];
            if (val == target)
            {
                return true;
            }
            else if (val < target)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }
        return false;
    }
}