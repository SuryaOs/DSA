using System.Security.Principal;

namespace StackNQueue.MonotonicStack;

public class NextGreaterElementCircular
{
    public static void Brute()
    {
        int[] a = { 2, 10, 12, 1, 11 };
        Console.WriteLine(string.Join(", ", Naive(a)));
        Console.WriteLine(string.Join(", ", Medium(a)));
        Console.WriteLine(string.Join(", ", Optimal(a)));
    }
    // This is worst , ignore it during revision 
    public static List<int> Naive(int[] a)
    {
        List<int> res = new();
        int j = 0;
        int i = 0;
        while (i < a.Length - 1)
        {
            j = i + 1;
            while (j < a.Length - 1)
            {
                if (a[j] > a[i])
                {
                    res.Add(a[j]);
                    break;
                }
                j++;
            }
            if (j == a.Length - 1)
            {
                j = 0;
                while (j < i)
                {
                    if (a[j] > a[i])
                    {
                        res.Add(a[j]);
                        break;
                    }
                    j++;
                }
            }
            if (j == i)
            {
                res.Add(-1);
            }
            i++;
        }
        if (i == a.Length - 1)
        {
            j = 0;
            while (j < i)
            {
                if (a[j] > a[i])
                {
                    res.Add(a[j]);
                    break;
                }
                j++;
            }
        }
        return res;
    }
    public static List<int> Medium(int[] a)
    {
        List<int> list = new();
        for (int i = 0; i < a.Length; i++)
        {
            for (int j = i + 1; j < a.Length - 1 + i; j++)
            {
                int index = j % (a.Length - 1);
                if (a[index] >= a[i])
                {
                    list.Add(a[index]);
                    break;
                }
            }
            if (list.Count == i)
                list.Add(-1);
        }
        return list;
    }

    // Optimal is correct others need bit correction
    // Commented code is unfactored but correct result
    public static int[] Optimal(int[] a)
    {
        int n = a.Length;
        int[] ans = new int[n];
        Stack<int> st = new();
        for (int i = (2 * n) - 1; i >= 0; i--)
        {
            while (st.Count > 0 && a[i % n] >= st.Peek())
            {
                st.Pop();
            }
            if (i < n)
            {
                ans[i] = st.Count == 0 ? -1 : st.Peek();
            }
            st.Push(a[i % n]);

            // if (i >= n)
            // {
            //     int index = i % n;
            //     if (st.Count == 0)
            //     {
            //         st.Push(a[index]);
            //     }
            //     else if (st.Peek() > a[index])
            //     {
            //         st.Push(a[index]);
            //     }
            //     else
            //     {
            //         while (st.Count > 0 && a[index] > st.Peek())
            //         {
            //             st.Pop();
            //         }
            //         st.Push(a[index]);
            //     }
            // }
            // else
            // {
            //     if (st.Peek() > a[i])
            //     {
            //         ans[i] = st.Peek();
            //         st.Push(a[i]);
            //     }
            //     else
            //     {
            //         while (st.Count > 0 && a[i] >= st.Peek())
            //         {
            //             st.Pop();
            //         }
            //         if (st.Count == 0)
            //         {
            //             ans[i] = -1;
            //         }
            //         else
            //             ans[i] = st.Peek();
            //         st.Push(a[i]);
            //     }
            // }
        }
        return ans;
    }
}