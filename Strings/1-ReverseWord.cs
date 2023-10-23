using System.Text;

namespace dsaproblem.Strings;

public static class ReverseWord
{
    // Thats Why you Failed
    // Ignore below inbuilt bull sh*t
    public static void ReverseStringInbuilt(string word)
    {
        var words = word.Split('.');
        var reversedWords = words.Reverse();
        Console.WriteLine(string.Join(".", reversedWords));
    }
    public static void ReverseString(string sentence)
    {
        var words = sentence.Split(" ");
        foreach (var word in words)
        {
            ReverseAWord(word);
            Console.Write(" ");
        }
    }
    public static void ReverseAWord(string word)
    {
        var len = word.Length - 1;
        if (len == 0) { Console.Write(word); return; };

        Char[] charArray = word.ToCharArray();
        int i = 0;
        int j = len;

        while (i <= j)
        {
            char temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            i++;
            j--;
        }
        Console.Write(string.Join("", charArray));
    }
}