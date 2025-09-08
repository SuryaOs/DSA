namespace StackNQueue.PreInPost;

public class PostfixToInfix
{
    public static void Brute()
    {
        string s = "pq+mn-*";
        s = "abcd^e-fgh*+^*+i-";
        Console.WriteLine(PostToIn(s));
    }
    public static string PostToIn(string s)
    {
        Stack<string> st = new();
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] >= 'a' && s[i] <= 'z')
            {
                st.Push(s[i].ToString());
            }
            else
            {
                string A = st.Pop();
                string B = st.Pop();
                string ans = $"({B}{s[i]}{A})";
                st.Push(ans);
            }
        }
        return st.Peek();
    }
}
