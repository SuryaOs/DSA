namespace BinarySearch.Problems;

public class MinDaysToMakeMBoquets
{
    public static void Run()
    {
        int[] arr = { 10, 10 };
        int m = 1;
        int k = 1;
        Console.WriteLine(Naive(arr, m, k)); // O(N*M) where m => range of min-max
        Console.WriteLine(Optimal(arr, m, k)); // O(N* logM) where m => range of min-max
        Console.WriteLine(OptimalClean(arr, m, k));
    }
    private static int Naive(int[] arr, int tempM, int tempK)
    {
        int ans = -1;
        if (arr.Length < (tempM * tempK)) return ans;
        int low = FindMin(arr); // O(N)
        int high = FindMax(arr); // O(N)

        for (int i = low; i <= high; i++) // O(M)
        {
            int k = tempK;
            int m = tempM;
            for (int j = 0; j < arr.Length; j++) // O(N)
            {
                bool isBloomed = arr[j] <= i;
                if (isBloomed)
                {
                    k--; // if rose is bloomed, add 1 to the boquet
                }
                else
                {
                    k = tempK; // if adjacent rose is not bloomed, reset the boquet
                }
                if (k == 0) // if reqd. rose to form a boquet is bloomed, then make 1 boquet as ready by decreasing total boquets and reset the bloomed rose to 0
                {
                    m--;
                    k = tempK;
                }
                if (m == 0) // if all the boquets are ready, return total number of hours taken
                {
                    ans = i;
                    break;
                }
            }
            if (m == 0) // if all the boquets are ready, return total number of hours taken
            {
                ans = i;
                break;
            }
        }
        return ans;
    }
    // This works fine and all test case passes
    private static int Optimal(int[] arr, int m, int k)
    {
        int ans = int.MaxValue;
        if (arr.Length <= (m * k))
        {
            return -1;
        }
        int low = FindMin(arr);
        int high = FindMax(arr);

        while (low <= high)
        {
            int mid = (low + high) / 2;
            int tempK = k;
            int tempM = m;
            for (int i = 0; i < arr.Length; i++)
            {
                bool isBloomed = arr[i] <= mid;
                tempK = isBloomed ? tempK - 1 : k;
                if (tempK == 0)
                {
                    tempM--;
                    tempK = k;
                }
                if (tempM == 0)
                {
                    break;
                }
            }
            if (tempM == 0)
            {
                ans = Math.Min(ans, mid);
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }

        }
        return ans == int.MaxValue ? -1 : ans;
    }

    private static int OptimalClean(int[] bloomDay, int m, int k)
    {
        if (bloomDay.Length <= (m * k)) return -1;
        int low = FindMin(bloomDay);
        int high = FindMax(bloomDay);
        int minDays = -1;
        while (low <= high)
        {
            int mid = (low + high) / 2;
            if (GetNumberOfBoquets(bloomDay, mid, k) >= m)
            {
                minDays = mid;
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }
        return minDays;
    }
    private static int GetNumberOfBoquets(int[] bloomDay, int mid, int k)
    {
        int count = 0;
        int numberOfBoquets = 0;
        for (int i = 0; i < bloomDay.Length; i++)
        {
            if (bloomDay[i] <= mid)
            {
                count++;
            }
            else
            {
                count = 0;
            }
            if (count == k)
            {
                numberOfBoquets++;
                count = 0;
            }
        }
        return numberOfBoquets;
    }
    private static int FindMin(int[] arr)
    {
        int ans = int.MaxValue;
        for (int i = 0; i < arr.Length; i++)
        {
            ans = Math.Min(ans, arr[i]);
        }
        return ans;
    }
    private static int FindMax(int[] arr)
    {
        int ans = int.MinValue;
        for (int i = 0; i < arr.Length; i++)
        {
            ans = Math.Max(ans, arr[i]);
        }
        return ans;
    }
}