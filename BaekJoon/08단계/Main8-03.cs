using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._08단계
{
    internal class Main8_03
    {
        public static int Insu(int x)
        {
            for (int i = 2; i < x; i++)
            {
                if (x % i == 0) 
                    return i;
            }
            return x;
        }
        static void Main3(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            while (n>1)
            {
                int i = Insu(n);
                n /= i;
                Console.WriteLine(i);
            }
        }
        
    }
}
