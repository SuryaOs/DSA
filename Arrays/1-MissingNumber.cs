namespace dsaproblem.Arrays;

public class MissingNumber
{
    // 1, 2, 3, 4, 6
    // 1 + 2 + 3 + 4 + 6 = 21

    public static void FindMissingNumber(int[] a, int n)
    {
        int totalSum = a[0];
        for(int i = 0; i < n-1; i++)
        {
           totalSum += i;
           totalSum-= a[i];
        }
        Console.WriteLine($"Missing Number is {totalSum}");
    }
}