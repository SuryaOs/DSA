namespace StackNQueue.MonotonicStack;

public class SumOfSubArrayRange
{
    public static void Brute()
    {
        int[] a = { 1, 3, 4, 2 };
        Console.WriteLine(Optimal(a));
        Console.WriteLine(Medium(a));
    }
    private static int Optimal(int[] a)
    {
        var sMax = SumOfSubArrayMaximum.Optimal(a);
        var sMin = SumOfSubArrayMinimum.Optimal(a);
        return sMax - sMin;
    }
    private static int Medium(int[] a)
    {
        int total = 0;
        for (int i = 0; i < a.Length; i++)
        {
            int max = a[i]; int min = a[i];
            for (int j = i; j < a.Length; j++)
            {
                max = Math.Max(a[j], max);
                min = Math.Min(a[j], min);
                total += max - min;
            }
        }
        return total;
    }
}