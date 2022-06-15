using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._07단계
{
    internal class Main7_04
    {
        static void Main4(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);
            int v = int.Parse(s[2]);
            double c = (a - b);
            double i = Math.Ceiling((v - a) / c) + 1;
            Console.WriteLine(i);
        }
    }
}
