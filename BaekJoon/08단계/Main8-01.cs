using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._08단계
{
    internal class Main8_01
    {
        public static bool Sosu(int x)
        {
            int y = 2;
            while (y < x)
            {
                if (x % y == 0 && x != y) 
                {
                    return false;
                }
                y++;
            }
            return true;
        }
        static void Main1(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] s = Console.ReadLine().Split();
            int[] m = new int[n];
            bool[] b = new bool[n];
            int l = 0;

            for (int i = 0; i < n; i++)
            {
                m[i] = int.Parse(s[i]);
                if (Sosu(m[i]) && m[i] != 1) 
                {
                    l++;
                }
            }
            Console.WriteLine(l);
        }
    }
}
