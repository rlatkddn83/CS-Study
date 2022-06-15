using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._07단계
{
    internal class Main7_06
    {
        static void Main6(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            int[] r = new int[t];
            for (int i = 0; i < t; i++)
            {
                int k = int.Parse(Console.ReadLine());
                int n = int.Parse(Console.ReadLine());
                int[,] p = new int[(k + 1), n];
                for (int j = 0; j <= k; j++)
                {
                    p[j, 0] = 1;
                    for (int l = 1; l < n; l++)
                    {
                        if (j == 0)
                        {
                            p[0, l] = l + 1;
                            continue;
                        }
                        p[j, l] = p[j - 1, l] + p[j, l - 1];
                    }
                }
                 r[i] = p[k, n - 1];
            }
            foreach (int s in r)
            {
                Console.WriteLine(s);
            }
        }
    }
}
