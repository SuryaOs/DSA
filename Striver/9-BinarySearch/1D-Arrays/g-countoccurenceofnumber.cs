namespace BinarySearch.OneDArrays;

public class CountOccurence
{
    public static void Run()
    {
        int[] a = { 2, 4, 6, 8, 8, 8, 11, 13, 19 };
        int x = 4;

        Console.WriteLine(Brute(a, x));
        Console.WriteLine(Optimal(a, x));
    }
    private static int Brute(int[] a, int target)
    {
        var ans = FirstAndLastOccurence.Brute(a, target);
        return ans.Item1 == -1 ? 0 : ans.Item2 - ans.Item1 + 1;
    }
    private static int Optimal(int[] a, int target)
    {
        int first = FirstOccurence(a, target);
        if (first == -1) return 0;
        int last = LastOccurence(a, target);
        return last - first + 1;
    }
    // First and Last Occurence - Second Way
    private static int FirstOccurence(int[] a, int target)
    {
        int first = -1;
        int low = 0;
        int high = a.Length - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;
            if (a[mid] == target)
            {
                first = mid;
                high = mid - 1;
            }
            else if (a[mid] > target)
            {
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }
        return first;
    }
    private static int LastOccurence(int[] a, int target)
    {
        int last = -1;
        int low = 0;
        int high = a.Length - 1;
        while (low <= high)
        {
            int mid = (low + high) / 2;
            if (a[mid] == target)
            {
                last = mid;
                low = mid + 1;
            }
            else if (a[mid] > target)
            {
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }
        return last;
    }
}