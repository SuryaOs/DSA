namespace BinarySearch.Problems;

public class FindMaximumOfMinimumDistance
{
    public static void Run()
    {
        int[] a = { 4, 2, 1, 3, 6 };
        int cows = 2;
        Console.WriteLine(Naive(a, cows));
        Console.WriteLine(Optimal(a, cows));
    }
    public static int Naive(int[] a, int cows)
    {
        Array.Sort(a);
        int maxMin = -1;
        int ind = a[a.Length - 1] - a[0];
        for (int i = 0; i <= ind; i++)
        {
            int distance = i;
            int stalls = NoOfStalls(a, distance);
            if (stalls >= cows)
            {
                maxMin = i;
            }
        }
        return maxMin;
    }
    public static int Optimal(int[] a, int cows)
    {
        Array.Sort(a);
        int maxMin = -1;
        int low = 1;
        int high = a[a.Length - 1];
        while (low <= high)
        {
            int mid = (low + high) / 2;
            int stalls = NoOfStalls(a, mid);
            if (stalls >= cows)
            {
                maxMin = mid;
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }
        return maxMin;
    }
    private static int NoOfStalls(int[] a, int distance)
    {
        int count = 1;
        int prev = a[0];
        for (int i = 1; i < a.Length; i++)
        {
            if (prev + distance <= a[i])
            {
                count++;
                prev = a[i];
            }
        }
        return count;
    }

}