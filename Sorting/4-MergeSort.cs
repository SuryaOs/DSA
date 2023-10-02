namespace dsaproblem.Sorting;

public class MergeSorting
{
    public static void MergeSort(int[] a, int low, int high)
    {
        if (low == high)
            return;

        int mid = (low + high) / 2;
        MergeSort(a, low, mid);
        MergeSort(a, mid + 1, high);
        Merge(a, low, mid, high);
    }
    public static void Merge(int[] a, int low, int mid, int high)
    {
        List<int> list = new List<int>();
        int left = low;
        int right = mid + 1;

        while (left <= mid && right <= high)
        {
            if (a[left] <= a[right])
            {
                list.Add(a[left]);
                left++;
            }
            else
            {
                list.Add(a[right]);
                right++;
            }
        }

        while (left <= mid)
        {
            list.Add(a[left]);
            left++;
        }

        while (right <= high)
        {
            list.Add(a[right]);
            right++;
        }

        for (int i = low; i <= high; i++)
        {
            Console.WriteLine("I Index " + i);
            Console.WriteLine("Low Index " + low);
            a[i] = list[i - low];
        }
    }

    public static void ms(int[] a, int low, int high)
    {
        MergeSort(a, 0, 5);
        Console.WriteLine(string.Join(", ", a));
    }
}