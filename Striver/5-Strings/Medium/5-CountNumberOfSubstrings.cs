namespace dsaproblem.Striver.Strings.Medium;

public class CountNumberOfSubstrings
{
    public static void Brute(string s)
    {
        s = "abc"; // 0 01 012 11 12 2
        int count = 0;
        for (int i = 0; i < s.Length; i++)
        {
            string sub = "";
            for (int j = i; j < s.Length; j++)
            {
                sub += s[j];
                count++;
                Console.WriteLine(sub);
            }
        }
        Console.WriteLine(count);
    }
    public static void Optimal(string s)
    {
        int n = s.Length;
        int countOfSubstrings = (n * (n + 1) / 2) + 1;
        int subsetCount = 2 ^ n;
    }
}
