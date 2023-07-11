namespace dsaproblem.Recursions.Basics;

public class SumOfNNumber
{
    public static void print(int sum, int i, int n)
    {
        if (i > n)
        {
            Console.WriteLine(sum);
            return;
        }

        sum += i;
        print(sum, i + 1, n);
    }

    public static void print(int sum, int n)
    {
        if (n < 1)
        {
            Console.WriteLine(sum);
            return;
        }

        sum += n;
        print(sum, n - 1);
    }

    public static int print(int n)
    {
        if (n == 0)
        {
            return 0;
        }

        return n + print(n - 1);
    }

    public static void printOne()
    {
        Console.WriteLine(print(5));
    }
}