using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST._2
{
    internal class _2_10
    {
        static void Main10(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write(Fibo(i) + " ");
            }
        }

        public static int Fibo(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            
            return Fibo(n-1) + Fibo(n-2);
        }
    }
}
