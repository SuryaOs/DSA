namespace dsaproblem.Striver.BasicMaths;

public class PrintAllDivisors
{
    public static void print(int n) {
        int index = (int)Math.Sqrt(n);
        List<int> num = new();

        for(int i = 1; i <= index; i++)
        {
            if(n % i == 0)
            {
                int j = n/i;
                num.Add(i);
                if(j != i)
                num.Add(j);
            }
        }
        Console.WriteLine(string.Join(", ", num));
    }
}