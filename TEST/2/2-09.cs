using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST._2
{
    internal class _2_09
    {
        static void Main9(string[] args)
        {
            Console.WriteLine("3! = " + Factorial(3));
            Console.WriteLine("4! = " + Factorial(4));
            Console.WriteLine("5! = " + Factorial(5));
        }
        public static int Factorial(int n)
        {
            if(n <= 1)
                return 1;

            return n*Factorial(n-1);
        }
    }
}
