using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._06단계
{
    internal class Main6_06
    {
        static void Main6(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            int n = s.Length;
            if (s[0] == "")
                n--;
            if (s[s.Length-1] == "")
                n--;
            Console.WriteLine(n);
        }
    }
}
