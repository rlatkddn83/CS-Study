using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._08단계
{
    internal class Main8_05
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
        static void Main5(string[] args)
        {
            List<int> nl = new List<int>();
            while (true)
            {
                nl.Add(int.Parse(Console.ReadLine()));
                if (nl[nl.Count - 1] == 0)
                    break;
            }
            StringBuilder sb = new StringBuilder();
            foreach (int n in nl)
            {
                if (n != 0)
                {
                    int c = 0;
                    for (int i = n + 1; i <= 2 * n; i++)
                    {
                        if (Sosu(i) && i != 1)
                            c++;
                    }
                    sb.AppendLine(c + "");
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}