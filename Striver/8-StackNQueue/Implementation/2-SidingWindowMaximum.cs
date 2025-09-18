namespace StackNQueue.Implementation;

public class SlidingWindowMaximum
{
    public static void Brute()
    {
        int[] a = { 4, 0, -1, 3, 5, 3, 6, 8 };
        int k = 3;
        Naive(a, k); /* TC - O(N-K) * O(K)  => ~O(n*k)
                        SC - O(N-K+1) */
        Optimal(a, k); /* TC - O(2N)
                          SC - O(K) + O(N-K+1) */
    }
    private static void Naive(int[] a, int k)
    {
        int[] maxes = new int[a.Length - k + 1];
        for (int i = 0; i <= a.Length - k; i++)
        {
            int max = int.MinValue;
            for (int j = i; j < k + i; j++)
            {
                max = Math.Max(max, a[j]);
            }
            maxes[i] = max;
        }
        Console.WriteLine(string.Join(", ", maxes));
    }

    // Dequeue
    private static void Optimal(int[] a, int k)
    {
        LinkedList<int> deque = new(); // SC : O(K)
        List<int> res = new(); // SC : O(N - K + 1)
        for (int i = 0; i < a.Length; i++) // TC : O(N)
        {
            if (deque.Count > 0 && deque.First() <= i - k)
            {
                deque.RemoveFirst(); // 1
            }
            while (deque.Count > 0 && a[i] > a[deque.Last()])
            {
                deque.RemoveLast(); // 2 => 1 + 2 = TC O(N)
            }
            deque.AddLast(i);
            if (i >= k - 1)
            {
                res.Add(a[deque.First()]);
            }

        }
        Console.WriteLine(string.Join(", ", res));
    }
}
