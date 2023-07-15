using System.Security.Cryptography;
namespace dsaproblem.Striver.Recursions.Basics;

public class Fibonacci
{
    //f(n) = f(n-1) + f(n-2)
    public static void Print(int n)
    {
        // FibBrute(n);
        // FibonacciNumber(0, 1, 5);
        FibStriver();

    }

    private static void FibBrute(int n)
    {
        int i = 0, j = 1;
        Console.Write(i + ", " + j);
        while (n > 0)
        {
            int sum = i + j;
            Console.Write(", " + sum);
            i = j;
            j = sum;
            n--;
        }
    }

    private static void FibonacciNumber(int i, int j,  int n)
    {
        if(n == 0) return;
        int sum = i + j;
        Console.Write(" - " + sum);
        FibonacciNumber(j, sum, n-1);
    }

    /* Striver To Print nth Finboncci Term */

    private static int FibonacciS(int n)
    {
        if(n <= 1)
        return n;
        return FibonacciS(n-1) + FibonacciS(n-2);
    }

    public static void FibStriver()
    {
        Console.WriteLine(FibonacciS(5));
    }
}