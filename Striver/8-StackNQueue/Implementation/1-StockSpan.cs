namespace StackNQueue.Implementation;

public class StockSpan
{
    public static void Brute()
    {
        int[] a = { 7, 2, 1, 3, 3, 1, 8 };
        Console.WriteLine(string.Join(", ", Naive(a)));
        StockSpanner sp = new();
        sp.Next(7); // 1
        sp.Next(2); // 1
        sp.Next(1); // 1
        sp.Next(3); // 3
        sp.Next(3); // 4
        sp.Next(1); // 1
        sp.Next(8); // 7

    }
    // this is core logic but seems we need to build algorithm
    public static int[] Naive(int[] a)
    {
        int[] res = new int[a.Length];
        Stack<int> st = new();
        for (int i = 0; i < a.Length; i++)
        {
            while (st.Count > 0 && a[st.Peek()] <= a[i])
            {
                st.Pop();
            }
            res[i] = st.Count == 0 ? i + 1 : i - st.Peek();
            st.Push(i);
        }
        return res;
    }
}
public class StockSpanner
{
    Stack<KeyValuePair<int, int>> stack = new();
    int index = -1;
    public int Next(int price)
    {
        index += 1;
        while (stack.Count > 0 && stack.Peek().Value <= price)
        {
            stack.Pop();
        }
        int span = index - (stack.Count == 0 ? -1 : stack.Peek().Key);
        stack.Push(new KeyValuePair<int, int>(index, price));
        Console.WriteLine(span);
        return span;
    }
}