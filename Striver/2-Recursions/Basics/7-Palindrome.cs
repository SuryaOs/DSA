namespace dsaproblem.Striver.Recursions.Basics;

public class Palindrome
{
    public static void Print(string a)
    {
        if (CheckPalindrome(a, 0, a.Length - 1))
            Console.WriteLine("It is PAl");
        else
            Console.WriteLine("It is not Pal");
    }

    private static bool CheckPalindrome(string a, int start, int end)
    {
        if (start >= end) return true;

        if (a[start] != a[end])
        {
            return false;
        }
        return CheckPalindrome(a, start + 1, end - 1);;
    }
}