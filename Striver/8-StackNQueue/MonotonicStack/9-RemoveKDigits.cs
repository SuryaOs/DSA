using System.Text;

namespace StackNQueue.MonotonicStack;

public class RemoveKDigits
{
    public static void Brute()
    {
        string s = "1432219";
        s = "54001892";
        // s = "123456";
        s = "1002991";
        int k = 3;
        // Naive(s, k);
        Console.WriteLine(MediumWithEdgeCase(s, k));
    }

    // according to chat gpt Naive is error prone, Medium follows Greedy algorithm
    public static void Naive(string s, int k)
    {
        Stack<char> st = new();
        string ans = "";
        for (int i = 0; i < s.Length; i++)
        {
            if (st.Count < k && i < s.Length - 1 && s[i] > s[i + 1])
            {
                st.Push(s[i]);
            }
            else
            {
                ans += s[i];
            }
        }
        if (st.Count < k)
        {
            ans = ans.Remove(ans.Length - k, k);
        }
        Console.WriteLine(ans);
    }
    public static string Medium(string s, int k)
    {
        Stack<char> st = new();
        StringBuilder sb = new();
        for (int i = 0; i < s.Length; i++)
        {
            while (st.Count > 0 && k > 0 && st.Peek() > s[i])
            {
                st.Pop();
                k--;
            }
            st.Push(s[i]);
        }
        while (st.Count > 0)
        {
            sb.Append(st.Pop());
        }
        // reverse
        return new String(sb.ToString().Reverse().ToArray());
    }
    public static string MediumWithEdgeCase(string s, int k)
    {
        Stack<char> st = new();
        StringBuilder sb = new();
        for (int i = 0; i < s.Length; i++)
        {
            while (st.Count > 0 && k > 0 && st.Peek() > s[i])
            {
                st.Pop();
                k--;
            }
            st.Push(s[i]);
        }
        #region for 123456, the while block will never pop
        while (k > 0)
        {
            st.Pop();
            k--;
        }
        #endregion
        if (st.Count == 0) return "0";
        while (st.Count > 0)
        {
            sb.Append(st.Pop());
        }
        #region for 54001892, the starting zeros should be
        int z = sb.Length - 1;
        while (z > 0 && sb[z] == '0')
        {
            z--;
        }
        string res = sb.ToString().Substring(0, z + 1);
        #endregion
        if (string.IsNullOrEmpty(res)) return "0";
        // reverse
        return new String(res.Reverse().ToArray());
    }
}

