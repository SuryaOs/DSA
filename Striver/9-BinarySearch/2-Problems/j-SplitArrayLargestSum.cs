using System.Security.AccessControl;

namespace BinarySearch.Problems;

public class SplitArrayLargestSum // AND ALSO PaintersPartition
{
    public static void Run()
    {
        int[] a = { 3, 5, 1 };
        int k = 3;
        Console.WriteLine(Naive(a, k));
        Console.WriteLine(Optimal(a, k));
    }
    private static int Naive(int[] a, int k)
    {
        int min = a.Max();
        int max = a.Sum();
        for (int i = min; i <= max; i++)
        {
            int count = CountPartitions(a, i);
            if (count == k)
            {
                return i;
            }
        }
        return -1;
    }
    private static int Optimal(int[] a, int k)
    {
        int low = a.Max();
        int high = a.Sum();
        while (low <= high)
        {
            int mid = (low + high) / 2;
            int count = CountPartitions(a, mid);
            if (count <= k)
            {
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }
        return low;
    }
    private static int CountPartitions(int[] a, int maxSum)
    {
        int partition = 1;
        int sum = 0;
        for (int i = 0; i < a.Length; i++)
        {
            if (sum + a[i] <= maxSum)
            {
                sum += a[i];
            }
            else
            {
                partition++;
                sum = a[i];
            }
        }
        return partition;
    }
}