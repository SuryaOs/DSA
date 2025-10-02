namespace BinarySearch.Problems;

public class AllocateMinimumNumberOfPages
{
    public static void Run()
    {
        int[] a = { 12, 34, 67, 90 };
        int students = 2;
        Console.WriteLine(Naive(a, students));
        Console.WriteLine(Optimal(a, students));
    }
    private static int Naive(int[] a, int students)
    {
        int min = a.Max();
        int max = a.Sum();
        for (int i = min; i <= max; i++)
        {
            int count = AssignBooks(a, i);
            if (count == students)
            {
                return i;
            }
        }
        return -1;
    }
    private static int Optimal(int[] a, int students)
    {
        int low = a.Max();
        int high = a.Sum();
        // int ans = -1;
        while (low <= high)
        {
            int mid = (low + high) / 2;
            int count = AssignBooks(a, mid);
            if (count > students)
            {
                low = mid + 1;
            }
            else
            {
                // ans = mid;
                high = mid - 1;
            }
        }
        return low; // return ans
    }
    private static int AssignBooks(int[] a, int pages)
    {
        int students = 1;
        int studentPages = 0;
        for (int i = 0; i < a.Length; i++)
        {
            if (studentPages + a[i] <= pages)
            {
                studentPages += a[i];
            }
            else
            {
                students++;
                studentPages = a[i];
            }
        }
        return students;
    }
}