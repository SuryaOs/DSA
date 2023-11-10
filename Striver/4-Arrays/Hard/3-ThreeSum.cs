namespace dsaproblem.Striver.Arrays.Hard;

public class ThreeSum
{
    // explore BA
    public static void Brute(int[] a)
    {
        HashSet<int[]> set = new(new IntArrayComparer());
        int n = a.Length;
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                for (int k = j + 1; k < n; k++)
                {
                    if (a[i] + a[j] + a[k] == 0)
                    {
                        int[] res = new[] { a[i], a[j], a[k] };
                        Array.Sort(res);
                        set.Add(res);
                        // Console.WriteLine($"{a[i]} {a[j]} {a[k]}");
                    }
                }
            }
        }
        foreach (var s in set)
        {
            Console.WriteLine(string.Join(", ", s));
        }
    }
    public static void Optimal(int[] a)
    {
        int n = a.Length;
        Array.Sort(a);
        for (int i = 0; i < n; i++)
        {
            if (i > 0 && a[i] == a[i - 1]) continue;
            int j = i + 1;
            int k = n - 1;
            while (j < k)
            {
                int sum = a[i] + a[j] + a[k];
                if (sum < 0) j++;
                else if (sum > 0) k--;
                else
                {
                    // you can add to set as well similar to brute
                    Console.WriteLine($"{a[i]} {a[j]} {a[k]}");
                    j++;
                    k--;
                    while (j < k && a[j] == a[j - 1]) j++;
                    while (j < k && a[k] == a[k + 1]) k--;
                }
            }
        }
    }
    public static void Better(int[] a)
    {
        // a[i] + a[j] + a[k] = 0 => a[k] = -a[i] - a[j]
        HashSet<int> set = new();
        int n = a.Length;
        for (int i = 0; i < a.Length; i++)
        {
            set.Clear();
            for (int j = i + 1; j < a.Length; j++)
            {
                int pre = -(a[i] + a[j]);
                if (set.Contains(pre))
                {
                    // Use HashSet to store unique combo
                    Console.WriteLine($"{pre} {a[i]} {a[j]}");
                }
                else
                {
                    set.Add(a[j]);
                }
            }
        }
    }
}

public class IntArrayComparer : IEqualityComparer<int[]>
{
    public bool Equals(int[] x, int[] y)
    {
        if (x.Length != y.Length) return false;

        for (int i = 0; i < x.Length; i++)
        {
            if (x[i] != y[i]) return false;
        }

        return true;
    }

    public int GetHashCode(int[] obj)
    {
        int hash = 7;
        foreach (int i in obj)
        {
            hash = hash * 23 + i.GetHashCode();
        }
        return hash;
    }
}