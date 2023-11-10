namespace dsaproblem.Striver.Arrays.Hard;

public class FourSum
{
    // 4,3,3,4,4,2,1,2,1,1
    public static void Brute(int[] a, int target)
    {
        HashSet<int[]> set = new(new IntArrayComparer());
        int n = a.Length;
        Array.Sort(a);
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                for (int k = j + 1; k < n; k++)
                {
                    for (int l = k + 1; l < n; l++)
                    {
                        int sum = a[i] + a[j] + a[k] + a[l];
                        if (sum == target)
                        {
                            int[] quad = new int[] { a[i], a[j], a[k], a[l] };
                            set.Add(quad);
                        }
                    }
                }
            }
        }
        foreach (int[] s in set)
        {
            Console.WriteLine(string.Join(", ", s));
        }
    }
    public static void Better(int[] a, int target)
    {
        HashSet<int> set = new();
        HashSet<int[]> result = new(new IntArrayComparer());
        int n = a.Length;
        Array.Sort(a);
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                set.Clear();
                for (int k = j + 1; k < n; k++)
                {
                    int pre = target - (a[i] + a[j] + a[k]);
                    if (set.Contains(pre))
                    {
                        // Use HashSet to store unique combo
                        result.Add(new int[] { a[i], a[j], pre, a[k] });
                        // Console.WriteLine($"{pre} {a[i]} {a[j]} {a[k]}");
                    }
                    else
                    {
                        set.Add(a[k]);
                    }
                }
            }
        }
        foreach (var s in result)
        {
            Console.WriteLine(string.Join(", ", s));
        }
    }
    public static void Optimal(int[] a, int target)
    {
        int n = a.Length;
        Array.Sort(a);
        for (int i = 0; i < n; i++)
        {
            if (i > 0 && a[i] == a[i - 1]) continue;
            for (int j = i + 1; j < n; j++)
            {
                if (j > i + 1 && a[j] == a[j - 1]) continue;

                int k = j + 1;
                int l = n - 1;
                while (k < l)
                {
                    int sum = a[i] + a[j] + a[k] + a[l];
                    if (sum < target) k++;
                    else if (sum > target) l--;
                    else
                    {
                        Console.WriteLine($"{a[i]} {a[j]} {a[k]} {a[l]}");
                        k++;
                        l--;
                        while (k < l && a[k] == a[k - 1]) k++;
                        while (k < l && a[l] == a[l + 1]) l--;
                    }
                }
            }
        }
    }
}