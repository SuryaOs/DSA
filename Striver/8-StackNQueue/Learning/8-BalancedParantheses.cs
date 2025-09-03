namespace StackNQueue.Learning;

public class BalancedParantheses
{
    public static void Brute()
    {
        string s = "({})";
        Console.WriteLine($"{(Balance(s) ? "Balanced" : "Fked Up")}");

    }
    public static bool Balance(string s)
    {
        if (s.Length == 0) return false;

        Stack<char> stack = new();
        foreach (var c in s)
        {
            if (c == '[' || c == '{' || c == '(')
                stack.Push(c);
            else
            {
                if (stack.Count == 0) return false;

                if ((c == ']' && stack.Pop() == '[') ||
                 (c == '}' && stack.Pop() == '{') ||
                 (c == ')' && stack.Pop() == '('))
                    continue;
                else
                    return false;

            }
        }
        return stack.Count == 0;
    }
}