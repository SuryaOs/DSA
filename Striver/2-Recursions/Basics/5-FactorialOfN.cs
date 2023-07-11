namespace dsaproblem.Recursions.Basics;

public class FactorialOfN
{
    public static int Factorial(int n)
    {
        if(n == 1)
        {
            return 1;
        }
        return n * Factorial(n - 1);
    }
    public static void print(int n){
        Console.WriteLine(Factorial(n));
    }
}