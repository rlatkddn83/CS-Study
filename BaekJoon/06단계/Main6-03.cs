using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._06단계
{
    internal class Main6_03
    {
        static void Main3(string[] args)
        {
            string s = Console.ReadLine();
            int[] abc = new int[26];

            for (int i = 0; i < abc.Length; i++)
            {
                abc[i] = -1;
            }

            for (int i = 0; i < s.Length; i++)
            {
                int a = s[i] - 97;
                if (abc[a] == -1)
                    abc[a] = i;
            }
            for (int i = 0; i < abc.Length; i++)
            {
                Console.Write(abc[i] + " ");
            }
        }
    }
}
