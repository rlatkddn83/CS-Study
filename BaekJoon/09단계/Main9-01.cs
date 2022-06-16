using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._09단계
{
    internal class Main9_01
    {
        public static int Fac(int n)
        {
            int x = 1;
                x = n * Fac(n-1);

            return x;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int r = Fac(n);
        }
    }
}
