namespace dsaproblem.Striver.Arrays.Hard;

public class PascalTriangle
{
    // formula for pascal triangle => nCr => n!/r!s(n-r)!
    // Find n row r column
    public static void NCR(int n, int r)
    {
        int result = 1;
        for (int i = 1; i < r; i++)
        {
            result *= n - i;
            result /= i;
        }
        Console.WriteLine(result);
    }
    // Print nth row
    public static void PrintNCR(int n)
    {
        int result = 1;
        Console.Write(result);
        for (int i = 1; i < n; i++)
        {
            result *= n - i;
            result /= i;
            Console.Write(result);
        }
    }
    // Print Pascal for n rows
    public static void PrintPascal(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            int result = 1;
            Console.Write(result);
            for (int j = 1; j < i; j++)
            {
                result *= i - j;
                result /= j;
                Console.Write(result);
            }
            Console.WriteLine();
        }
    }
}