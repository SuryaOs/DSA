namespace StackNQueue.MonotonicStack;

public class NextGreaterElement
{
    public static void Brute()
    {
        int[] arr = { 4, 12, 5, 3, 1, 2, 5, 3, 1, 2, 4, 6 };
        Console.WriteLine(string.Join(", ", Naive(arr)));
        var ans = Optimal(arr);
        Console.WriteLine(string.Join(", ", ans));
    }
    public static List<int> Naive(int[] a)
    {
        var list = new List<int>();
        for (int i = 0; i < a.Length; i++)
        {
            for (int j = i + 1; j < a.Length; j++)
            {
                if (a[j] > a[i])
                {
                    list.Add(a[j]);
                    break;

                }
                if (j == a.Length - 1)
                {
                    list.Add(-1);
                }
            }
        }
        list.Add(-1);
        return list;
    }
    public static int[] Optimal(int[] a)
    {
        int[] res = new int[a.Length];
        Stack<int> st = new();
        for (int i = a.Length - 1; i >= 0; i--)
        {
            while (st.Count > 0 && a[i] >= st.Peek())
            {
                st.Pop();
            }
            if (st.Count == 0)
            {
                res[i] = -1;
            }
            else
            {
                res[i] = st.Peek();
            }
            st.Push(a[i]);
        }
        return res;
    }
}