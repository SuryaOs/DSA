namespace dsaproblem.Striver.Arrays.Hard;

public class LongestSubArraySumZeroLength
{
    public static void Brute(int[] a)
    {
        int n = a.Length;
        int res = 0;
        for (int i = 0; i < n; i++)
        {
            int sum = a[i];
            for (int j = i + 1; j < n; j++)
            {
                sum += a[j];
                if (sum == 0)
                {
                    res = Math.Max(res, j - i + 1);
                }
            }
        }
        Console.WriteLine("Length of longest subarray = " + res);
    }
    public static void Better(int[] a)
    {
        int n = a.Length;
        int startIndex = 0;
        int sum = 0;
        int res = 0;
        for (int i = 0; i < n; i++)
        {
            sum += a[i];
            if (sum == 0)
            {
                res = Math.Max(res, i + 1 - startIndex);
                startIndex = i;
            }
        }
        Console.WriteLine("Length of longest subarray = " + res);
    }

    // Similart to Kadane's Algorthim
    // 9, -3, 3, -1, 6, -5
    // a[0] = 9
    // a[0] + a[1] + a[2] = 9
    // 9    + 0           = 9               => I - dict[s] = 2
    // a[0] + a[1] + a[2] + a[3] + a[4] = 9
    // 9    + 0                         = 9 => I - dict[s] = 5
    public static void Optimal(int[] a)
    {
        int n = a.Length;
        Dictionary<int, int> dict = new();
        int s = 0;
        int res = 0;
        for (int i = 0; i < n; i++)
        {
            s += a[i];
            if (s == 0) res = i + 1;
            else if (dict.ContainsKey(s)) res = Math.Max(res, i - dict[s]);
            else dict.Add(s, i);
        }
        Console.WriteLine(res);
    }
}