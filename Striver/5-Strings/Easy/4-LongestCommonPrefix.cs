using System.Text;

namespace dsaproblem.StriverStrings.Easy;

public class LongestCommonPrefix
{
    public static void Brute(string[] str)
    {
        string s = str[0];
        for (int i = 1; i < str.Length; i++)
        {
            string ans = "";
            for (int j = 0; j < s.Length && j < str[i].Length; j++)
            {
                if (s[j] == str[i][j])
                {
                    ans += str[i][j];
                }
                else
                {
                    break;
                }
            }
            s = ans;
        }
        Console.WriteLine(s);
    }
     public static void Optimal(string[] str)
    {
        string s = str[0];
        for (int i = 1; i < str.Length; i++)
        {
            StringBuilder sb = new();
            for (int j = 0; j < s.Length && j < str[i].Length; j++)
            {
                if (s[j] == str[i][j])
                {
                    sb.Append(str[i][j]);
                }
                else
                {
                    break;
                }
            }
            s = sb.ToString();

            if (s == "")
                break;
        }
        Console.WriteLine(s);
    }
}
