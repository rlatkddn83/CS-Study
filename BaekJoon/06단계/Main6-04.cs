using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._06단계
{
    internal class Main6_04
    {
        static void Main4(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] s = new string[n];
            string[] p = new string[n];
            for (int i = 0; i < n; i++)
            {
                s[i] = Console.ReadLine();
                int x = int.Parse(s[i][0].ToString());
                for (int j = 2; j < s[i].Length; j++)
                {
                    for (int k = 0; k < x; k++)
                    {
                        p[i] += s[i][j];
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(p[i]);
            }
        }
    }
}
