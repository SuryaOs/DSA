namespace dsaproblem.Striver.Strings.Medium;

public class SumOfBeautyOfSubStrings
{
    public static void Brute(string s)
    {
        int beauty = 0;
        for (int i = 0; i < s.Length; i++)
        {
            int[] hash = new int[26];
            for (int j = i; j < s.Length; j++)
            {
                hash[s[j] - 'a']++;
                int max = 0;
                int min = int.MaxValue;
                for (int k = 0; k < 26; k++)
                {
                    if (hash[k] > 0)
                    {
                        if (hash[k] > max)
                            max = hash[k];
                        if (hash[k] < min)
                            min = hash[k];
                    }
                }
                beauty = beauty + max - min;
            }
        }
        Console.WriteLine(beauty);
    }
}
