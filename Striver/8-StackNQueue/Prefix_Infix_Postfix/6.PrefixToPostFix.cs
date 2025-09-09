namespace StackNQueue.PreInPost;

public class PrefixToPostfix
{
    public static void Brute()
    {
        string s = "/-ab*+def";
        Console.WriteLine(PostToPre(s));

    }
    public static string PostToPre(string s)
    {
        Stack<string> st = new();
        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] >= 'a' && s[i] <= 'z')
            {
                st.Push(s[i].ToString());
            }
            else
            {
                var A = st.Pop();
                var B = st.Pop();
                var newString = $"{A}{B}{s[i]}";
                st.Push(newString);
            }
        }
        return st.Peek();
    }
}