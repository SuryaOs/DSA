namespace StackNQueue.MonotonicStack;

public class LargestRectangleInHistogram
{
    public static void Brute()
    {
        int[] a = { 3, 2, 10, 11, 5, 10, 6, 3 };
        Console.WriteLine(Naive(a)); // TC 5*O(N), SC 5*O(N)
        Console.WriteLine(Medium(a)); // TC 3*O(N), SC 3*O(N)
        Console.WriteLine(Optimal(a)); // TC 2*O(N), SC O(N)
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
    public static int Optimal(int[] a)
    {
        Stack<int> st = new(); // SC O(N)
        int largest = -1;
        for (int i = 0; i < a.Length; i++) // TC O(N)
        {
            while (st.Count > 0 && a[st.Peek()] > a[i])
            {
                int j = st.Pop(); // TC O(N)
                int nse = i;
                int pse = st.Count == 0 ? -1 : st.Peek();
                int sizeofrectangle = (nse - pse - 1) * a[j];
                largest = Math.Max(largest, sizeofrectangle);
            }
            st.Push(i);
        }
        while (st.Count > 0)
        {
            int i = st.Pop();
            int pse = st.Count == 0 ? -1 : st.Peek();
            int nse = a.Length;
            int sizeofrectangle = (nse - pse - 1) * a[i];
            largest = Math.Max(largest, sizeofrectangle);
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