namespace dsaproblem.Striver.Recursions.Basics;

public class ReverseAnArray
{
    public static void Print(int[] arr, int n)
    {
        Recurse(arr, 0, n - 1);
        Print(arr);
    }

    public static void Recurse(int[] arr, int start, int end)
    {
        if (start > end)
        {
            return;
        }

        int temp = arr[start];
        arr[start] = arr[end];
        arr[end] = temp;

        Recurse(arr, start + 1, end - 1);
    }
    public static void Print(int[] arr)
    {
        Console.WriteLine(string.Join(",", arr));
    }
}