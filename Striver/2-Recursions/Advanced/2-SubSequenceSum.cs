namespace dsaproblem.Striver.Recursions.Advanced;

public class SubSequenceSum
{
    public static void FindSubSequenceSum(int index, int[] a, int sum, int target, List<int> list)
    {
        if (index >= a.Length)
        {
            if (sum == target)
            {
                Console.WriteLine(string.Join(", ", list));
            }
            return;
        }
        // Take
        sum += a[index];
        list.Add(a[index]);
        FindSubSequenceSum(index + 1, a, sum, target, list);
        // Not Take
        sum -= a[index];
        list.Remove(a[index]);
        FindSubSequenceSum(index + 1, a, sum, target, list);
    }
    public static bool FindSubSequenceSumOne(int index, int[] a, int sum, int target, List<int> list, int count)
    {
        if (index >= a.Length)
        {
            if (sum == target)
            {
                Console.WriteLine(string.Join(", ", list));
                return true;
            }
            return false;
        }
        // Take
        sum += a[index];
        list.Add(a[index]);
        if (FindSubSequenceSumOne(index + 1, a, sum, target, list, count)) return true;
        // Not Take
        sum -= a[index];
        list.Remove(a[index]);
        if (FindSubSequenceSumOne(index + 1, a, sum, target, list, count)) return true;

        return false;
    }
    public static int FindSubSequenceSumCount(int index, int[] a, int sum, int target)
    {
        if (index >= a.Length)
        {
            if (sum == target) return 1;
            return 0;
        }
        // Take
        sum += a[index];
        int l = FindSubSequenceSumCount(index + 1, a, sum, target);
        // Not Take
        sum -= a[index];
        int r = FindSubSequenceSumCount(index + 1, a, sum, target);

        return l + r;
    }
}