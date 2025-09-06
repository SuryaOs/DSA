using Helper = StackNQueue.PreInPost.InfixToPostFix;
namespace StackNQueue.PreInPost;

public class InfixToPrefix
{
    public static void Brute()
    {
        string s = "x+y*z/w+u";
        // Console.WriteLine(InToPre(s));
        Console.WriteLine(InToPreRev(s));
    }

    // my approach SEEMS to be working fine, not sure if there are any edge cases
    private static string InToPre(string s)
    {
        Stack<char> st = new();
        string ans = "";
        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] >= 'a' && s[i] <= 'z')
            {
                ans = s[i] + ans;
            }
            else if (s[i] == ')')
            {
                st.Push(s[i]);
            }
            else if (s[i] == '(')
            {
                while (st.Peek() != ')')
                {
                    ans = st.Pop() + ans;
                }
                st.Pop();
            }
            else
            {
                while (st.Count > 0 && Helper.Priority(st.Peek()) > Helper.Priority(s[i]))
                {
                    ans = st.Pop() + ans;
                }
                st.Push(s[i]);
            }
        }
        while (st.Count > 0)
        {
            ans = st.Pop() + ans;
        }
        return ans;
    }
    public static string InToPreRev(string s)
    {
        string reversedString = Reverse(s);
        Stack<char> st = new();
        string ans = "";
        foreach (char c in reversedString)
        {
            if (c >= 'a' && c <= 'z')
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
                while (st.Count > 0 && Helper.Priority(c) < Helper.Priority(st.Peek()))
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
        return Reverse(ans);
    }
    private static string Reverse(string s)
    {
        char[] cA = s.ToCharArray();
        int i = 0;
        int j = cA.Length - 1;
        while (i < j)
        {
            char temp = cA[i];
            cA[i] = cA[j] == '(' ? ')' : cA[j] == ')' ? '(' : cA[j];
            cA[j] = temp == '(' ? ')' : temp == ')' ? '(' : temp;
            i++;
            j--;
        }

        return new string(cA);
    }
}