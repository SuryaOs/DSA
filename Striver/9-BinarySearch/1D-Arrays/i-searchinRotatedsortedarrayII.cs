namespace BinarySearch.OneDArrays;

public class SearchInRotatedSortedArrayII
{
    public static void Run()
    {
        int[] a = { 7, 8, 9, 1, 2, 3, 4, 5, 6 };
        int target = 10;
        Console.WriteLine(Brute(a, target));
    }
    private static bool Brute(int[] a, int target)
    {
        int low = 0;
        int high = a.Length - 1;
        while (low <= high)
        {
            int mid = (low + high) / 2;
            if (a[mid] == target) return true;
            /*additional check compared to search rotated sorted array unique*/
            if (a[mid] == a[low] && a[mid] == a[high])
            {
                low += 1;
                high -= 1;
                continue;
            }
            if (a[mid] < a[low])
            {
                if (a[mid] <= target && target <= a[high])
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            else
            {
                if (a[low] <= target && target <= a[mid])
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
        }
        return false;
    }
}