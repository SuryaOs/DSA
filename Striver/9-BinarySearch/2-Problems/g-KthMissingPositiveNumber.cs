namespace BinarySearch.Problems;

public class KthMissingPositiveNumber
{
    public static void Run()
    {
        int[] a = { 1, 2, 3, 4 };
        int k = 2;
        Console.WriteLine(Naivest(a, k));
    }
    private static int Naivest(int[] a, int k)
    {
        int min = 1;
        int max = a.Max() + k;
        int count = 0;
        for (int i = min; i <= max; i++)
        {
            bool isMissing = Missing(a, i);
            if (isMissing)
            {
                count++;
            }
            if (count == k)
            {
                return i;
            }
        }
        return -1;
    }
    private static bool Missing(int[] a, int num)
    {
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == num)
            {
                return false;
            }
        }
        return true;
    }
}