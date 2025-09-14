namespace StackNQueue.MonotonicStack;

public class SumOfSubArrayMaximum
{
    public static void Brute()
    {
        int[] a = { 1, 4, 3, 2 };
        Medium(a);
        Console.WriteLine(Optimal(a));

    }
    public static int Optimal(int[] a)
    {
        int total = 0;
        var ngIndex = NGE(a);
        var pgIndex = PGE(a);
        for (int i = 0; i < a.Length; i++)
        {
            total += a[i] * (ngIndex[i] - i) * (i - pgIndex[i]);
        }
        return total;
    }
    private static int[] NGE(int[] a)
    {
        int[] res = new int[a.Length];
        Stack<int> st = new();
        for (int i = a.Length - 1; i >= 0; i--)
        {
            while (st.Count > 0 && a[st.Peek()] <= a[i])
            {
                st.Pop();
            }
            res[i] = st.Count == 0 ? a.Length : st.Peek();
            st.Push(i);
        }
        return res;
    }
    private static int[] PGE(int[] a)
    {
        int[] res = new int[a.Length];
        Stack<int> st = new();
        for (int i = 0; i < a.Length; i++)
        {
            while (st.Count > 0 && a[st.Peek()] < a[i])
            {
                st.Pop();
            }
            res[i] = st.Count == 0 ? -1 : st.Peek();
            st.Push(i);
        }
        return res;
    }
    private static void Medium(int[] a)
    {
        int sum = 0;
        for (int i = 0; i < a.Length; i++)
        {
            int max = -1;
            for (int j = i; j < a.Length; j++)
            {
                max = Math.Max(max, a[j]);
                sum += max;
            }
        }
        Console.WriteLine(sum);
    }
}