namespace StackNQueue.PreInPost;

public class PrefixToInfix
{
    public static void Brute()
    {
        string s = "++x/*yzwu";
        Console.WriteLine(PreToInRev(s));
        Console.WriteLine(PreToIn(s));
    }
    public static string PreToIn(string s)
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
                var newString = $"({A}{s[i]}{B})";
                st.Push(newString);
            }
        }
        return st.Pop();
    }
    public static string PreToInRev(string s)
    {
        var reversedString = InfixToPrefix.Reverse(s);
        var inString = PostfixToInfix.PostToIn(reversedString);
        return InfixToPrefix.Reverse(inString);
    }
}