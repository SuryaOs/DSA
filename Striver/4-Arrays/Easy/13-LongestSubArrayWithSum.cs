namespace dsaproblem.Striver.Arrays.Easy;

public class LongestSubArrayWithSum
{
    public static void FindSubArray(int[] a, int k)
    {
        int sum = 0;
        int startIndex = 0;
        int maxLength = 0;
        for (int endIndex = 0; endIndex < a.Length; endIndex++)
        {
            sum += a[endIndex];
            if (sum > k)
            {
                startIndex = endIndex + 1;
                sum = 0;
            }

            if (sum == k)
            {
                int currentLength = endIndex - startIndex + 1;
                if (currentLength > maxLength)
                    maxLength = currentLength;

                startIndex = endIndex + 1;
                sum = 0;
            }
        }
        Console.WriteLine(maxLength);
    }

    // It Fails on Some Condition Handled on October Two with Below Code
    public static int MaxSumSub(int[] a, int k)
    {
        int maxLen = 0, i = 0, j = 1, sum = a[0];
        while (j < a.Length)
        {
            sum += a[j];
            if (sum > k)
            {
                while (sum > k && i <= j)
                {
                    sum -= a[i];
                    i++;
                }
            }
            if (sum == k)
            {
                maxLen = Math.Max(maxLen, j - i + 1);
            }
            j++;
        }
        return maxLen;
    }

    // Dictionary Reverse Maths ( Best for Positive and Negative Numbers)
    // 1 2 3 1 1 1 1 4 2 3
    // x , preSum = x - k
    public static void FindSubArrayDict(int[] a, int k)
    {
        Dictionary<int, int> dict = new();
        int sum = 0;
        int len = 0;
        for (int i = 0; i < a.Length; i++)
        {
            sum += a[i];
            if (!dict.ContainsKey(sum))
            {
                dict.Add(sum, i);
            }
            int prefixSum = sum - k;
            if (prefixSum == 0)
                len = Math.Max(len, i + 1);
            else if (dict.ContainsKey(prefixSum))
            {
                len = Math.Max(len, i - dict[prefixSum]);
            }
        }
        Console.WriteLine(len);
    }
}