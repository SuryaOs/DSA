using System.Text;

namespace StackNQueue.MonotonicStack;

public class RemoveKDigits
{
    public static void Brute()
    {
        string s = "1432219";
        s = "541892";
        s = "123456";
        int k = 3;
        Naive(s, k);
        // Medium(s, k);
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
            while (st.Count > 0 && k > 0 && (st.Peek() - '0' > s[i] - '0'))
            {
                st.Pop();
                k--;
            }
            st.Push(s[i]);
        }

        #region Edge case for string 123456 => Pop K Elements Out
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
        #region  edge case 298100 => before reversing remove the zeroes at the end.
        int z = sb.Length - 1;
        while (z > 0 && sb[z] == 0)
        {
            z--;
        }
        string res = sb.ToString().Substring(0, z + 1);
        #endregion

        if (string.IsNullOrEmpty(res)) return "0";

        return new string(res.Reverse().ToArray()); // Ik In Built, but fine

    }
}

