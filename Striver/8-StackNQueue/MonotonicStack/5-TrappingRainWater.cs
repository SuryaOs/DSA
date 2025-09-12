namespace StackNQueue.MonotonicStack;

public class TrappingRainWater
{
    public static void Brute()
    {
        int[] a = { 0, 1, 0, 2, 1, 0, 1, 3, 1, 2, 1 };
        Console.WriteLine(Naive(a));
        Console.WriteLine(Medium(a));
    }
    public static int Naive(int[] a)
    {
        var preGreat = PreFix(a);
        var postGreat = PostFix(a);
        int total = 0;
        for (int i = 0; i < a.Length; i++)
        {
            total += Math.Min(preGreat[i], postGreat[i]) - a[i];
        }
        return total;
    }
    public static int Medium(int[] a)
    {
        var postGreat = PostFix(a);
        var preGreat = int.MinValue;
        int total = 0;
        for (int i = 0; i < a.Length; i++)
        {
            preGreat = Math.Max(preGreat, a[i]);
            total += Math.Min(preGreat, postGreat[i]) - a[i];
        }
        return total;
    }
    private static int[] PreFix(int[] a)
    {
        int[] res = new int[a.Length];
        res[0] = a[0];
        for (int i = 1; i < a.Length; i++)
        {
            res[i] = Math.Max(res[i - 1], a[i]);
        }
        return res;
    }
    private static int[] PostFix(int[] a)
    {
        int[] res = new int[a.Length];
        res[a.Length - 1] = a[a.Length - 1];
        for (int i = a.Length - 2; i >= 0; i--)
        {
            res[i] = Math.Max(res[i + 1], a[i]);
        }
        return res;
    }
}
