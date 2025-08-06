namespace dsaproblem.Striver.Strings.Easy;

public class ReverseEveryWord
{
    public static void Brute(string s)
    {
        string ans = "";
        string newAns = "";
        for (int i = 0; i < s.Length; i++)
        {
            newAns += s[i];
            if (s[i] == ' ')
            {
                ans = newAns + ans;
                newAns = "";
            }
        }
        Console.WriteLine(ans);
    }
}
