namespace BinarySearch.OneDArrays;

public class SearchInsertPosition // and lower bound are same
{
    public static void Run()
    {
        int[] a = { 1, 2, 2, 4, 7 };
        int x = 2;
        Console.WriteLine(Brute(a, x));
    }
    private static int Brute(int[] a, int target)
    {
        int low = 0;
        int high = a.Length - 1;
        int ans = a.Length;
        while (low <= high)
        {
            int mid = (low + high) / 2;
            if (a[mid] >= target)
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