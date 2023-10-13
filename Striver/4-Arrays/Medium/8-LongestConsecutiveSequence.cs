using System.Collections.Generic;
namespace dsaproblem.Striver.Arrays.Medium;

public class LongestConsecutiveSequence
{
    public static void FindLongestConsecutiveSequenceOptimal(int[] a)
    {
        var set = new HashSet<int>(a);
        int init = 0;
        int count = 1;
        int maxCount = 1;

        for (int i = 0; i < set.Count; i++)
        {
            if (!set.Contains(a[i] - 1))
            {
                init = a[i];
                while (set.Contains(++init))
                {
                    count = count + 1;
                }
                maxCount = Math.Max(count, maxCount);
                count = 1;
            }
        }
        Console.WriteLine(maxCount);
    }
    public static void FindLongestConsecutiveSequenceBetter(int[] a)
    {

        Array.Sort(a);
        int count = 1;
        int maxCount = 1;
        for (int i = 0; i < a.Length - 1; i++)
        {
            if (a[i] + 1 == a[i + 1])
            {
                count++;
                maxCount = Math.Max(count, maxCount);
            }
            else
            {
                count = 1;
            }
        }
        Console.WriteLine(maxCount);
    }
}