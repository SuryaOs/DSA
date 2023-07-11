namespace dsaproblem.Striver.BasicMaths;

public class PrimeNumber
{
    public static void print(int n)
    {
        int count = 0;
    // 1, 2 is Prime i dint inckyde this ok
        for (int i = 2; i * i < n; i++)
        {
            if (n % i == 0)
            {
                count++;
            }
        }
        if (count == 0)
        {
            Console.WriteLine("Prime");
        }
    }
}