namespace BinarySearch.OneDArrays;

public class FloorAndCeil
{
    public static void Run()
    {
        int[] a = { 10, 20, 25, 40, 50 };
        int x = 25;
        Brute(a, x);
    }
    private static void Brute(int[] a, int target)
    {
        int floor = -1; // largest index where a[index] <= target
        int ceil = -1; // smallest index where a[index] >= target
        int low = 0;
        int high = a.Length - 1;
        while (low <= high)
        {
            int mid = (low + high) / 2;
            if (a[mid] < target)
            {
                floor = a[mid];
                low = mid + 1;
            }
            else if (a[mid] > target)
            {
                ceil = a[mid];
                high = mid - 1;
            }
            else
            {
                floor = ceil = a[mid];
                low = mid + 1;
                high = mid - 1;
            }
        }
        Console.WriteLine(floor);
        Console.WriteLine(ceil);
    }
}