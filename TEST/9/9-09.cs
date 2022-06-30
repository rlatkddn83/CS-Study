using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST._9
{
    internal class _9_09
    {
        static void Main9(string[] args)
        {
            Print(10);
            Print(0.123);
            Print("sum = ", 123.4);

        }

        public static void Print(double x)
        {
            Console.WriteLine(x);
        }

        public static void Print(string s, double x)
        {
            Console.WriteLine(s+x);
        }

        public static void Print(int x)
        {
            Console.WriteLine(x);
        }
    }
}
