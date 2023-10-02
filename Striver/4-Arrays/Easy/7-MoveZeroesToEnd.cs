namespace dsaproblem.Striver.Arrays.Easy;

public class MoveZeroesToEnd
{
    public static void MoveZeroesToEndBrute(int[] a)
    {
        int j = 0;
        int[] res = new int[a.Length];
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] != 0)
            {
                res[j] = a[i];
                j++;
            }
        }
        Console.WriteLine(string.Join(",", res));
    }

    public static void MoveZeroesToEndOptimal(int[] a)
    {
        int i = 0;
        for (int j = 1; j < a.Length; j++)
        {
            if (a[j] != 0)
            {
                if (a[i] == 0)
                {
                    int temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                }
            }
            if (a[i] != 0)
                i++;
        }
        Console.WriteLine(string.Join(", ", a));
    }

    public static void MoveZeroesToStartOptimal(int[] a)
    {
        int i = a.Length - 1;
        for(int j = a.Length - 2; j >= 0; j--)
        {
            if(a[i] == 0)
            {
                if(a[j] != 0)
                {
                    int temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                    i--;
                }
            }
            if(a[i] != 0)
            i--;
        }
        Console.WriteLine(string.Join(", ", a));
    }
}