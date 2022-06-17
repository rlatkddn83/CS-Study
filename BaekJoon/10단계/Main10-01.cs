using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._10단계
{
    internal class Main10_01
    {
        static void Main1(string[] args)
        {
            string[] nm = Console.ReadLine().Split();
            string[] cds = Console.ReadLine().Split();
            int n = int.Parse(nm[0]);
            int m = int.Parse(nm[1]);
            int r = m;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++) 
                {
                    for (int k = j + 1; k < n; k++) 
                    {
                        int sum = int.Parse(cds[i]) + int.Parse(cds[j]) + int.Parse(cds[k]);
                        if (m-sum < r && sum <= m) { r = m-sum; }
                    }
                }
            }
            Console.WriteLine(m-r);
        }
    }
}
