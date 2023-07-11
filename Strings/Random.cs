using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsaproblem.Strings
{
    public static class Random
    {
        public static void Practice()
        {
            string w1 = "silent";
            string reversed = reverseIt(w1);
            Console.WriteLine("s" + reversed);
        }
        public static string reverseIt(string c) {
            if(c.Length <=1)
            {
                return c;
            }
           return reverseIt(c.Substring(1)) + c[0];
        }
    }
}