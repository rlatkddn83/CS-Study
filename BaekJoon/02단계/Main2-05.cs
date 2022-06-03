using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._02단계
{
    internal class Main2_05
    {
        static void Main5(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int H = int.Parse(input[0]);
            int M = int.Parse(input[1]);

            int Mt = M - 45;
            if(Mt < 0)
            {
                Mt = M + 60 - 45;
                H--;
            }
            if (H < 0)
            {
                H = H + 24;
            }

            Console.WriteLine(H+" "+Mt);
        }
    }
}
