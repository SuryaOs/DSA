namespace dsaproblem.Recursions.Basics;

public class PrintNameNTimes
{
    public static void printname(int n, int i)
    {
        if (n < i)
            return;

        Console.WriteLine("Surya" + i);
        printname(n, i + 1);
    }
}