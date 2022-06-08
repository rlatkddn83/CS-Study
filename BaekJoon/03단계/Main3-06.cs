using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon._03단계
{
    internal class Main3_06
    {
        static void Main6(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < input; i++)
            {
                sb.Append((input - i) + "\n");
            }
            Console.WriteLine(sb.ToString());
        }

    }
}
