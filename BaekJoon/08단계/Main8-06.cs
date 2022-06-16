using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._08단계
{
    internal class Main8_06
    {
        public static bool Sosu(int x, List<int> s)
        {
            foreach (int se in s)
            {
                if (x % se == 0 && x != se)
                {
                    return false;
                }
            }
            return true;
        }

        public static string Gp(int x, List<int> s)
        {
            int m = 10000;
            string r = "";
            for (int i = 0; i < s.Count; i++)
            {
                if (x < s[i]) { break; }
                for (int j = i; j < s.Count; j++)
                {
                    if (x < s[j]) { break; }
                    if (x == s[i] + s[j] && m > j - i)
                    {
                        m = j - i;
                        r = s[i] + " " + s[j];
                    }
                }
            }
            return r;
        }

        static void Main6(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] ts = new int[n];
            for (int i = 0; i < n; i++)
            {
                ts[i] = int.Parse(Console.ReadLine());
            }
            List<int> s = new List<int>();
            s.Add(2);
            for (int i = 3; i < 10000; i += 2)
            {
                if (Sosu(i,s))
                    s.Add(i);
            }
            StringBuilder sb = new StringBuilder();
            foreach (int t in ts)
            {
                sb.AppendLine(Gp(t, s));
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
