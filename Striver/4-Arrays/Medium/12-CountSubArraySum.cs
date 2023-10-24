namespace dsaproblem.Striver.Arrays.Medium;

public class CountSubArraySum
{
    public static void PrintCount(int[] a, int k)
    {
        int sum = 0;
        int count = 0;
        int diff = 0;
        HashSet<int> set = new();
        for (int i = 0; i < a.Length; i++)
        {
            sum += a[i];
            set.Add(sum);
            diff = sum - k;
            if (diff == 0) count++;
            else if (set.Contains(diff)) count++;
        }
        Console.WriteLine(count);
    }
}