namespace BinarySearch.Problems;

public class KokoEatingBananas
{
    public static void Run()
    {
        int[] a = { 25, 12, 8, 14, 9 }; // 1st pile 25 Bana, 2nd pile 12.. bana
        int h = 5; // total hour is 5. how much banaa per hour to compelte all?
        Console.WriteLine(Naive(a, h)); // O(N) + O(N * log max(a[]))
        //Brute TC => O(N) + O(N * max(a[]))
    }

    // Looks like this is optimal. The brute would be iterating from low to max (O)
    private static int Naive(int[] a, int h)
    {
        int high = FindMax(a); // O(N)
        int low = 1;
        int ans = -1;
        while (low <= high) // O(log max(a[]))
        {
            int mid = (low + high) / 2;
            double sum = HoursTakenToEatMidBananaPerHour(a, mid);
            // for (int i = 0; i < a.Length; i++) // O(N)
            // {
            //     sum += Math.Ceiling((double)a[i] / mid);
            //      if(sum > h) break; I added to prevent overflow error
            // }
            if (sum > h)
            {
                low = mid + 1;
            }
            else if (sum < h)
            {
                ans = mid; // could be answer but might not be minimum
                high = mid - 1;
            }
            else
            {
                ans = mid;
                break;
            }
        }
        return ans;
    }

    private static double HoursTakenToEatMidBananaPerHour(int[] a, int mid)
    {
        double sum = 0;
        for (int i = 0; i < a.Length; i++) // O(N)
        {
            sum += Math.Ceiling((double)a[i] / mid);
        }
        return sum;
    }

    private static int FindMax(int[] a)
    {
        int max = -1;
        for (int i = 0; i < a.Length; i++)
        {
            max = Math.Max(a[i], max);
        }
        return max;
    }
}
