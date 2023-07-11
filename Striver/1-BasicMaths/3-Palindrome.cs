namespace dsaproblem.Striver.BasicMaths;

public class Palindrome
{
    public static void print(int num)
    {
        int rnum = 0;
        int n = num;
        while (n > 0)
        {
            int rem = n % 10;
            rnum = (rnum * 10) + rem;
            n = n / 10;
        }

     Console.WriteLine($"{num} is {(rnum == num ? "paldinrome" : "not palrindrom")}");

    }
}