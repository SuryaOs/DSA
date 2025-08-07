namespace dsaproblem.Striver.Strings.Easy;

public class Ismorphic
{
    public static void Brute(string s, string t)
    {
        // bar, foe
        Dictionary<char, char> dicS = new();
        Dictionary<char, char> dicT = new();
        if (s.Length != t.Length)
        {
            Console.WriteLine("Not Isomorphic");
            return;
        }
        for (int i = 0; i < s.Length; i++)
        {
            if (
                dicS.ContainsKey(s[i]) && dicS[s[i]] != t[i]
                || dicT.ContainsKey(t[i]) && (dicT[t[i]] != s[i])
            )
            {
                Console.WriteLine("Not An IsoMorphic");
                return;
            }
            dicS[s[i]] = t[i]; // bf, ao, r
            dicT[t[i]] = s[i]; // fb, oa
        }
        Console.WriteLine("Isomorphic");
    }
}
