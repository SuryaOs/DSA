namespace BinarySearch.OneDArrays;

/*
    lowerbound = smallest number in an sorted array >= target
    searchinsertposition = lowerbound
    ceil = lowerbound but initialize ans as -1;
    floor = largest number in an sorted array <= target
    upperbound = smallest number in an sorted array > target
*/
public class LowerBound
{
    public static void Run()
    {
        int[] a = { 1, 3, 5, 6 };
        int x = 7;
        Console.WriteLine(Brute(a, x));
    }
    private static int Brute(int[] a, int target)
    {
        int ans = a.Length;
        int low = 0;
        int high = a.Length - 1;
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