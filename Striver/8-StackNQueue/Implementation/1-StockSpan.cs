namespace StackNQueue.Implementation;

public class StockSpan
{
    public static void Brute()
    {
        int[] a = { 15, 13, 12, 14, 16, 20 };
        Console.WriteLine(string.Join(", ", Naive(a)));

    }
    public static int[] Naive(int[] a)
    {
        int[] res = new int[a.Length];
        Stack<int> st = new();
        for (int i = 0; i < a.Length; i++)
        {
            while (st.Count > 0 && a[st.Peek()] < a[i])
            {
                st.Pop();
            }
            res[i] = st.Count == 0 ? i + 1 : i - st.Peek();
            st.Push(i);
        }
        return res;
    }
}