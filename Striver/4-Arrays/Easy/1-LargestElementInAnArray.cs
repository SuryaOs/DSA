namespace dsaproblem.Striver.Arrays.Easy;

public class LargestElementInAnArray
{
    //Brute 
    // 1) Sort the element (Sort - (Merge, Quick) TC - o(n log n) SC - o(1))
    // 2) Last Element is the largest

    //This is optimal
    // TC - o(n) , SC - o(1)
    public static void FindLargestBrute(int[] a)
    {
        int max = a[0];
        for (int i = 1; i < a.Length - 1; i++)
        {
            if (a[i] > max)
                max = a[i];
        }
        Console.WriteLine($"The largest element is {max}");
    }

}