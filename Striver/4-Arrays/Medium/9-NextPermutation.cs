using dsaproblem.Practice;

namespace dsaproblem.Striver.Arrays.Medium;

public class NextPermutation
{
    // 1) Find longer prefix (Smaller number from right end)
    // 2) Find number that is slightly greater than prefix (start from right end) and Swap
    // 3) Sort the elements after the prefix
    // Corner Case - If you didn't find prefix, then reverse entire array
    public static void FindNextPermutation(int[] a)
    {
        Practice(a);
        Console.WriteLine(string.Join(", ", a));
    }
    public static int[] Practice(int[] a)
    {
        int n = a.Length;
        int prefix = -1;
        for (int i = n - 2; i >= 0; i--)
        {
            if (a[i] < a[i + 1])
            {
                prefix = i;
                break;
            }
        }
        if (prefix == -1)
        {
            ReverseAnArray(a, 0, n - 1);
            return a;
        }
        for (int j = n - 1; j > prefix; j--)
        {
            if (a[j] > a[prefix])
            {
                Swap(a, prefix, j);
                break;
            }
        }
        ReverseAnArray(a, prefix + 1, n - 1);
        return a;
    }
    public static void Swap(int[] a, int i, int j)
    {
        int temp = a[i];
        a[i] = a[j];
        a[j] = temp;
    }
    public static void ReverseAnArray(int[] a, int i, int j)
    {
        while (i < j)
        {
            int temp = a[i];
            a[i] = a[j];
            a[j] = temp;

            i++;
            j--;
        }
    }
}