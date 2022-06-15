using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._07단계
{
    internal class Main7_07
    {
        static void Main7(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = n / 5;
            int p = 0;
            for (int i = m; i >= 0; i--)
            {
                int l = n - (5 * i);
                if (l % 3 == 0)
                {
                    p = i + (l / 3);
                    break;
                }
                else if (i == 0) { p = -1; }
            }
            Console.WriteLine(p);
        }
    }
}
