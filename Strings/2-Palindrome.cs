using System.Net;
using System.Text;

namespace dsaproblem.Strings;

public static class Palindrome
{
    public static void CheckPalindrome(string word)
    {
      List<char> duplicates = new List<char>();
    HashSet<char> seenCharacters = new HashSet<char>();

    foreach (char c in word)
    {
        if (!seenCharacters.Add(c) && !duplicates.Contains(c))
            duplicates.Add(c);
    }

    Console.WriteLine(string.Join(",", duplicates));
    }










    //AMMA
    public static void IsPalindrome(string word)
    {
      StringBuilder stringBuilder = new StringBuilder();
      for(int i = word.Length-1; i >= 0; i--)
      {
        stringBuilder.Append(word[i]);
      }
      Console.WriteLine(stringBuilder.ToString());
    }

    public static void IsPalindromeEfficient(string word)
    {
      int left = 0;
      int right = word.Length-1;
      bool IsPalindrome = true;
      while(left < right)
      {
        if(word[left] != word[right])
        {
          IsPalindrome = false;
          break;
        }
        left++;
        right--;
      }
      Console.WriteLine(IsPalindrome ? $"{word} is a palindrome" : $"{word} is not a palindrome");
    }
}