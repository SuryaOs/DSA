namespace dsaproblem.Striver.Recursions.Advanced;

public class CombinationSum
{
    // Pick - if (a[i] < target) with same Index
    // Not pick - i + 1
    public static void FindCombination(int[] a, int target, int i, List<int> list)
    {
    if(i == a.Length)
    {
        if (target == 0)
        {
            Console.WriteLine(string.Join(", ", list));
            return;
        }
        return;
    }

        if (a[i] <= target)
        {
            list.Add(a[i]);
            target -= a[i];
            FindCombination(a, target, i, list);
            list.Remove(a[i]);
            target = target + a[i];
        }
        FindCombination(a, target, i + 1, list);
    }
}