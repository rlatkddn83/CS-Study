using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._10단계
{
    internal class Main10_02
    {
        static void Main(string[] args)
        {
            string m = Console.ReadLine();
            int mn = int.Parse(m);
            int l = m.Length;
            int n = 1;
            if (mn - (l * 9) >= 1)
            {
                n = mn - (l * 9);
            }
            int r = 0;
            for (int i = n; i < mn; i++)
            {
                string ii = i.ToString();
                int s = 0;
                for (int j = 0; j < ii.Length; j++)
                {
                    s += int.Parse(ii[j].ToString());
                }
                if (i + s == mn)
                {
                    r = i;
                    break;
                }
            }

            Console.Write(r);
        }
    }
}
