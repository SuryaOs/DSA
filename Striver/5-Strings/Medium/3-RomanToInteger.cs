namespace dsaproblem.Striver.Strings.Medium;

public class RomanToInteger
{
    public static void Optimal(string s)
    {
        Dictionary<char, int> map =
            new()
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };
        int num = 0;
        for (int i = 0; i < s.Length; i++)
        {
            int curr = map[s[i]];
            int next = i + 1 == s.Length ? 0 : map[s[i + 1]];
            if (curr > next)
            {
                num += curr;
            }
            else
            {
                num -= curr;
            }
        }
        Console.WriteLine(num);
    }
}
