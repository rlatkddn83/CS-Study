using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._03단계
{
    internal class Main3_04
    {
        static void Main4(string[] args)
        {
            int innum = int.Parse(Console.ReadLine());
            string[] calnum = new string[2];
            StringBuilder sb = new StringBuilder();


            for (int i = 0; i < innum; i++)
            {
                calnum = Console.ReadLine().Split();
                int result = int.Parse(calnum[0]) + int.Parse(calnum[1]);

                sb.Append(result+"\n");
            }

            Console.WriteLine(sb.ToString());
            
        }
    }
}