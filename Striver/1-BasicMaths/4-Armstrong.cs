namespace dsaproblem.Striver.BasicMaths;

public class Armstrong
{
    // 371  = 3^3 + 7^3 + 1^3
    public static void print(int n)
    {
        int num = n;
        int finalNum = 0;
        while(num > 0)
        {
            int r = num % 10;
            finalNum += (int)Math.Pow(r, 3);
            num = num/10;
        }

     Console.WriteLine($"{finalNum} is {(finalNum == n ? "armstrong" : "not armstrong")}");

    }
}