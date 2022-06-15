using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._06단계
{
    internal class Main6_09
    {
        static void Main9(string[] args)
        {
            string s = Console.ReadLine();
            string[] cro = { "c=", "c-", "dz=", "d-", "lj", "nj", "s=", "z=" };
            int n = s.Length;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < cro.Length; j++)
                {
                    for (int k = 0; k < cro[j].Length; k++)
                    {
                        if (i + cro[j].Length > s.Length)
                            break;
                        if (s[i+k] != cro[j][k])
                            break;
                        else if (k == cro[j].Length - 1)
                        {
                            n -= (cro[j].Length - 1);
                            i += (cro[j].Length - 1);
                        }
                    }
                }
            }
            Console.WriteLine(n);
        }
    }
}
