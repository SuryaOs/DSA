using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dsaproblem.Strings
{
    public static class CountWords
    {
        public static void CountWord(string word)
        {
            int count = 1;
            foreach(char c in word)
            {
                if(char.IsWhiteSpace(c))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}