namespace dsaproblem.Striver.Arrays.Medium;

public class LeadersInAnArray
{
    public static void LeadersInAnArrayBrute(int[] arr)
    {
        var n = arr.Length - 1;
        int leader = arr[n];
        List<int> leaders = new();
        leaders.Add(leader);
        for (int i = n - 1; i > 0; i--)
        {
            if (arr[i] > leader)
            {
                leader = arr[i];
                leaders.Add(leader);
            }
        }
        leaders.Reverse();
        Console.WriteLine(string.Join(", ", leaders));
    }
}