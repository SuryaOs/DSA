namespace dsaproblem.Striver.Arrays.Medium;

public class MaxSubArraySum
{
    // Accidentally I wrote Best Optimal Solution on First Try ( I never ever heard of this Kadanes Algorithm )
    // August 6 :D
    public static void SumOptimal(int[] a)
    {
        int sum = 0;
        int currentSum = 0;

        int startIndex = 0;
        int endIndex = 0;
        for (int i = 0; i < a.Length; i++)
        {
            currentSum += a[i];
            if (currentSum > sum)
            {
                sum = currentSum;
                endIndex = i;
            }
            if (currentSum < 0)
            {
                startIndex = i+1;
                currentSum = 0;
            }
        }
        Console.WriteLine($"Sum is {sum}, Subarray starts from {startIndex} to {endIndex}");
    }
    // This code is useful to understand on how to find sub arrays of arrays
    public static void Sum(int[] a)
    {
        int maxSum = int.MinValue;
        for (int i = 0; i < a.Length; i++)
        {
            for (int j = i; j < a.Length; j++)
            {
                int sum = 0;
                for (int k = i; k <= j; k++)
                {
                    sum += a[k];
                    Console.Write(" K Index " + k);
                }
                Console.WriteLine();
                if (sum > maxSum)
                {
                    maxSum = sum;
                    // Console.WriteLine("I Index " + i + " J index " + j);
                }
            }
        }

        Console.WriteLine(maxSum);
    }

    public static void SumBetter(int[] a)
    {
        int maxSum = int.MinValue;
        for (int i = 0; i < a.Length; i++)
        {
            int sum = 0;
            for (int j = i; j < a.Length; j++)
            {
                sum += a[j];
                if (sum > maxSum)
                    maxSum = sum;
                Console.WriteLine("I Index " + i + " J index " + j);
            }
        }
        Console.WriteLine(maxSum);
    }
}