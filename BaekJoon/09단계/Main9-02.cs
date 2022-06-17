using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._09단계
{
    internal class Main9_02
    {
        public static int Fibo(int x)
        {
            if (x == 0)
                return 0;
            else if (x == 1)
                return 1;
            else
                return Fibo(x - 1) + Fibo(x - 2);
        }
        static void Main2(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Fibo(n));
        }
    }
}
