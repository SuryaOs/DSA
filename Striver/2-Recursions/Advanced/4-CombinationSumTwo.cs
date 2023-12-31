namespace dsaproblem.Striver.Recursions.Advanced;

public class CombinationSumTwo
{
    // A recursion cannot start from same number, as it will cause duplicate datac( Unque Subsequence )
    // only two recursion in below case, index 0,3
    public static void FindCombinationSumTwo()
    {
        int[] a = { 1, 1, 1, 2, 2 };
        var result = new HashSet<List<int>>();
        CombinationSum(a, 4, 0, new List<int>(), result);
        foreach (var x in result)
        {
            Console.WriteLine(string.Join(", ", x));
        }
    }
    public static void CombinationSum(int[] a, int target, int index, List<int> list, HashSet<List<int>> result)
    {
        if (target == 0)
        {
            result.Add(new List<int>(list));
            return;
        }
        for (int i = index; i < a.Length; i++)
        {
            if (i > index && a[i] == a[i - 1]) continue;
            if (a[i] > target) break;

            list.Add(a[i]);
            CombinationSum(a, target - a[i], i + 1, list, result);
            list.Remove(a[i]);
        }
    }
}