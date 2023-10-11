namespace dsaproblem.Striver.Recursions.Advanced;

public class SubSetSumTwo
{
    public static void Main()
    {
        int[] a = { 1, 2, 2 };
        var result = new List<List<int>>();
        FindSubSetSumTwo(a, 0, 0, new List<int>(), result);
        result.ForEach(x => Console.WriteLine(string.Join(", ", x)));
    }
    public static void FindSubSetSumTwo(int[] a, int sum, int ind, List<int> list, List<List<int>> result)
    {
        result.Add(new List<int>(list));

        for (int i = ind; i < a.Length; i++)
        {
            if (i > ind && a[i] == a[i - 1]) continue;

            list.Add(a[i]);
            FindSubSetSumTwo(a, sum + a[i], i + 1, list, result);
            list.Remove(a[i]);
        }
    }
}