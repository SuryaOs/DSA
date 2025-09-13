namespace StackNQueue.MonotonicStack;

public class SumOfSubArrayMinimum
{
    public static void Brute()
    {
        int[] a = { 1, 4, 6, 7, 3, 7, 8, 1 };
        Console.WriteLine(Naive(a));
        Console.WriteLine(Medium(a));
        Console.WriteLine(Optimal(a));
    }
    // ans => -1 
    // st => 3
    public static int Optimal(int[] a)
    {
        int[] ngIndex = NSE(a);
        int[] psIndex = PSE(a);
        int total = 0;
        for (int i = 0; i < a.Length; i++)
        {
            total += a[i] * (i - ngIndex[i]) * (psIndex[i] - i);
        }
        return total;
    }
    private static int[] NSE(int[] a)
    {
        int[] res = new int[a.Length];
        Stack<int> st = new();
        for (int i = a.Length - 1; i >= 0; i--)
        {
            while (st.Count > 0 && a[st.Peek()] >= a[i])
            {
                st.Pop();
            }
            res[i] = st.Count == 0 ? a.Length : st.Peek();
            st.Push(i);
        }
        return res;
    }
    private static int[] PSE(int[] a)
    {
        int[] res = new int[a.Length];
        Stack<int> st = new();
        for (int i = 0; i < a.Length; i++)
        {
            while (st.Count > 0 && a[st.Peek()] > a[i])
            {
                st.Pop();
            }
            res[i] = st.Count == 0 ? -1 : st.Peek();
            st.Push(i);
        }
        return res;
    }
    public static int Naive(int[] a)
    {
        int sum = 0;
        for (int i = 0; i < a.Length; i++)
        {
            for (int j = i; j < a.Length; j++)
            {
                int min = int.MaxValue;
                for (int k = i; k <= j; k++)
                {
                    min = Math.Min(min, a[k]);
                }
                sum += min;
            }
        }
        return sum;
    }
    public static int Medium(int[] a)
    {
        int sum = 0;
        for (int i = 0; i < a.Length; i++)
        {
            int min = a[i];
            for (int j = i; j < a.Length; j++)
            {
                min = Math.Min(min, a[j]);
                sum += min;
            }
        }
        return sum;
    }
}