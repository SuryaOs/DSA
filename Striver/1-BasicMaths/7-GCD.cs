namespace dsaproblem.Striver.BasicMaths;

public class GCD
{
    //Euclidean Thearom = GCD(A, B) = GCD(A-B, B) = GCD(20, 15) = GCD=(5, 15) = GCD(10, 5) = GCD(5, 0) 
    public static void print(int n1, int n2)
    {
        int index = n1 < n2 ? n1 : n2;
        int gcd = 1;
        for (int i = 2; i <= index; i++)
        {
            if (n1 % i == 0 && n2 % i == 0)
            {
                gcd = i;
            }
        }
        Console.WriteLine(gcd);
    }
    public static void printC(int n1, int n2)
    {
        int index = n1 < n2 ? n1 : n2;
        int gcd = 1;
        for (int i = index; i > 1; i--)
        {
            if (n1 % i == 0 && n2 % i == 0)
            {
                gcd = i;
                break;
            }
        }
        Console.WriteLine(gcd);
    }
}