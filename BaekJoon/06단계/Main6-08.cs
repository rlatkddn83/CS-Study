using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._06단계
{
    internal class Main6_08
    {
        static void Main8(string[] args)
        {
            string w = Console.ReadLine();
            string[] dial = { "", "ABC", "DEF", "GHI", "JKL", "MNO", "PQRS", "TUV", "WXYZ", "" };
            int s = 0;
            for (int i = 0; i < w.Length; i++)
            {
                for (int j = 0; j < dial.Length; j++)
                {
                    for (int k = 0; k < dial[j].Length; k++)
                    {
                        if (w[i] == dial[j][k])
                        {
                            s += j + 2;
                        }
                    }
                }
            }
            Console.WriteLine(s);
        }
    }
}
