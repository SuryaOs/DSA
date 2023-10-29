namespace dsaproblem.Striver.Arrays.Hard;
//3, 2, 2, 3, 2, 3
public class NumbersThatOccursNBy3
{
    public static void Brute(int[] a)
    {
        var dict = new Dictionary<int, int>();
        var n = a.Length / 3;
        for (int i = 0; i < a.Length; i++)
        {
            if (!dict.ContainsKey(a[i])) dict.Add(a[i], 1);
            else dict[a[i]]++;

            if (dict[a[i]] > n)
                Console.WriteLine(a[i]);
        }
    }
    public static void Optimal(int[] a)
    {
        HashSet<int> result = new();

        int cnt1 = 0;
        int cnt2 = 0;

        int contender1 = int.MinValue;
        int contender2 = int.MinValue;

        int min = a.Length / 3;

        for (int i = 0; i < a.Length; i++)
        {
            if (cnt1 == 0 && a[i] != contender2)
            {
                cnt1 = 1;
                contender1 = a[i];
            }
            else if (cnt2 == 0 && a[i] != contender1)
            {
                cnt2 = 1;
                contender2 = a[i];
            }
            else if (a[i] == contender1) cnt1++;
            else if (a[i] == contender2) cnt2++;
            else
            {
                cnt1--;
                cnt2--;
            }
        }

        cnt1 = cnt2 = 0;

        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == contender1) cnt1++;
            if (a[i] == contender2) cnt2++;
        }

        if (cnt1 > min) result.Add(contender1);
        if (cnt2 > min) result.Add(contender2);

        Console.WriteLine(string.Join(", ", result));
    }
}