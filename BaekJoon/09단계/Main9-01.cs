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
            if (n <= 1)
                return 1;
            return n * Fac(n - 1);
        }
        static void Main1(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int r = Fac(n);
            Console.WriteLine(r);
        }
    }
}
