using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST._9
{
    internal class _9_05
    {
        static void Main5(string[] args)
        {
            int a = 10;
            int b = 20;
            int c = 30;

            Console.WriteLine("가장 큰 수는 {0} 입니다.", Larger(Larger(a,b),c));
        }

        public static int Larger(int a, int b)
        {
            return (a >= b) ? a : b;
        }
    }
}
