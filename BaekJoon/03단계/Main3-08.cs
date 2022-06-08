using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._03단계
{
    internal class Main3_08
    {
        static void Main8(string[] args)
        {
            int innum = int.Parse(Console.ReadLine());
            string[] instr = new string[2];
            int sum;
            string[] dap = new string[innum];
            for (int i = 0; i < innum; i++)
            {
                instr = Console.ReadLine().Split();
                sum = int.Parse(instr[0]) + int.Parse(instr[1]);
                dap[i] = instr[0]+" + " + instr[1]+ " = " + sum;
            }
            for (int i = 0; i < innum; i++)
            {
                Console.WriteLine("Case #{0}: {1}", i + 1, dap[i]);
            }
        }
    }
}
