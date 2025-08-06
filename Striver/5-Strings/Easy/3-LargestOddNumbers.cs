namespace dsaproblem.Striver.Strings.Easy;

public class LargestOddNumbers
{
    public static void Brute(string s)
    {
        string ans = "";
        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] % 2 == 1)
            {
                ans = s.Substring(0, i + 1);
                break;
            }
        }
        Console.WriteLine(ans);
    }
}
