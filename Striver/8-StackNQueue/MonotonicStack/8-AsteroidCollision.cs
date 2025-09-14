namespace StackNQueue.MonotonicStack;

public class AsteroidCollision
{
    public static void Brute()
    {
        int[] a = { -8, 8 };
        Naive(a);
    }

    // first try
    // second try - 
    //      replaced stack with list to preserve order and
    //      commented last if condition
    public static void Naive(int[] a)
    {
        // Stack<int> st = new();
        List<int> st = new();
        for (int i = 0; i < a.Length; i++)
        {
            // if positive elements || stack is Empty just push it
            if (a[i] > 0 || st.Count == 0)
            {
                st.Add(a[i]);
            }
            else if (st.Count > 0)
            {
                // if st has value && top element is positive && topElem is lesser abs[a[i]] => destory top elem
                while (st.Count > 0 && st[^1] > 0 && st[^1] < -a[i])
                {
                    st.RemoveAt(st.Count - 1);
                }
                // if st has values and top element == abs[a[i]] destroy both
                if (st.Count > 0 && st[^1] == -a[i])
                {
                    st.RemoveAt(st.Count - 1);
                }
                // if stack is empty OR if top element is negative
                if (st.Count == 0 || st[^1] < 0)
                {
                    st.Add(a[i]);
                }
                // if st has values && top element is greater than abs[a[i]] continue
                // if (st.Count > 0 && st.Peek() > -a[i])
                // {
                //     continue;
                // }
            }
        }
        Console.WriteLine(string.Join(", ", st));
    }

}