namespace dsaproblem.Striver.Arrays.Medium;

// 1, 2, 3, -1, -2, -3 => 0, 2, 4 => +ve
//1, 3, 5 => -ve
public class RearrangeArrayElementBySign
{
    public static void ReArrange(int[] a)
    {
        int positive = 0;
        int negative = 1;
        int[] newArray = new int[a.Length];
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] > 0)
            {
                newArray[positive] = a[i];
                positive += 2;
            }
            else
            {
                newArray[negative] = a[i];
                negative += 2;
            }
        }
        Console.WriteLine(string.Join(", ", newArray));
    }

    // Oct 7 2024
    public static void ReArrangeNew(int[] a)
    {
        int positive = 0;
        int negative = 1;
        while (positive < a.Length && negative < a.Length)
        {
            if (a[positive] > 0)
            {
                positive += 2;
            }
            if (a[negative] < 0)
            {
                negative += 2;
            }
            else
            {
                if (a[positive] < 0)
                {
                    Swap(a, positive, negative);
                    negative += 2;
                    positive += 2;
                }
            }
        }
        Console.WriteLine(string.Join(", ", a));
    }

    private static void Swap(int[] a, int x, int y)
    {
        int temp = a[x];
        a[x] = a[y];
        a[y] = temp;
    }
}
