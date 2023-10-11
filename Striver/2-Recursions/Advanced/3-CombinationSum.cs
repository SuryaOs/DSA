namespace dsaproblem.Striver.Recursions.Advanced;

public class CombinationSum
{
    // Pick - if (a[i] < target) with same Index
    // Not pick - i + 1
    public static void FindCombination(int[] a, int target, int i, List<int> list)
    {
        if (i == a.Length)
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

    // Same Approach with Additional DataSet (HashSet to Store the result)
    public static void FindCombinationSum(int[] a, int target, int index, List<int> list, HashSet<List<int>> result)
    {
        if (index == a.Length)
        {
            if (target == 0)
            {
                result.Add(new List<int>(list));
                return;
            }
            return;
        }
        if (a[index] <= target)
        {
            list.Add(a[index]);
            target = target - a[index];
            FindCombinationSum(a, target, index, list, result);
            target = target + a[index];
            list.Remove(a[index]);
        }
        FindCombinationSum(a, target, index + 1, list, result);
    }
}