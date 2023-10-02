namespace dsaproblem.Sorting;

public class BubbleSort
{
    //Pass 1
    //Compare 1 and 2, swap it.
    //Compare 2 and 3, swap it.
    //Compare 3 and 4, swap it.
    //At last you will have max element. so next pass skip that index.
    //Pass 2..
    public static void Sort(int[] a)
    {
        int n = a.Length; // 6
        for (int i = 0; i < n - 1; n--)
        {
            int j = i;

            while (j < n - 1)
            {
                if (a[j] > a[j + 1])
                {
                    int temp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = temp;
                }
                j++;
            }
        }
        Console.WriteLine(string.Join(",", a));
    }

    public static void SortStriver(int[] a)
    {
        int n = a.Length; // 6
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (a[j] > a[j + 1])
                {
                    int temp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = temp;
                }
            }
        }
        Console.WriteLine(string.Join(",", a));
    }
    // october 2
    public static void SortLatest(int[] a)
    {
        int n = a.Length; // 6
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 1; j < n - i; j++)
            {
                if (a[j - 1] > a[j])
                {
                    int temp = a[j];
                    a[j] = a[j - 1];
                    a[j - 1] = temp;
                }
            }
        }
        Console.WriteLine(string.Join(",", a));
    }
}