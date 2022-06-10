using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._03단계
{
    internal class Main3_12
    {
        static void Main12(string[] args)
        {
            string[] inp = new string[2];
            int x = 0;
            int y = 0;
            StringBuilder sb = new StringBuilder();

            while (true)
            {
                inp = Console.ReadLine().Split();
                x = int.Parse(inp[0]);
                y = int.Parse(inp[1]);
                if (x == 0 && y == 0)
                {
                    break;
                }
                int result = x + y;
                sb.Append(result + "\n");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
