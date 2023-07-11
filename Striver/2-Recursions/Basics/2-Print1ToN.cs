namespace dsaproblem.Recursions.Basics;

public class Print1ToN
{
    public static void print(int i, int n)
    {
        if (i > n)
            return;

        Console.WriteLine(i);
        print(i + 1, n);
    }
}