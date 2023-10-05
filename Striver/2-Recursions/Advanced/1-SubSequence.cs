using System.Text;

namespace dsaproblem.Striver.Recursions.Advanced;

public class SubSequence
{
    // Take - Not Take
    // i = 0 => take a[o] => recuse it till base => print return => don't take a[o] => print return 
    public static void SubSequenceRecursive(int i, int[] a, List<int> list) {
        if(i >= a.Length) { Console.WriteLine(string.Join(", ", list)); return; }

        list.Add(a[i]);
        SubSequenceRecursive(i + 1, a, list);
        list.Remove(a[i]);
        SubSequenceRecursive(i + 1, a, list);
    }

    // Bit Manipulation
    // Total Subsequence -> 2 Power n
    // To find if the kth(1) bit is set or not for n (5)
    // n & (1 << k) != 0 => Set else not set
    public static void SubSequenceBit(int[] a)
    {
        int n = a.Length;
        for(int i = 0; i < Math.Pow(2, n); i++)
        {
            StringBuilder sb = new();
            for(int j = 0; j < n; j++)
            {
                if((i & (1 << j)) != 0)
                {
                    sb.Append(a[j]);
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}