namespace StackNQueue.MonotonicStack;

public class LargestRectangleInHistogram
{
    public static void Brute()
    {
        int[] a = { 3, 5, 1, 7, 5, 9 };
        Console.WriteLine(Naive(a)); // TC O(5N), SC O(4N)
        Console.WriteLine(Medium(a)); // TC O(3N), SC O(3N)
    }
    private static int Naive(int[] a)
    {
        int largest = -1;
        var psI = PSE(a); // O(2N), SC : o(2n)
        var nsI = NSE(a); // O(2N), SC : o(2n)
        for (int i = 0; i < a.Length; i++) // O(N)
        {
            int sum = (nsI[i] - psI[i] - 1) * a[i];
            largest = Math.Max(sum, largest);
        }
        return largest;
    }
    private static int Medium(int[] a)
    {
        int largest = -1;
        Stack<int> st = new();
        var nsI = NSE(a);
        for (int i = 0; i < a.Length; i++)
        {
            while (st.Count > 0 && a[st.Peek()] > a[i])
            {
                st.Pop();
            }
            var psI = st.Count == 0 ? a.Length : st.Peek();
            int sum = (nsI[i] - psI - 1) * a[i];
            largest = Math.Max(sum, largest);
            st.Push(i);
        }
        return largest;
    }
    private static int[] PSE(int[] a)
    {
        int[] res = new int[a.Length]; // sc o(n)
        Stack<int> st = new(); // sc o(n)
        for (int i = 0; i < a.Length; i++) //O(N)
        {
            while (st.Count > 0 && a[st.Peek()] > a[i]) //O(N)
            {
                st.Pop();
            }
            res[i] = st.Count == 0 ? -1 : st.Peek();
            st.Push(i);
        }
        return res;
    }
    private static int[] NSE(int[] a)
    {
        int[] res = new int[a.Length];
        Stack<int> st = new();
        for (int i = a.Length - 1; i > 0; i--)
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
}