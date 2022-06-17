using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._09단계
{
    internal class Main9_04
    {
        public static string[] Sq(int x)
        {
            string[] s = new String[x];
            if (x == 1)
            {
                s[0] = "*";
                return s;
            }
            string[] temp = Sq(x / 3);
            for (int i = 0; i < x/3; i++)
            {
                s[i] = temp[i] + temp[i] + temp[i];
            }
            for (int i = 0; i < x/3; i++)
            {
                s[i + (x / 3)] = temp[i] + "";
                for (int k = 0; k < (x / 3); k++) { s[i + (x / 3)] += " "; }
                s[i + (x / 3)] += temp[i]+""; 
            }
            for (int i = 0; i < x/3; i++)
            {
                s[i + (2 * x / 3)] = s[i];
            }
            return s;
        }
        static void Main4(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] r = new string[n];
            r = Sq(n);
            for (int i = 0; i < n; i++)
                Console.WriteLine(r[i]);
        }
    }
}
