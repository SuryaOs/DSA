namespace dsaproblem.Striver.Arrays.Medium;

public class TwoPairSum
{
    public static void FindTwoPair(int[] a, int sum)
    {
        for (int i = 0; i < a.Length; i++)
        {
            for (int j = i + 1; j < a.Length; j++)
            {
                if (a[i] + a[j] == sum)
                {
                    Console.WriteLine(i + ", " + j);
                }
            }
        }
    }

    public static void FindTwoPairBetter(int[] a, int sum)
    {
        Dictionary<int, int> dict = new();
        for (int i = 0; i < a.Length; i++)
        {
            int x = sum - a[i];

            if (dict.TryGetValue(x, out int y))
            {
                Console.WriteLine(y + ", " + i);
            }
            else
            {
                dict.Add(a[i], i);
            }
        }
    }

    // It is optimal to tell if it has pair sum or not.
    // For index above Solution is optimal
    public static void FindTwoPairOptimal(int[] a, int sum)
    {
        Array.Sort(a);
        int left = 0;
        int right = a.Length - 1;

        while (left < right)
        {
            if (a[left] + a[right] < sum)
            {
                left++;
            }
            else
            if (a[left] + a[right] > sum)
            {
                right--;
            }
            else
            {
                Console.WriteLine("Yes");
                left++;
                right--;
            }

        }
    }
}