namespace dsaproblem.Striver.Arrays.Easy;

public class RotateArrayByKElements
{
    public static void RotateRight(int[] a, int k)
    {
        int n = a.Length;
        int[] temp = new int[k];

        for (int i = n - k; i < n; i++)
        {
            temp[i + k - n] = a[i];
        }

        Console.WriteLine($"Copied Array: {string.Join(", ", temp)}");

        for (int i = n - 1; i >= k; i--)
        {
            a[i] = a[i - k];
        }

        for (int i = 0; i < k; i++)
        {
            a[i] = temp[i];
        }

        Console.WriteLine($"Final Result: {string.Join(", ", a)}");

    }

    public static void RotateLeft(int[] a, int k)
    {
        int n = a.Length;
        int[] temp = new int[k];

        for (int i = 0; i < k; i++)
        {
            temp[i] = a[i];
        }

        // Console.WriteLine($"Copied Array: {string.Join(", ", temp)}");
        for (int i = 0; i < n - k; i++)
        {
            a[i] = a[i + k];
        }
        
        // Console.WriteLine($"Shifted Array: {string.Join(", ", a)}");

        for (int i = 0; i < k; i++)
        {
            a[n-k+i] = temp[i];
        }

        Console.WriteLine($"Final Result: {string.Join(", ", a)}");
    }
}