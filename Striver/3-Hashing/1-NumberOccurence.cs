using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dsaproblem.Striver.Hashing
{
    public class NumberOccurence
    {
        public static void Print()
        {
            Console.WriteLine("Enter Size of the Array");
            int n = Convert.ToInt16(Console.ReadLine());

            int[] a = new int[n];
            Console.WriteLine("Enter Array Value");
            for(int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt16(Console.ReadLine());
            }

            Console.WriteLine("Enter Numbers To Check Brother");
            int q = Convert.ToInt32(Console.ReadLine());

            int[] hash = new int[13];
            for(int i = 0; i < n; i++)
            {
                hash[a[i]]++;
            }

            Console.WriteLine("Enter Array Value");
            for(int i = 0; i < q; i++)
            {
               int numbersToCheck = Convert.ToInt32(Console.ReadLine());
               Console.WriteLine("Occurence" + hash[numbersToCheck]);
            }
        }
    }
}