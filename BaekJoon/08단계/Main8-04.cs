using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._08단계
{
    internal class Main8_04
    {
        public static bool Sosu(int x)
        {
            int y = 2;
            while (y * y <= x)
            {
                if (x % y == 0 && x != y)
                {
                    return false;
                }
                y++;
            }
            return true;
        }
        static void Main4(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            int m = int.Parse(s[0]);
            int n = int.Parse(s[1]);
            StringBuilder sb = new StringBuilder();

            for (int i = m; i <= n; i++)
            {
                if (Sosu(i) && i != 1)
                    sb.Append(i + "\n");
            }
            Console.WriteLine(sb.ToString());
        }

    }
}
