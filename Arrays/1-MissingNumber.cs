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
            Console.WriteLine($"I is {i}");
           totalSum += i;
        Console.WriteLine($"Add is {totalSum}");
           totalSum-= a[i];
           Console.WriteLine($"Minus is {totalSum}");
        }
        Console.WriteLine($"Missing Number is {totalSum}");
    }
}