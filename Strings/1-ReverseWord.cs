using System.Text;

namespace dsaproblem.Strings;

public static class ReverseWord
{
    public static void ReverseString(string word)
    {
        var words = word.Split('.');
        var reversedWords = words.Reverse();
        Console.WriteLine(string.Join(".", reversedWords));
    }
}