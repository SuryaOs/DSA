namespace StackNQueue.MonotonicStack;

public class NextSmallerElement
{
    public static void Brute()
    {
        int[] a = { 10, 9, 8, 7 };
        var res = string.Join(", ", Optimal(a));
        Console.WriteLine(res);
    }
    public static int[] Optimal(int[] a)
    {
        int[] res = new int[a.Length];
        Stack<int> st = new();
        for (int i = a.Length - 1; i >= 0; i--)
        {
            while (st.Count > 0 && a[i] < st.Peek())
            {
                st.Pop();
            }
            res[i] = st.Count == 0 ? -1 : st.Peek();
            st.Push(a[i]);
        }
        return res;
    }
}