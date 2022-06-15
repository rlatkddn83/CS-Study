using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._07단계
{
    internal class Main7_05
    {
        static void Main5(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            double[] re = new double[t];

            for (int i = 0; i < t; i++)
            {
                string[] s = Console.ReadLine().Split();
                int h = int.Parse(s[0]);
                int w = int.Parse(s[1]);
                int n = int.Parse(s[2]);
                int m = n % h;
                double d = n / (h + 0.0);
                if (m == 0) { re[i] = (h * 100) + Math.Ceiling(d); }
                else { re[i] = (m * 100) + Math.Ceiling(d); }
            }
            foreach (int r in re)
            {
                Console.WriteLine(r);
            }
        }
    }
}
