using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._07단계
{
    internal class Main7_08
    {
        static void Main8(string[] args)
        {
            string[] n = Console.ReadLine().Split();
            int l1 = n[0].Length;
            int l2 = n[1].Length;
            int l = 0;
            if (l1 >= l2)
                l = l1;
            else
                l = l2;
            List<int> n1 = new List<int>();
            List<int> n2 = new List<int>();
            List<int> n3 = new List<int>();
            int c = 0;
            for (int i = 0; i <= l; i++)
            {
                if (l1 - i - 1 < 0) { n1.Add(0); }
                else { n1.Add(int.Parse(n[0][l1 - i - 1].ToString())); }
                if (l2 - i - 1 < 0) { n2.Add(0); }
                else { n2.Add(int.Parse(n[1][l2 - i - 1].ToString())); }
                int p = n1[i] + n2[i] + c;
                c = p / 10;
                n3.Add(p % 10);
            }

            
            for (int i = l; i >= 0; i--)
            {
                if (n3[i] == 0 && i==l) { continue; }
                else { Console.Write(n3[i]); }
            }
            Console.WriteLine();
        }
    }
}
