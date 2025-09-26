namespace BinarySearch.Problems;

public class NthRoot
{
    public static void Run()
    {
        int a = 81;
        int n = 4;
        Console.WriteLine(Brute(a, n)); // 2 o (a * n)
        Console.WriteLine(Optimal(a, n)); // o(log a * log n)

    }
    private static int Brute(int a, int n)
    {
        for (int i = 1; i <= a; i++)
        {
            var res = Pow(i, n);
            if (res == a)
            {
                return i;
            }
            else if (res > a)
            {
                break;
            }
        }
        return -1;
    }
    private static int Optimal(int a, int n)
    {
        int low = 1;
        int high = a;
        while (low <= high)
        {
            int mid = (low + high) / 2;
            var res = PowOptimalluuu(mid, n, a);
            if (res == 2)
            {
                high = mid - 1;
            }
            else if (res == 1)
            {
                low = mid + 1;
            }
            else
            {
                return mid;
            }

        }
        return -1;
    }


    #region power exponentiation or Math.Pow();
    private static int Pow(int a, int n) // O(N)
    {
        int ans = 1;
        while (n-- > 0)
        {
            ans *= a;
        }
        return ans;
    }
    private static int PowOptimal(int mid, int n) // o log n
    {
        int ans = 1;
        int m = n;
        if (n < 0) m = -n;
        while (m > 0)
        {
            if (m % 2 != 1)
            {
                m -= 1;
                ans = ans * mid;
            }
            m /= 2;
            mid *= mid;
        }
        if (n < 0) ans = 1 / ans;
        return ans;
    }

    /*
        if n is 10^9 then (10^9)/2 * (10^9)/2 * ... will cause overflow exception
        so tweak it
        0 => ans == x;
        1 => ans < x;
        2 => ans > x;
    */
    private static int PowOptimalluuu(int mid, int n, int x)
    {
        int ans = 1;
        for (int i = 0; i < n; i++)
        {
            ans *= mid;
            if (ans > x) return 2;
        }
        return ans < x ? 1 : 0;
    }
    #endregion
}