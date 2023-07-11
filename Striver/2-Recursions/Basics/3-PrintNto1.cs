namespace dsaproblem.Recursions.Basics;

public class PrintNto1
{
    public static void print(int n)
    {
        if (n < 1)
            return;

        Console.WriteLine(n);
        print(n-1);
    }
}