using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._07단계
{
    internal class Main7_01
    {
        static void Main1(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);
            int c = int.Parse(s[2]);
            double x = 0;
            if (c - b > 0) 
            { 
                x = a / (c - b);
                if (Math.Ceiling(x) == x) { x++; }
            }
            else { x = -1; }
            Console.WriteLine(Math.Ceiling(x));
        }
    }
}
