namespace dsaproblem.Sorting;

public class InsertionSort
{
    //compare first second element with first element, swap or skip it.
    //compare third element with second element, swap or skip, compare again with first element, swap or skip.
    public static void Sort(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            int j = i;
            while(j > 0 && a[j-1] > a[j])
            {
                int temp = a[j];
                a[j] = a[j-1];
                a[j-1] = temp;
                j--;
            }
        }
        Console.WriteLine(string.Join(", ", a));
    }
    public static void InsertSort(int[] a) {
        int n = a.Length;
        for(int i = 0; i < n - 1; i++)
        {
            for(int j = i + 1; j > 0; j-- )
            {
                if(a[j] < a[j-1])
                {
                    int temp = a[j];
                    a[j] = a[j-1];
                    a[j-1] = temp;
                }
            }
        }
        Console.WriteLine(string.Join(", ", a));
    }
}