namespace BinarySearch.Problems;

public class KthMissingPositiveNumber
{
    public static void Run()
    {
        int[] a = { 3, 4, 5 };
        int k = 3;
        Console.WriteLine(Naive(a, k));
        Console.WriteLine(Optimal(a, k));
    }
    private static int Naivest(int[] a, int k)
    {
        int min = 1;
        int max = a.Max() + k;
        int count = 0;
        for (int i = min; i <= max; i++)
        {
            bool isMissing = Missing(a, i);
            if (isMissing)
            {
                count++;
            }
            if (count == k)
            {
                return i;
            }
        }
        return -1;
    }
    public static int Naive(int[] a, int k)
    {
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] <= k)
            {
                k++;
            }
            else
            {
                break;
            }
        }
        return k;
    }
    public static int Optimal(int[] a, int k)
    {
        int low = 0;
        int high = a.Length - 1;
        while (low <= high)
        {
            int mid = (low + high) / 2;
            int missing = a[mid] - (mid + 1);
            if (missing < k)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }
        // deriving formula
        // int noOfMissingElementsBeforeHigh = a[high] - (high + 1);  => a[high] - high - 1;
        // int ans = a[high] + (k - noOfMissingElementsBeforeHigh); 
        // int ans = a[high] + k - a[high] + high + 1;
        int ans = k + low;
        return ans;
    }
    private static bool Missing(int[] a, int num)
    {
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == num)
            {
                return false;
            }
        }
        return true;
    }
}