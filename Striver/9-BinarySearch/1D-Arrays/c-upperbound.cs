namespace BinarySearch.OneDArrays;

public class UpperBound
{
    /*
        smallest index where a[index] > target
    */
    public static void Run()
    {
        int[] a = { 3, 5, 8, 9, 15, 19 };
        int x = 9;
        Console.WriteLine(Brute(a, x)); //4
    }
    private static int Brute(int[] a, int target)
    {
        int low = 0;
        int high = a.Length - 1;
        int ans = high;
        while (low <= high)
        {
            int mid = (low + high) / 2;
            if (a[mid] > target)
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