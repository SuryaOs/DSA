namespace ReviseExtension.Strings;

public class StringToInteger
{
    public static void Brute()
    {
        // -12-35 Fails In Edge Case Again :(
        string s = "-12-35";
        bool neg = false;
        int num = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == ' ') continue;

            if (s[i] == '-') { neg = true; continue; }

            if (!char.IsDigit(s[i])) break;

            num = (num * 10) + (s[i] - '0');
        }
        if (neg) num = -num;
        Console.WriteLine(num);
    }
    public static void Optimal()
    {
        string s = "   -12-35";
        bool neg = false;
        int i = 0;
        while (i < s.Length)
        {
            if (s[i] == '-')
            {
                neg = true;
                i++;
                break;
            }
            if (char.IsDigit(s[i])) break;
            i++;
        }
        int num = 0;
        while (i < s.Length)
        {
            if (!char.IsDigit(s[i])) break;

            num = (num * 10) + (s[i] - '0');
            i++;
        }
        if (neg) num = -num;
        Console.WriteLine(num);
    }
}