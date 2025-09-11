namespace StackNQueue.MonotonicStack;

public class PreviousSmallerElement
{
    public static void Brute()
    {
        int[] a = { 4, 5, 2, 10, 8 };
        var res = string.Join(", ", Optimal(a));
        Console.WriteLine(res);
    }
    public static int[] Optimal(int[] a)
    {
        int[] res = new int[a.Length];
        Stack<int> st = new();
        for (int i = 0; i < a.Length; i++)
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