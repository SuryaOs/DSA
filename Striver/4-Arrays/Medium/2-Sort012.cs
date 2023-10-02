namespace dsaproblem.Striver.Arrays.Medium;

public class Sort012
{
    public static void Sort(int[] a)
    {
        int count0 = 0;
        int count1 = 0;
        int count2 = 0;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == 0) count0++;
            else if (a[i] == 1) count1++;
            else if (a[i] == 2) count2++;
        }

        for (int i = 0; i < count0; i++)
        {
            a[i] = 0;
        }
        for (int i = count0; i < count0 + count1; i++)
        {
            a[i] = 1;
        }
        for (int i = count0 + count1; i < count0 + count1 + count2; i++)
        {
            a[i] = 2;
        }
        Console.WriteLine(string.Join(", ", a));
    }

    // Dutch National Flag Algorithm
    // 0 to Low - 1 = 0
    // Low to mid - 1 = 1
    // mid to high = 0,1,2 mid to high is unsorted , so iterate from mid to high
    // high+1  to n = 2
    public static void SortOptimal(int[] a)
    {
        int low = 0;
        int mid = 0;
        int high = a.Length - 1;
        while (mid < high)
        {
            if (a[mid] == 0)
            {
                int temp = a[mid];
                a[mid] = a[low];
                a[low] = temp;
                low++;
                mid++;
            }
            else if (a[mid] == 1)
            {
                mid++;
            }
            else if (a[mid] == 2)
            {
                int temp = a[mid];
                a[mid] = a[high];
                a[high] = temp;
                high--;
            }
        }
        Console.WriteLine(string.Join(", ", a));
    }

    public static void SortOptimalFor(int[] a)
    {
        int low = 0;
        int high = a.Length - 1;
        for (int mid = 0; mid < high;)
        {
            if (a[mid] == 0)
            {
                int temp = a[mid];
                a[mid] = a[low];
                a[low] = temp;
                low++;
                mid++;
            }
            else if (a[mid] == 1)
            {
                mid++;
            }
            else if (a[mid] == 2)
            {
                int temp = a[mid];
                a[mid] = a[high];
                a[high] = temp;
                high--;
            }
        }
        Console.WriteLine(string.Join(", ", a));
    }

}