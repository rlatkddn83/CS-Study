using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._03단계
{
    internal class Main3_07
    {
        static void Main7(string[] args)
        {
            int innum = int.Parse(Console.ReadLine());
            string[] instr = new string[2];
            int[] sum = new int[innum];
            for (int i = 0; i < innum; i++)
            {
                instr = Console.ReadLine().Split();
                sum[i] = int.Parse(instr[0]) + int.Parse(instr[1]);
            }
            for (int i = 0; i < innum; i++)
            {
                Console.WriteLine("Case #{0}: {1}", i + 1, sum[i]);
            }
        }
    }
}
