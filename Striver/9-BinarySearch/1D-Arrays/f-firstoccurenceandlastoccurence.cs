namespace BinarySearch.OneDArrays;

public class FirstAndLastOccurence
{
    public static void Run()
    {
        int[] a = { 2, 4, 6, 8, 8, 8, 11, 13, 19 };
        int x = 6;
        var ans = Brute(a, x);
        Console.WriteLine(ans.Item1 + " " + ans.Item2);
    }
    public static Tuple<int, int> Brute(int[] a, int target)
    {
        int first = a.Length;
        int last = a.Length;
        int low = 0;
        int high = a.Length - 1;
        // lower bound
        while (low <= high)
        {
            int mid = (low + high) / 2;
            if (a[mid] >= target)
            {
                high = mid - 1;
                first = mid;
            }
            else
            {
                low = mid + 1;
            }
        }
        low = 0;
        high = a.Length - 1;
        // variation of lower bound (my version) or you can also use upperbound - 1 like striver
        while (low <= high)
        {
            int mid = (low + high) / 2;
            if (a[mid] <= target)
            {
                low = mid + 1;
                last = mid;
            }
            else
            {
                high = mid - 1;
            }
        }
        if (first == a.Length || a[first] != target) first = -1;
        if (last == a.Length || a[last] != target) last = -1;

        return new Tuple<int, int>(first, last);
    }
}