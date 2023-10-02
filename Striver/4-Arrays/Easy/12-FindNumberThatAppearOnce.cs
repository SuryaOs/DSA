namespace dsaproblem.Striver.Arrays.Easy;

public class FindNumberThatAppearOnce
{
    // XOR
    public static void FindUniqueOptimal(int[] a)
    {
        int unique = a[0];
        for (int i = 1; i < a.Length; i++)
        {
            unique^= a[i];
        }
        Console.WriteLine(unique);
    }

    public static void FindUnique(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            int count = 0;
            for (int j = 0; j < a.Length; j++)
            {
                if (a[i] == a[j])
                {
                    count++;
                }
            }
            if (count == 1)
            {
                Console.WriteLine($"{a[i]} is unique ");
            }
        }
    }
}