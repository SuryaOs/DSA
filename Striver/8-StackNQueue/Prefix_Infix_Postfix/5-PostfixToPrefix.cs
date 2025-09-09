namespace StackNQueue.PreInPost;

// Naive Approach => Post To In , In To Pre
public class PostfixToPrefix
{
    public static void Brute()
    {
        string s = "ab-de+f*/";
        Console.WriteLine(PostToPre(s));
    }
    public static string PostToPre(string s)
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
                var A = st.Pop();
                var B = st.Pop();
                var newString = $"{s[i]}{B}{A}";
                st.Push(newString);
            }
        }
        return st.Peek();
    }
}