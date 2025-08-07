using dsaproblem.Striver.Strings.Easy;
using dsaproblem.StriverStrings.Easy;

namespace dsaproblem.Striver.Strings;

public class StringExtension
{
    public static void Practice()
    {
        string s = "((()))";
        string s2 = "()(()())(())";
        // RemoveOuterParantheses.Optimal(s2);
        string s3 = "welcome to the jungle ";
        // ReverseEveryWord.Brute(s3);
        string s4 = "534789000";
        // LargestOddNumbers.Brute(s4);
        string[] str = { "dog", "cat", "animal", "monkey" };
        // LongestCommonPrefix.Brute(str);
        string s5 = "abcde";
        string goal = "adeac";
        // RotateString.Optimal(s5, goal);
        string s6 = "anagram";
        string s7 = "takatuk";
        // Anagram.Brute(s6, s7);
        string s8 = "boo";
        string s9 = "off";
        Ismorphic.Brute(s8, s9);

    }
}