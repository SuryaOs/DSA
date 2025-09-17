namespace StackNQueue.MonotonicStack;

public class MaximalRectangle
{
    public static void Brute()
    {
        int[,] a = new int[,] {
            {1, 0, 1, 0, 0},
            {1, 0, 1, 1, 1},
            {1, 1, 1, 1, 1},
            {1, 0, 0, 1, 0}
        };
        Console.WriteLine(Naive(a)); // O(N*M) + O(N) SC = 2 O(N)
        Console.WriteLine(Optimal(a));
    }

    /*
        1) each row is a histpgram
        2) apply LRIH per row to get the max
    */
    public static int Optimal(int[,] a)
    {
        int row = a.GetLength(0); // 4
        int col = a.GetLength(1); // 5
        int[] height = new int[col];
        int max = -1;
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                if (a[i, j] == 0) height[j] = 0;
                else height[j] += 1;
            }
            int lrih = LargestRectangleInHistogram.Optimal(height);
            max = Math.Max(max, lrih);
        }
        return max;
    }
    /*
        1) For each column, sums all rows top to bottom
        2) builds singe sums[] array of size col
        3) treats that array as histogram and checks LRIH once
        4) problem : ignores row-wise histogram
        5) each row is a histogram
    */
    public static int Naive(int[,] a)
    {
        int row = a.GetLength(0); // 4 Rows
        int col = a.GetLength(1); // 5 Cols
        int[] sums = new int[col];
        int largest = -1;
        Stack<int> st = new();
        for (int i = 0; i < col; i++)
        {
            int sum = 0;
            for (int j = 0; j < row; j++)
            {
                sum += a[j, i];
            }
            sums[i] = sum;
            while (st.Count > 0 && sums[st.Peek()] > sums[i])
            {
                int index = st.Pop();
                int nsIndex = i;
                int psIndex = st.Count == 0 ? -1 : st.Peek();
                int width = (nsIndex - psIndex - 1) * sums[index];
                largest = Math.Max(largest, width);
            }
            st.Push(i);
        }
        while (st.Count > 0)
        {
            int index = st.Pop();
            int nsIndex = col;
            int psIndex = st.Count == 0 ? -1 : st.Peek();
            int width = (nsIndex - psIndex - 1) * sums[index];
            largest = Math.Max(largest, width);
        }
        return largest;
    }
}