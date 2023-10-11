namespace dsaproblem.Striver.Recursions.Advanced;
public class SubSetSum
{
    // Same like Subsequence, but here is no target.
    // Just print addition of all subsequence
    public static void FindSubSetSum(int[] a, int index, int sum, List<int> result)
    {
        if (index == a.Length)
        {
            Console.WriteLine(sum);
            result.Add(sum);
            return;
        }
        sum += a[index];
        FindSubSetSum(a, index + 1, sum, result);
        sum -= a[index];
        FindSubSetSum(a, index + 1, sum, result);
    }
}