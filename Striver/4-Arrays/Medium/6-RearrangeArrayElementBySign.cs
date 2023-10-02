
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
}