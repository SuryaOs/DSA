namespace StackNQueue.PreInPost;

public class InfixToPostFix
{
    public static void Brute()
    {
        string s = "a+b*(c^d-e)^(f+g*h)-i";
        // s = "(p+q)*(m-n)";
        Console.WriteLine(InTopost(s));
    }
    public static string InTopost(string s)
    {
        string ans = "";
        Stack<char> st = new();
        foreach (char c in s)
        {
            if (c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z' || c >= 0 && c <= 9)
            {
                ans += c;
            }
            else if (c == '(')
            {
                st.Push(c);
            }
            else if (c == ')')
            {
                while (st.Peek() != '(')
                {
                    ans += st.Pop();
                }
                st.Pop();
            }
            else
            {
                while (st.Count > 0 && Priority(c) <= Priority(st.Peek()))
                {
                    ans += st.Pop();
                }
                st.Push(c);
            }
        }
        while (st.Count > 0)
        {
            ans += st.Pop();
        }
        return ans;
    }
    public static int Priority(char a)
    {
        if (a == '^') return 3;
        else if (a == '*' || a == '/') return 2;
        else if (a == '+' || a == '-') return 1;
        else return -1;
    }

}