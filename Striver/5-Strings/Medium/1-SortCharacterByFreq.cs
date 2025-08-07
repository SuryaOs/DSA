using System.Text;

namespace dsaproblem.Striver.Strings.Medium;

public class SortCharacterByFreq
{
    public static void Brute(string s)
    {
        Dictionary<char, int> dic = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++)
        {
            if (dic.ContainsKey(s[i]))
                dic[s[i]]++;
            else
                dic[s[i]] = 1;
        }
        var bucket = new List<char>[s.Length];
        for (int i = 0; i < bucket.Length; i++)
        {
            bucket[i] = new List<char>();
        }
        foreach (var kv in dic)
        {
            bucket[kv.Value].Add(kv.Key);
        }
        StringBuilder sb = new();
        for (int i = bucket.Length - 1; i >= 0; i--)
        {
            foreach (char c in bucket[i])
            {
                sb.Append(c, i);
            }
        }
        Console.WriteLine(sb.ToString());
    }
}
