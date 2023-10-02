namespace interview;

public class Program
{
    public static void Main(string[] args)
    {
        int x = 6794;
        while (x != 6174)
        {
            x = PrintResultLessCode(x);
            Console.WriteLine(x);
        }
    }
    public static int PrintResult(int a)
    {

        int size = (int)Math.Floor(Math.Log10(a)) + 1;

        int[] digits = new int[size];
        for (int i = 0; i < size; i++)
        {
            digits[i] = a % 10;
            a = a / 10;
        }

        Array.Sort(digits);

        // 4 9 7 6
        int descendingNumber = 0;
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            descendingNumber = (descendingNumber * 10) + digits[i];
        }

        int ascendingNumber = 0;
        for (int i = 0; i < digits.Length; i++)
        {
            ascendingNumber = (ascendingNumber * 10) + digits[i];
        }

        int diff = descendingNumber - ascendingNumber;
        return diff;
    }

    public static int PrintResultLessCode(int a)
    {
        int size = (int)Math.Floor(Math.Log10(a)) + 1;

        int[] digits = new int[size];
        for (int i = 0; i < size; i++)
        {
            digits[i] = a % 10;
            a = a / 10;
        }

        Array.Sort(digits);
        int descendingNumber = digits[3] * 1000 + digits[2] * 100 + digits[1] * 10 + digits[0];
        int ascendingNumber = digits[0] * 1000 + digits[1] * 100 + digits[2] * 10 + digits[3];

        return descendingNumber - ascendingNumber;
    }
}