namespace BinarySearch.Problems;

public class CapacityToShipPackageInNDays
{
    public static void Run()
    {
        int[] a = { 1, 2, 3, 1, 1 };
        int days = 4;
        Console.WriteLine(Naive(a, days));
        Console.WriteLine(Optimal(a, days));
    }
    public static int Naive(int[] a, int days)
    {
        int min = MinDaysToMakeMBoquets.FindMax(a);
        int max = Sum(a);
        for (int i = min; i <= max; i++)
        {
            int totalDays = FindNumberOfDaysBS(i, a);
            if (totalDays == days)
            {
                return i;
            }
        }
        return -1;
    }
    public static int Optimal(int[] a, int days)
    {
        int low = MinDaysToMakeMBoquets.FindMax(a);
        int high = Sum(a);
        int capacity = -1;
        while (low <= high)
        {
            int mid = (low + high) / 2;
            int totalDays = FindNumberOfDays(mid, a);
            if (totalDays <= days)
            {
                capacity = mid;
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }
        return capacity;
    }

    private static int FindNumberOfDays(int cap, int[] a)
    {
        int days = 1;
        int load = 0;
        for (int i = 0; i < a.Length; i++)
        {
            if (load + a[i] <= cap) // check the load with capacity before loading
            {
                load += a[i];
            }
            else
            {
                days += 1;
                load = a[i];
            }
        }
        return days;
    }
    // bs fails on some cases
    private static int FindNumberOfDaysBS(int cap, int[] a)
    {
        int days = 0;
        int sum = 0;
        for (int i = 0; i < a.Length; i++)
        {
            sum += a[i];
            if (i == a.Length - 1)
            {
                days++;
                break;
            }
            if (a[i + 1] > cap - sum)
            {
                days++;
                sum = 0;
            }
        }
        return days;
    }
    private static int Sum(int[] a)
    {
        int sum = 0;
        foreach (int val in a)
            sum += val;
        return sum;
    }

}