namespace dsaproblem.Sorting;

public class SelectionSort
{
    //declare minIndex, find minIndex, swap it.
    //13 46 24 52 20 9
    public static void SortUnstable(int[] a)
    {
        for (int i = 0; i < a.Length - 1; i++) //Outer Loop runs for = 5 =  N-1
        {
            int minIndex = i;
            for (int j = i + 1; j < a.Length; j++) //Inner Loop Runs for 5, 4, 3, 2, 1 = (n-1) + (n-2) + (n-3) = n(n+1)/2
            {
                if (a[j] < a[minIndex])
                {
                    minIndex = j;
                }
            }
            int temp = a[i];
            a[i] = a[minIndex];
            a[minIndex] = temp;
        }

        Console.WriteLine($"Sorted Order - {string.Join(", ", a)}");
    }

    //instead of swapping move the elements one step forward
    public static void SortStable(int[] a)
    {
        for (int i = 0; i < a.Length - 1; i++) //Outer Loop runs for = 5 =  N-1
        {
            int minIndex = i;
            for (int j = i + 1; j < a.Length; j++) //Inner Loop Runs for 5, 4, 3, 2, 1 = (n-1) + (n-2) + (n-3) = n(n+1)/2
            {
                if (a[j] < a[minIndex])
                {
                    minIndex = j;
                }
            }
            int temp = a[minIndex];
            while (minIndex > i)
            {
                a[minIndex] = a[minIndex - 1];
                minIndex--;
            }
            a[i] = temp;
        }

        Console.WriteLine($"Sorted Order - {string.Join(", ", a)}");
    }
}