namespace BinarySearch.OneDArrays;

public class HowManyTimesArrayIsRotated
{
    public static void Run()
    {
        int[] a = { 3, 4, 5, 1, 2 };
        Console.WriteLine(Brute(a));
    }
    private static int Brute(int[] a)
    {
        int low = 0;
        int high = a.Length - 1;
        int min = int.MaxValue;
        int index = -1;
        while (low <= high)
        {
            int mid = (low + high) / 2;
            /*Optional Start*/
            if (a[low] < a[high])
            {
                min = a[low];
                index = low;
                break;
            }
            /*Optional End*/
            if (a[mid] >= a[low]) // left half is sorted
            {
                min = Math.Min(min, a[low]);
                low = mid + 1;
                index = low;
            }
            else
            {
                min = Math.Min(min, a[mid]);
                high = mid - 1;
                index = mid;
            }
        }
        return index;
    }
}