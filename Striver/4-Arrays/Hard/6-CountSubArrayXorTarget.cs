using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dsaproblem.Striver.Arrays.Hard
{
    public class CountSubArrayXorTarget
    {
        public static void Brute(int[] a, int target)
        {
            int n = a.Length;
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                int xor = 0;
                for (int j = i; j < n; j++)
                {
                    xor ^= a[j];
                    if (xor == target) count++;
                }
            }
            Console.WriteLine(count);
        }
        // ---------- xor
        // 4, 2, 2, 6
        // --x -----k
        // x^k = xor => x = xor^k
        public static void Optimal(int[] a, int target)
        {
            Dictionary<int, int> dic = new();
            int xor = 0;
            int cnt = 0;
            dic[0] = 1;
            for (int i = 0; i < a.Length; i++)
            {
                xor ^= a[i];
                int pre = xor ^ target;

                if (dic.ContainsKey(xor)) dic[xor]++;
                else dic[xor] = 1;

                if (dic.ContainsKey(pre)) cnt = cnt + dic[xor];
            }
            Console.WriteLine(cnt);
        }
    }
}