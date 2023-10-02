namespace dsaproblem.Striver.Arrays.Easy;

public class FindMissingNumber
{
    // 1, 2, 4, 5
    // XOR is optimal
    // Normal , Summing n , summing array then subtracting
    public static void Find(int[] a)
    {
        // int sum = 1;
        // for(int i = 0; i < a.Length; i++)
        // {
        //     sum += i;
        //     sum -=a[i];
        // }
        // Console.WriteLine(sum);
        int xor1 = 0;
        int xor2 = 0;
        for(int i = 0; i < a.Length; i++)
        {
            xor1 ^= i+1;
            xor2 ^= a[i];
        }
        xor1 ^= a.Length+1;
        int res = xor1 ^ xor2;
        Console.WriteLine(res);
        
    }
}