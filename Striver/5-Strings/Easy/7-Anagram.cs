namespace dsaproblem.Striver.Strings.Easy;

public class Anagram
{
    public static void Brute(string s, string t)
    {
        if (s.Length != t.Length)
        {
            Console.WriteLine("Not an Anagram");
            return;
        }
        int[] hash = new int[26];
        for (int i = 0; i < s.Length; i++)
        {
            hash[s[i] - 'a']++;
            hash[t[i] - 'a']--;
        }
        for (int i = 0; i < hash.Length; i++)
        {
            if (hash[i] != 0)
            {
                Console.WriteLine("Not An Anagram");
                return;
            }
        }
        Console.WriteLine("Anagram");
    }
}
