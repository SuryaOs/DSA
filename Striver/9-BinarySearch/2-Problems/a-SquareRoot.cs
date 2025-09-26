namespace BinarySearch.Problems;

public class SquareRoot
{
    public static void Run()
    {
        int a = 28;
        // Console.WriteLine(Brute(a)); 
        /*
            Possible => 1, 2, 3, 4, 5
            Not Possible => 6, 7, 8, .....
            Till certain range is possible and after that not possible can apply BS
            Low ends up on first not possible
            High ends up on max possible (ans)
        */
        Console.WriteLine(Optimal(a));

    }
    private static int Brute(int a)
    {
        int ans = 1;
        for (int i = 0; i <= a; i++)
        {
            if (i * i <= a) ans = i;
            else break;
        }
        return ans;
    }
    private static int Optimal(int a)
    {
        int low = 1;
        int high = a;
        int ans = 1;
        while (low <= high)
        {
            long mid = (low + high) / 2;
            if (mid * mid > a)
            {
                high = (int)mid - 1;
            }
            else
            {
                ans = (int)mid;
                low = (int)mid + 1;
            }
        }
        return ans;
    }
}