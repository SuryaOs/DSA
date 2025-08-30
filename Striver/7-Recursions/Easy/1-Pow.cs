namespace Recursions.Easy;

public class MyPow
{
    public static void Brute(double x, int n)
    {
        Console.WriteLine(Pow(2.5, 2));
        // - => res/=2;
        // + => res*=2;
    }

    // Not Recursion But Exponentiation
    public static double Pow(double x, int n)
    {
        double res = 1.0000;
        int m = n;
        if (n < 0) { n = -n; }
        while (n > 0)
        {
            if (n % 2 != 0)
            {
                res = res * x;
                n = n - 1;
            }
            n = n / 2;
            x = x * x;
        }
        if (m < 0)
        {
            res = 1.0 / res;
        }
        return res;
    }
}