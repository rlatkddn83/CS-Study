using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._02단계
{
    internal class Main2_06
    {
        static void Main6(string[] args)
        {
            string[] input1 = Console.ReadLine().Split();
            string input2 = Console.ReadLine();

            int H = int.Parse(input1[0]);
            int M = int.Parse(input1[1]);
            int Mp = int.Parse(input2);

            int MpH = Mp / 60;
            int MpM = Mp % 60;

            int Mt = M + MpM;
            int Ht = H + MpH;

            if (Mt >= 60)
            {
                Mt -= 60;
                Ht++;
            }
            if (Ht >= 24)
            { Ht -= 24;}

            Console.WriteLine("{0} {1}",Ht,Mt);
        }
    }
}
