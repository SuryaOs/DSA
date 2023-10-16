namespace dsaproblem.Striver.Recursions.Advanced;

public class Permutation
{
    // Little Bit Complex than previous 6
    public static void FindPermutation()
    {
        int[] a = { 1, 2, 3 };
        var result = new List<List<int>>();
        var dict = new Dictionary<int, bool>();
        for (int i = 0; i < a.Length; i++)
        {
            dict[i] = false;
        }
        FindPermutation(a, new List<int>(), result, dict);
        result.ForEach(x => Console.WriteLine(string.Join(", ", x)));
    }
    public static void FindPermutation(int[] a, List<int> list, List<List<int>> result, Dictionary<int, bool> dict)
    {
        if (a.Length == list.Count)
        {
            result.Add(new List<int>(list));
            return;
        }

        for (int i = 0; i < a.Length; i++)
        {
            Console.Write(" Hello "+i);
            if (!dict[i])
            {
                Console.WriteLine(" Add " + i);
                dict[i] = true;
                list.Add(a[i]);
                FindPermutation(a, list, result, dict);
                Console.WriteLine(" Remove " + i +" ");
                list.Remove(a[i]);
                dict[i] = false;
            }
        }
    }
}