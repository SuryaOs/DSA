namespace dsaproblem.Striver.Arrays.Easy;

public class LeftRotateArray
{
    public static void LeftRotate(int[] a)
    {
        int n = a.Length;
        if (n == 1) return;
        int temp = a[0];
        for (int i = 1; i < n; i++)
        {
            a[i - 1] = a[i];
        }
        a[n - 1] = temp;

        Console.WriteLine(string.Join(",", a));
    }
}