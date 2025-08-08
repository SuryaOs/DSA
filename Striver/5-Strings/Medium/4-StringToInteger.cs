namespace dsaproblem.Striver.Strings.Medium;

public class StringToInteger
{
    public static void Brute(string s)
    {
        // Fails In Edge Case => -12-35
        int ans = 0;
        bool negative = false;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == ' ')
                continue;
            if (s[i] == '-')
            {
                negative = true;
                continue;
            }
            if (!char.IsDigit(s[i]))
                break;

            var num = s[i] - '0';
            ans = (ans * 10) + num;
        }
        if (negative)
        {
            ans = -ans;
        }
        Console.WriteLine(ans);
    }

    public static void Optimal(string s)
    {
        int i = 0;
        bool negative = false;
        int ans = 0;
        while (i < s.Length && i == ' ')
            i++;
        if (s[i] == '-')
        {
            negative = true;
            i++;
        }
        while (i < s.Length && char.IsDigit(s[i]))
        {
            var num = s[i] - '0';
            ans = ans * 10 + num;
            i++;
        }
        if (negative)
            ans = -ans;
        Console.WriteLine(ans);
    }
}
