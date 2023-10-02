using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dsaproblem.Striver.Arrays.Medium
{
    public class NumberThatOccursNBy2
    {
        // This is better solution according to striver
        public static void FindNumber(int[] a)
        {
            int target = a.Length / 2;
            Dictionary<int, int> dict = new();
            for (int i = 0; i < a.Length; i++)
            {
                if (dict.ContainsKey(a[i]))
                {
                    dict[a[i]]++;
                }
                else
                    dict[a[i]] = 1;
            }

            foreach (var d in dict)
            {
                if (d.Value > target)
                {
                    Console.WriteLine(d.Key);
                }
            }
        }

        // Moore's Voting Algorithm
        public static void FindNumberOptimal(int[] a)
        {
            int contender = 0;
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (count == 0)
                    contender = a[i];
                if (a[i] == contender)
                    count++;
                else
                    count--;
            }
            Console.WriteLine("The winner of election is : " + contender);

            int finalCount = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == contender)
                    finalCount++;
            }

            Console.Write(finalCount > a.Length / 2 ? $"{contender} is Major" : "No Major");

        }
    }
}