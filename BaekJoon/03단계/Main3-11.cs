using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._03단계
{
    internal class Main3_11
    {
        static void Main11(string[] args)
        {
            string[] inp = Console.ReadLine().Split();
            int x = int.Parse(inp[0]);
            int y = int.Parse(inp[1]);
            string[] nums = Console.ReadLine().Split();
            string print = "";

            for (int i = 0; i < x; i++)
            {
                if (int.Parse(nums[i]) < y)
                {
                    print += nums[i]+" ";
                }
            }
            Console.WriteLine(print);
        }
    }
}
