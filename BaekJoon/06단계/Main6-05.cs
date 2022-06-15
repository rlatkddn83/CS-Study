using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._06단계
{
    internal class Main6_05
    {
        static void Main5(string[] args)
        {
            string s = Console.ReadLine().ToUpper();
            int[] ns = new int[26];
            int n;
            int max = 0;
            char pos = ' ';

            for (int i = 0; i < s.Length; i++)
            {
                n = s[i] - 65;
                ns[n]++;
            }
            for (int i = 0; i < ns.Length; i++)
            {
                if(ns[i] > max)
                {
                    max = ns[i];
                    pos = (char)(i+65);
                }
            }
            for (int i = 0; i < ns.Length; i++)
            {
                if (ns[i] == max)
                {
                    if ((pos-65)!=i)
                    {
                        pos = '?';
                    }
                }
            }
            Console.WriteLine(pos);
        }
    }
}
