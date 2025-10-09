using BinarySearch.Problems;

namespace BinarySearch.TwoDArrays;

public class RowWithMaximumNumberOf1s
{
    public static void Run()
    {
        int[,] a =
        {
            { 0, 0, 1, 1, 1},
            { 0, 0, 0, 0, 0 },
            { 0, 1, 1, 1, 1 },
            { 0, 0, 0, 0, 0 },
            { 0, 1, 1, 1, 1 },

        };
        List<List<int>> matrix = new List<List<int>> {
            new List<int> { 0, 1, 1 },
            new List<int> { 1, 1, 1 },
            new List<int> { 0, 0, 0 }
        };
        // // Console.WriteLine(Brute(a)); // O(N * M)
        // // Console.WriteLine(Optimal(a)); // O(N * log m)
        Console.WriteLine(OptimalUsingLowerBound(matrix));
    }
    private static int Brute(int[,] a)
    {
        int n = a.GetLength(0);
        int m = a.GetLength(1);
        int res = 0;
        int resIndex = -1;
        for (int i = 0; i < n; i++)
        {
            int count = 0;
            for (int j = 0; j < m; j++)
            {
                if (a[i, j] == 1)
                {
                    count++;
                }
            }
            if (res < count)
            {
                res = count;
                resIndex = i;
            }
        }
        return resIndex;
    }
    private static int BruteTwo(int[,] a)
    {
        int n = a.GetLength(0);
        int m = a.GetLength(1);
        int maxSum = 0;
        int index = -1;
        for (int i = 0; i < n; i++)
        {
            int sum = 0;
            for (int j = 0; j < m; j++)
            {
                sum += a[i, j];
            }
            if (sum > maxSum)
            {
                maxSum = sum;
                index = i;
            }
        }
        return index;
    }
    private static int Optimal(int[,] a)
    {
        int n = a.GetLength(0);
        int m = a.GetLength(1);

        int ans = -1;
        int minIndex = int.MaxValue;

        for (int i = 0; i < n; i++)
        {
            int low = 0;
            int high = m - 1;
            int index = int.MaxValue;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (a[i, mid] == 1)
                {
                    index = Math.Min(index, mid);
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            if (minIndex > index)
            {
                minIndex = index;
                ans = i;
            }
        }
        return ans;
    }
    private static int OptimalUsingLowerBound(List<List<int>> a)
    {
        int n = a.Count;
        int m = a[0].Count;
        int cntMax = 0;
        int index = -1;
        for (int i = 0; i < n; i++)
        {
            int countOnes = m - LowerBound(a[i], 1);
            if (countOnes > cntMax)
            {
                cntMax = countOnes;
                index = i;
            }
        }
        return index;
    }
    private static int LowerBound(List<int> a, int x)
    {
        int low = 0;
        int high = a.Count - 1;
        int ans = a.Count;
        while (low <= high)
        {
            int mid = (low + high) / 2;
            if (a[mid] >= x)
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
