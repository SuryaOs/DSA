namespace dsaproblem.Striver.Strings.Medium;

public class MaximumNestingDepthOfParantheses
{
    public static void Brute(string s)
    {
        int count = 0;
        int maxCount = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
                count++;
            else if (s[i] == ')')
            {
                maxCount = Math.Max(maxCount, count);
                count--;
            }
        }
        Console.WriteLine(maxCount);
    }
}
