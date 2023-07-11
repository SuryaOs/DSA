namespace dsaproblem.Striver.BasicMaths;

public class CountDigits
{
    public static void print(int n)
    {
        int count = 0;
        while (n > 0)
        {
            count++;
            n = n / 10;
        }
       Console.Write(count);
    }
}