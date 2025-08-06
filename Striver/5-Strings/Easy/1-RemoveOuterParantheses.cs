namespace dsaproblem.Striver.Strings.Easy;

public class RemoveOuterParantheses
{
    public static void Brute(string s)
    {
        Stack<char> c = new();
        string ans = "";
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
            {
                if (c.Count() != 0)
                    ans += s[i];
                c.Push(s[i]);
            }
            else
            {
                c.Pop();
                if (c.Count() != 0)
                    ans += s[i];
            }
        }
        Console.WriteLine(ans);
    }

    public static void Optimal(string s)
    {
        int count = 0;
        string ans = "";
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
            {
                if (count++ != 0)
                    ans += s[i];
            }
            else
            {
                if (--count != 0)
                    ans += s[i];
            }
        }
        Console.WriteLine(ans);
    }
}
