using System.Text;

namespace dsaproblem.Striver.Strings.Easy;

public class RotateString
{
    public static void Optimal(string s, string goal)
    {
        string temp = s + s;
        Console.WriteLine($"{temp.Contains(goal)}");
    }
    public static void Brute(string s, string goal)
    {
        for (int i = 0; i < s.Length; i++)
        {
            s = Rotate(s);
            if (s == goal)
            {
                Console.WriteLine("True");
                return;
            }
        }
        Console.WriteLine("False");
    }
    private static string Rotate(string s)
    {
        char temp = s[0];
        StringBuilder sb = new();
        for (int i = 1; i < s.Length; i++)
        {
            sb.Append(s[i]);
        }
        sb.Append(temp);
        return sb.ToString();
    }
}
